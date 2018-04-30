﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace AutoRent.Database {
    class DbManager {
        public bool VerifyCredentials(string userName, string password) {
            using (var ctx = new AppDbContext()) {
                var pwd = String.Empty;
                using (var halg = HashAlgorithm.Create("sha256")) {
                    var hash = halg.ComputeHash(Encoding.Unicode.GetBytes(password));
                    foreach (var b in hash) {
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
                ctx.Cars.Add(car);
                ctx.SaveChanges();
            }
        }
        public void EditCar(CarEntity car) {
            using (var ctx = new AppDbContext()) {
                var existingCar = ctx.Cars.First(x => x.ID == car.ID);
                existingCar.RegNumber = car.RegNumber;
                existingCar.RentPricePerDay = car.RentPricePerDay;
                ctx.SaveChanges();
            }
        }
        public void RemoveCar(CarEntity car) {
            using (var ctx = new AppDbContext()) {
                var existingCar = ctx.Cars.First(x => x.ID == car.ID);
                ctx.Cars.Remove(existingCar);
                ctx.SaveChanges();
            }
        }

        #endregion

        public IList<ClientEntity> GetClients() {
            using (var ctx = new AppDbContext()) {
                var list = ctx.Clients
                    .Include(x => x.Rents);
                foreach (var item in list) {
                    item.ActiveRentCount = item.Rents.Count(x => x.LeaseEnded == null);
                }
                return list.ToList();
            }
        }

        public void AddClient(ClientEntity client) {
            using (var ctx = new AppDbContext()) {
                ctx.Clients.Add(client);
                ctx.SaveChanges();
            }
        }
        public void EditClient(ClientEntity client) {
            using (var ctx = new AppDbContext()) {
                var existingClient = ctx.Clients.First(x => x.ID == client.ID);
                existingClient.FirstName = client.FirstName;
                existingClient.LastName = client.LastName;
                existingClient.PhoneNumber = client.PhoneNumber;
                existingClient.Email = client.Email;
                existingClient.Address = client.Address;
                ctx.SaveChanges();
            }
        }

        public void RentCar(CarRent carRent) {
            using (var ctx = new AppDbContext()) {
                carRent.LeaseStarted = DateTime.Now;
                ctx.Rents.Add(carRent);
                ctx.SaveChanges();
            }
        }

        public void ReturnCar(int clientID, int carID) {
            using (var ctx = new AppDbContext()) {
                var exisitngRent = ctx.Rents.First(x => x.ClientID == clientID && x.CarID == carID);
                exisitngRent.LeaseEnded = DateTime.Now;
                ctx.SaveChanges();
            }
        }
    }
}
