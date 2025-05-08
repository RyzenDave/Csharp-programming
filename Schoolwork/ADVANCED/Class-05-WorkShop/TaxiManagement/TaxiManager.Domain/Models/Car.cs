using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiManager.Domain.Models
{
    public class Car(string model, string licensePlate, DateTime licensePlateExpiryDate, List<Driver> driversAssigned) : BaseEntity
    {
        public string Model { get; set; } = model;
        public string LicensePlate { get; set; } = licensePlate;
        public DateTime LicensePlateExpiryDate { get; set; } = licensePlateExpiryDate;
        public List<Driver> DriversAssigned { get; set; } = new List<Driver>();

        public override string Print()
        {
            int assignedPercent = DriversAssigned.Count == 0 ? 0 : 100 / 3 * DriversAssigned.Count + 1;
            return $"Id: {Id}, Model: {Model}, License Plate: {LicensePlate}, License Plate Expiry Date: {LicensePlateExpiryDate}, Assigned Drivers: {assignedPercent}%";
        }
        public bool IsLicensePlateExpired()
        {
            if (DateTime.Now > LicensePlateExpiryDate)
            {
                return true; // ExpiryStatus.Expired
            }
            else
            {
                return false; // ExpiryStatus.Valid
            }
        }

    }
}
