using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AutoRent.Database {
    class DbManager {
        public Boolean VerifyCredentials(String userName, String password) {
            using (var ctx = new AppDbContext()) {
                String pwd = String.Empty;
                using (HashAlgorithm halg = HashAlgorithm.Create("sha256")) {
                    Byte[] hash = halg.ComputeHash(Encoding.Unicode.GetBytes(password));
                    foreach (Byte b in hash) {
                        pwd += $"{b:x2}";
                    }
                }

                return ctx.Operators.Any(x => x.UserName == userName && x.HashedPassword.Equals(pwd));
            }
        }

        #region cars
        public IList<CarEntity> GetCars() {
            using (var ctx = new AppDbContext()) {
                return ctx.Cars.ToList();
            }
        }
        public IList<CarEntity> GetFreeCars() {
            using (var ctx = new AppDbContext()) {
                return ctx.Cars.Where(x => x.CurrentClient == null).ToList();
            }
        }
        public void AddCar(CarEntity car) {
            using (var ctx = new AppDbContext()) {
                if (ctx.Cars.Any(x => x.RegNumber == car.RegNumber))
                {
                    throw new Exception("Car with such registration number exists!");
                }
                ctx.Cars.Add(car);
                ctx.SaveChanges();
            }
        }
        public void EditCar(CarEntity car) {
            using (var ctx = new AppDbContext()) {
                if (ctx.Cars.Any(x => x.RegNumber == car.RegNumber))
                {
                    throw new Exception("Car with such registration number exists!");
                }
                CarEntity existingCar = ctx.Cars.First(x => x.ID == car.ID);
                existingCar.RegNumber = car.RegNumber;
                existingCar.RentPricePerDay = car.RentPricePerDay;
                ctx.SaveChanges();
            }
        }
        public void RemoveCar(CarEntity car) {
            using (var ctx = new AppDbContext())
            {
                if (car.ClientID == null)
                {
                    throw new Exception("Car is rented!");
                }
                CarEntity existingCar = ctx.Cars.First(x => x.ID == car.ID);
                ctx.Cars.Remove(existingCar);
                ctx.SaveChanges();
            }
        }
        #endregion


        #region clients
        public IList<ClientEntity> GetClients() {
            using (var ctx = new AppDbContext()) {
                IQueryable<ClientEntity> list = ctx.Clients
                    .Include(x => x.Rents);
                foreach (ClientEntity item in list) {
                    item.ActiveRentCount = item.Rents.Count;
                }
                return list.ToList();
            }
        }
        public void AddClient(ClientEntity client) {
            using (var ctx = new AppDbContext()) {
                if (ctx.Clients.Any(x => x.PersonalNumber == client.PersonalNumber))
                {
                    throw new Exception("Client with such personal number exists!");
                }
                ctx.Clients.Add(client);
                ctx.SaveChanges();
            }
        }
        public void EditClient(ClientEntity client) {
            using (var ctx = new AppDbContext()) {
                ClientEntity existingClient = ctx.Clients.First(x => x.ID == client.ID);
                existingClient.FirstName = client.FirstName;
                existingClient.LastName = client.LastName;
                existingClient.PhoneNumber = client.PhoneNumber;
                existingClient.Email = client.Email;
                existingClient.Address = client.Address;
                ctx.SaveChanges();
            }
        }
        #endregion


        #region Rent/Return
        public ClientEntity GetClientWithRents(Int32 clientID) {
            using (var ctx = new AppDbContext()) {
                return ctx.Clients
                    .Include(x => x.Rents)
                    .Include("Rents.Car")
                    .First(x => x.ID == clientID);
            }
        }
        public void RentCar(CarRent carRent) {
            using (var ctx = new AppDbContext()) {
                CarEntity car = ctx.Cars.First(x => x.ID == carRent.CarID);
                car.ClientID = carRent.ClientID;
                ctx.Rents.Add(carRent);
                ctx.SaveChanges();
            }
        }
        public void ReturnCar(Int32 leaseID) {
            using (var ctx = new AppDbContext()) {
                CarRent exisitngRent = ctx.Rents.First(x => x.ID == leaseID);
                ctx.Rents.Remove(exisitngRent);
                CarEntity car = ctx.Cars.First(x => x.ID == exisitngRent.CarID);
                car.ClientID = null;
                ctx.SaveChanges();
            }
        }
        #endregion
    }
}
