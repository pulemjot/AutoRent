using System;
using AutoRent.Database;

namespace AutoRent.Models {
    class CarRentViewModel {
        readonly CarRent _rent;

        public CarRentViewModel(CarRent rent) {
            _rent = rent;
            LeaseStarted = rent.LeaseStarted;
            LeaseEnded = rent.LeaseEnded;
        }

        public Int32 ID => _rent.ID;
        public String RegNumber => _rent.Car.RegNumber;
        public String Vendor => _rent.Car.Vendor;
        public String Model => _rent.Car.Model;
        public Int32 Year => _rent.Car.Year;
        public GearUnitType GearUnitType => _rent.Car.GearUnitType;
        public Double RentPricePerDay => _rent.Car.RentPricePerDay;
        public DateTime LeaseStarted { get; set; }
        public DateTime? LeaseEnded { get; set; }

        public override Boolean Equals(Object obj) {
            return !ReferenceEquals(null, obj) &&
                   (ReferenceEquals(this, obj) || obj.GetType() == GetType() && Equals((CarRentViewModel)obj));
        }
        protected Boolean Equals(CarRentViewModel other) {
            return _rent.Equals(other._rent);
        }
        public override Int32 GetHashCode() {
            return _rent.GetHashCode();
        }
    }
}
