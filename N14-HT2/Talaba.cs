namespace N14_HT2
{
    public class Talaba
    {
        string Ism;
        int Yosh;
        double Bahosi;


        public Talaba(string Ism, int Yosh, double Bahosi)
        {
            this.Ism = Ism;
            this.Yosh = Yosh;
            this.Bahosi = Bahosi;
        }

        public Talaba(string ism, int yosh)
        {
            this.Ism = ism;
            this.Yosh = yosh;
            this.Bahosi = 0;
        }

        public void MalumotChiqar()
        {
            Console.WriteLine($"Ismi:{Ism}\n Yosh:{Yosh}\n Bahosi:{Bahosi}");
        }

    }
}
