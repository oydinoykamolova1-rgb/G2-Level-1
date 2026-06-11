namespace N14_HT3
{
    public class BankHisobi
    {
        string EgaIsmi;
        string HisobRaqam;
        double Balans;


        public BankHisobi(string EgaIsmi, string HisobRaqam, double Balans)
        {
            this.EgaIsmi = EgaIsmi;
            this.HisobRaqam = HisobRaqam;
            this.Balans = Balans;
        }

        public BankHisobi(string EgaIsmi, string HisobRaqam)
        {
            this.EgaIsmi = EgaIsmi;
            this.HisobRaqam = HisobRaqam;
        }

        public void MalumotChiqar()
        {
            Console.WriteLine($"EgaIsmi:{EgaIsmi}\nHisobRaqam:{HisobRaqam}\nBalans:{Balans}");
        }
    }

}





