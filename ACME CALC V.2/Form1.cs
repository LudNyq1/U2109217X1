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
            switch ((sender as Button).Text)
            {
                case "+":
                    double ansAdd = calc.Add(i, j);
                    AnswerAdd(i, j, (sender as Button).Text, ansAdd);
                    break;
                case "-":
                    double ansSub = calc.Sub(i, j);
                    AnswerAdd(i, j, (sender as Button).Text, ansSub);
                    break;
                case "*":
                    double ansMult = calc.Mult(i, j);
                    AnswerAdd(i, j, (sender as Button).Text, ansMult);
                    break;
                case "/":
                    double ansDiv = calc.Div(i, j);
                    AnswerAdd(i, j, (sender as Button).Text, ansDiv);
                    break;

            }
        }
        public void AnswerAdd(double i, double j, string operation, double answer)
        {
            listAns.Items.Add($"{i } {operation} {j} = {answer}");
        }

        /*private void AddBtn_Click(object sender, EventArgs e)
        {

            double i = double.Parse(txt1.Text);
            double j = double.Parse(txt2.Text);
            double answer = calc.Add(i, j);

            AnswerAdd(i, j,(sender as Button).Text, answer);
        }

        private void SubBtn_Click(object sender, EventArgs e)
        {
            double i = double.Parse(txt1.Text);
            double j = double.Parse(txt2.Text);
            double answer = calc.Sub(i, j);

            AnswerAdd(i, j, (sender as Button).Text, answer);
        }

        private void MultBtn_Click(object sender, EventArgs e)
        {
            double i = double.Parse(txt1.Text);
            double j = double.Parse(txt2.Text);
            double answer = calc.Mult(i, j);

            AnswerAdd(i, j, (sender as Button).Text, answer);
        }

        private void DivBtn_Click(object sender, EventArgs e)
        {
            double i = double.Parse(txt1.Text);
            double j = double.Parse(txt2.Text);
            double answer = calc.Div(i, j);

            AnswerAdd(i, j, (sender as Button).Text, answer);
        }*/


    }
}
