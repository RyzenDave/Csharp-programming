using CompanyLib;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Company
{
    
internal class Program
    {
        static void Main(string[] args)
        {
            CEO ceoName = new CEO("John", "Helldiver", 100000);
            ceoName.PrintInfo();
            ceoName.PrintEmployees();
        }
    }
}
