using System;
using Imposto.Entities;

namespace Imposto.Entities
{
    abstract class TaxPayer
    {
        public string Name { get; set; }
        public Double AnualIncome { get; set; }

        public TaxPayer()
        {

        }

        protected TaxPayer(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}

