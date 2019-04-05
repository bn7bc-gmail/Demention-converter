using System;
using System.Windows.Forms;

namespace Demention_converter
    {
    public partial class Form1 : Form
        {
        private readonly Converter _conv;
        private String Dd = "16/9";
        private String Dm = "16/9";
        

        public Form1()
            {
            InitializeComponent();
            _conv = new Converter();
            _conv.OnConverterStatus += new Converter.ConverterStatusHandler(St);
            dd177.Checked = true;
            }

        /// <summary>
        ///
        /// </summary>
        private String Present (double inn)
            {
            return Math.Round(inn,2).ToString();
            }
        private void St(object sender, ConverterEventArgs e)
            {
            CResults res = e.Result;
            W1.Text = Present(res.W177);
            H1.Text = Present(res.H177);
            D1.Text = Present(res.D177);
            W2.Text = Present(res.W133);
            H2.Text = Present(res.H133);
            D2.Text = Present(res.D133);
            
            }

        private void Panel1_Paint(object sender, PaintEventArgs e)
            {
            }

        private void Button1_Click(object sender, EventArgs e)
            {
            
            //Double Dia;
            if (Double.TryParse(textBox1.Text, out Double Dia))
                {
                _conv.Convert(Dia,Dd);
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

        private void Rbtn_Checkchange(object sender, EventArgs e)
            { 
            var b = sender as RadioButton;
            switch (b.Name.ToString())
                {
                case "d177": Dd = "16/9"; break;
                case "d133": Dd = "4/3"; break;
                case "m177": Dm = "16/9";break;
                case "m133": Dm = "4/3";break;

                default:
                    break;
                }        
            }
        }
    }