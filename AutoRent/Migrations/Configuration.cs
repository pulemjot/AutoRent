using System.Security.Cryptography;
using System.Text;
using AutoRent.Database;

namespace AutoRent.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AutoRent.Database.AppDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AppDbContext context)
        {
            string pwd = null;
            using (var halg = HashAlgorithm.Create("sha256"))
            {
                var hash = halg.ComputeHash(Encoding.Unicode.GetBytes("password"));
                foreach (var b in hash)
                {
                    pwd += $"{b:x2}";
                }
            }
            if (context.Operators.Any()) { return; }

            var op = new Operator()
            {
                UserName = "admin",
                HashedPassword = pwd
            };
            context.Operators.Add(op);
            context.SaveChanges();
        }
    }
}
