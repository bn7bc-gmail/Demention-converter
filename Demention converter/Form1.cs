using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demention_converter
{
    public partial class Form1 : Form
    {
        private Converter _conv;
        public Form1()
        {
            InitializeComponent();
            _conv = new Converter();
            _conv.OnConverterStatus += new Converter.ConverterStatusHandler(St);
        }
        /// <summary>
        /// 
        /// </summary>
        
        private void St(object sender, ConverterEventArgs e)
        {
            CResults res = e.Result;
            W1.Text = res.W177.ToString();
            H1.Text = res.H177.ToString();
            D1.Text = res.D177.ToString();
            W2.Text = res.W133.ToString();
            H2.Text = res.W133.ToString();
            D2.Text = res.D133.ToString();

        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Double Dia;
            if (Double.TryParse(textBox1.Text, out Double Dia))
            {
                _conv.Convert(Dia);
            }
            else
            {

            }
        }

       
        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
