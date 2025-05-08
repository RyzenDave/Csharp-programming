using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxiManager.Domain.Enums;

namespace TaxiManager.Domain.Models
{
    public class Driver : BaseEntity
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string PhoneNumber { get; set; }
        public string CarModel { get; set; }
        public string CarNumber { get; set; }
        public Shift Shift { get; set; }
        public Car Car { get; set; }
        public string License { get; set; }
        public DateTime LicenseExpiryDate { get; }

        public DateTime DateTime { get; set; } = DateTime.Now;

    

        public Driver(string name, string surname, string phoneNumber, string carModel, string carNumber, Shift shift,Car car)
        {
            firstName = name;
            lastName = surname;
            PhoneNumber = phoneNumber;
            CarModel = carModel;
            CarNumber = carNumber;
            Shift = shift;
            Car = car; // Initialize with a default value
            License = string.Empty; // Initialize with a default value
            LicenseExpiryDate = DateTime.MinValue; // Initialize with a default value
        }

        public string fullName => $"{firstName} {lastName}";

        public override string Print()
        {
            throw new NotImplementedException();
        }
    }
}
