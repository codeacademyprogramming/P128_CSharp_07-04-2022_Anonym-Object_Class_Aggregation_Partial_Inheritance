using System;
using System.Collections.Generic;
using System.Text;

namespace P128AnonymObjectClassIntro
{
    class Human
    {
        public string Name;
        public string SurName;
        public byte Age;
        public Address Address;

        public string Info()
        {
            return $"Adi: {Name}\nSoyAdi: {SurName}\nYasi: {Age}";
        }

        public string FullName()
        {
            return $"Adi: {Name}SoyAdi: {SurName}";
        }

        public string GetAdress()
        {
            return $"{Address.Country} {Address.City} {Address.PostalCode}";
        }
    }
}
