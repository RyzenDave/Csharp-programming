using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMthingy.Classes
{
    public class ATM
    {
        private List<Customer> _customers;
        private Customer? _currentCustomer;

        public ATM()
        {
            _customers = new List<Customer>
            {
                new Customer("1234123412341234", 4321, "Bob Bobsky", 1000m),
                new Customer("5678567856785678", 1234, "Alice Wonderland", 500m)
            };
        }

        public void Run()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the ATM app");

                if (!HandleAuthentication())
                    continue;

                HandleTransactions();
            }
        }

        // Stub for HandleAuthentication method to fix missing identifier error
        private bool HandleAuthentication()
        {
            // TODO: Implement authentication logic
            return true;
        }

        // Stub for HandleTransactions method to fix missing identifier error
        private void HandleTransactions()
        {
            // TODO: Implement transaction logic
        }

        private string SanitizeCardNumber(string input) =>
            new string(input.Where(c => char.IsDigit(c)).ToArray());
    }
}
