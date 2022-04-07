using System;
using System.Collections.Generic;
using System.Text;

namespace P128AnonymObjectClassIntro
{
    class Company
    {
        public string Name;
        public Address Address;

        public string GetAdress()
        {
            return $"{Address.Country} {Address.City} {Address.PostalCode}";
        }
    }
}
