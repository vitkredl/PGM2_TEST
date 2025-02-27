using PGM2_TEST.Pages;

namespace PGM2_TEST.Models
{
    public class Koule_2
    {
        private int polomer;
        public int Polomer
        {
            get => polomer;
            set
            {
                if (value > 0 && value < 100)
                {
                    polomer = value;
                }
            }
        }

        public double Povrch => 4 * Math.PI * Math.Pow(Polomer, 2);

        public double Objem => 4 / 3 * Math.PI * Math.Pow(Polomer, 3);

    }
}
