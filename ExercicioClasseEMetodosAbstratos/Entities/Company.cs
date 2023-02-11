using System.Globalization;

namespace ExercicioClasseEMetodosAbstratos.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployee { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployee)
            : base(name, anualIncome)
        {
            NumberOfEmployee = numberOfEmployee;
        }
        public sealed override double Tax()
        {
            double tax = 0.00;
            if (NumberOfEmployee > 10)
            {
                tax = AnualIncome * 0.14;
            }
            else
            {
                tax = AnualIncome * 0.16;
            }
            return tax;
        }
        public override string ToString()
        {
            return $"{Name}, $ {Tax().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
