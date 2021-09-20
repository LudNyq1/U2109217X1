using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACME_CALC_V._2
{
    public partial class Form1 : Form
    {
        CalcEngine calc = new CalcEngine();
        public Form1()
        {
            InitializeComponent();

            AddBtn.Click += new EventHandler(Calculate);
            SubBtn.Click += new EventHandler(Calculate);
            DivBtn.Click += new EventHandler(Calculate);
            MultBtn.Click += new EventHandler(Calculate);
        }

        private void Calculate(object sender, EventArgs e)
        {
            
            double i = double.Parse(txt1.Text);
            double j = double.Parse(txt2.Text);
            double answer = 0;
            switch ((sender as Button).Text)
            {
                case "+":
                    answer = calc.Add(i, j);
                    
                    break;
                case "-":
                    answer = calc.Sub(i, j);
                    break;
                case "*":
                    answer = calc.Mult(i, j);
                    break;
                case "/":
                    answer = calc.Div(i, j);
                    break;
            }

            AnswerAdd(i, j, (sender as Button).Text, answer);

        }
        public void AnswerAdd(double i, double j, string operation, double answer)
        {
            listAns.Items.Add($"{i } {operation} {j} = {answer}");
        }

    }
}
