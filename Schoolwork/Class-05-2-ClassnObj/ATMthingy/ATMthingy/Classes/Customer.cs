using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMthingy.Classes
{
    public class Customer
    {
        private string _cardNumber;
        private int _pin;
        private decimal _balance;

        public string FullName { get; }

        public Customer(string cardNumber, int pin, string fullName, decimal initialBalance)
        {
            _cardNumber = cardNumber;
            _pin = pin;
            FullName = fullName;
            _balance = initialBalance;
        }

        public bool CheckPin(int inputPin) => _pin == inputPin;
        public decimal GetBalance() => _balance;

        public bool Withdraw(decimal amount)
        {
            if (_balance >= amount)
            {
                _balance -= amount;
                return true;
            }
            return false;
        }

        public void Deposit(decimal amount) => _balance += amount;

        public string GetCardNumber() => _cardNumber;
    }
}
