using System;

namespace Demention_converter
    {
    /// <summary>
    ///
    /// </summary>
    internal class Converter
        {
        public delegate void ConverterStatusHandler(object sender, ConverterEventArgs e);

        public event ConverterStatusHandler OnConverterStatus;

        private CResults R;

        public Converter()
            {
            R = new CResults();
            }

        public void Convert(Double Diagonal)
            {
            R.D177 = Diagonal;
            R.W177 = Math.Sqrt(Math.Pow(Diagonal, 2) / (Math.Pow((16 / 9.000000000000000), 2) + 1)) * (16 / 9.00000000000000000000);
            R.H177 = Math.Sqrt(Math.Pow(Diagonal, 2) / (Math.Pow((16 / 9.000000000000000), 2) + 1));
            R.H133 = R.H177;
            R.W133 = R.H133 * 4 / 3;
            R.D133 = Math.Sqrt(Math.Pow(R.H133, 2) + Math.Pow(R.W133, 2));

            SendResults();
            }
        public void Convert (Double Diagonal, String SourceAspect)
            {
            switch (SourceAspect)
                {
                case "4/3":
                    R.D133 = Diagonal;
                    R.H133 = Math.Sqrt(Math.Pow(Diagonal, 2) / (Math.Pow((4 / 3.000000000000000), 2) + 1)) * (4 / 3.00000000000000000000);
                    R.W133 = Math.Sqrt(Math.Pow(Diagonal, 2) / (Math.Pow((4 / 3.000000000000000), 2) + 1));
                    R.W177 = R.W133;
                    R.H177 = R.W133 * 3 / 4;
                    R.D177 = Math.Sqrt(Math.Pow(R.H177, 2) + Math.Pow(R.W177, 2));
                    break;
                case "16/9":
                    R.D177 = Diagonal;
                    R.W177 = Math.Sqrt(Math.Pow(Diagonal, 2) / (Math.Pow((16 / 9.000000000000000), 2) + 1)) * (16 / 9.00000000000000000000);
                    R.H177 = Math.Sqrt(Math.Pow(Diagonal, 2) / (Math.Pow((16 / 9.000000000000000), 2) + 1));
                    R.H133 = R.H177;
                    R.W133 = R.H133 * 4 / 3;
                    R.D133 = Math.Sqrt(Math.Pow(R.H133, 2) + Math.Pow(R.W133, 2));
                    break;
                }
            SendResults();
            }
        private void SendResults()
            {
            if (OnConverterStatus == null) return;
            ConverterEventArgs args = new ConverterEventArgs("Done", R);
            OnConverterStatus(this, args);
            }
        }

    /// <summary>
    /// Costum class foer evens from converter
    /// </summary>
    public class ConverterEventArgs : EventArgs
        {
        //private readonly Results Result;
        public CResults Result;

        public string Message { get; private set; }

        public ConverterEventArgs(string message, CResults res)
            {
            Message = message;
            Result = res;
            }
        }
    }