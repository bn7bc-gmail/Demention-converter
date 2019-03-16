using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Demention_converter
{
    /// <summary>
    /// 
    /// </summary>
    class Converter
    {
        public delegate void ConverterStatusHandler(object sender, ConverterEventArgs e);
        public event ConverterStatusHandler OnConverterStatus;
        private CResults R;

        public Converter()
        {
            R = new CResults();
            


        }
        public void Convert (Double Diagonal)
        {
            R.D177 = Diagonal;
            R.W177 = Math.Sqrt(Math.Pow(Diagonal, 2)/(Math.Pow((16/9.000000000000000),2)+1))*(16/9.00000000000000000000);
            R.H177 = Math.Sqrt(Math.Pow(Diagonal, 2) / (Math.Pow((16 / 9.000000000000000), 2) + 1));
            R.H133 = R.H177;
            R.W133 = R.H133 * 4 /3;
            R.D133 = Math.Sqrt(Math.Pow(R.H133, 2) + Math.Pow(R.W133, 2));

            SendResults();
        }
       
        private void SendResults()
        {
            if (OnConverterStatus == null) return;
            ConverterEventArgs args = new ConverterEventArgs("Done",R);
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
        
        public ConverterEventArgs(string message,  CResults res)
        {
            Message = message;
              Result = res;

        }
    }
}
