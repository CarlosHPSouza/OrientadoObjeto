namespace Imposto.Entities
{
    class Company : TaxPayer
    {
        public int NumberofEmployees { get; set; }

        public Company()
        {

        }

        public Company(string name, double anualIncome,int numberofEmployees) : base(name, anualIncome)
        {
            NumberofEmployees = numberofEmployees;
        }

        public override double Tax()
        {
            if (NumberofEmployees > 10)
            {
                return AnualIncome * 0.14;
            }
            else
            {
                return AnualIncome * 0.16;
            }
        }
    }
}
