using System;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using AutoRent.Database;

namespace AutoRent.Migrations {
    sealed class Configuration : DbMigrationsConfiguration<AppDbContext> {
        public Configuration() {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context) {
            if (!context.Operators.Any()) {
                String pwd = null;
                using (HashAlgorithm halg = HashAlgorithm.Create("sha256")) {
                    Byte[] hash = halg.ComputeHash(Encoding.Unicode.GetBytes("password"));
                    foreach (Byte b in hash) {
                        pwd += $"{b:x2}";
                    }
                }
                var op = new Operator() {
                    UserName = "admin",
                    HashedPassword = pwd
                };
                context.Operators.Add(op);
                context.SaveChanges();
            }

            if (!context.Cars.Any()) {
                var car = new CarEntity {
                    RegNumber = "ED-3124",
                    GearUnitType = GearUnitType.Manual,
                    Model = "RAV-4",
                    Vendor = "Toyota",
                    RentPricePerDay = 25,
                    Year = 2001
                };
                context.Cars.Add(car);
                context.SaveChanges();
                car = new CarEntity {
                    RegNumber = "GH-3232",
                    GearUnitType = GearUnitType.Automatic,
                    Model = "RX",
                    Vendor = "Lexus",
                    RentPricePerDay = 35,
                    Year = 2007
                };
                context.Cars.Add(car);
                context.SaveChanges();
                car = new CarEntity {
                    RegNumber = "HL-5544",
                    GearUnitType = GearUnitType.Manual,
                    Model = "XC90",
                    Vendor = "Volvo",
                    RentPricePerDay = 35,
                    Year = 2010
                };
                context.Cars.Add(car);
                context.SaveChanges();
            }

        }
    }
}
