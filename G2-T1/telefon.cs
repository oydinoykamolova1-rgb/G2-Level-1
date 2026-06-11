namespace G2_T1
{
     class telefon
    {
        private string _model;
        private double _narxi;
        private int _yonks;

        public telefon(string model, double narxi, int yonks)
        {
           this._model = model;
            this._narxi = narxi;
            this._yonks = yonks;
        }

        public string Model
        {
            get { return _model; }
            set
            {
                if (string.IsNullOrWhiteSpace(_model))
                {
                    Console.WriteLine("xato: telfon modelni kirgiz tentak");
                    return
                }

            }
        }

        public double Narx
        {
            get { return _narxi; }
            set
            {
                if(value < 0)
                {
                    Console.WriteLine("Xato: narxi qani)
                }
            }
        }
    }
   
}
