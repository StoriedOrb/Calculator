using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double a, b, c;
        string operation = "";

        private void ButtonRavno_Click(object sender, EventArgs e)
        {
            try
            {
                b = Convert.ToDouble(textBox1.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Проверьте, пожалуйста, ввод! Возможно, в одном из полей вы ввели более 1 запятой, одно из полей пустое или знаки арифметических действий расставлены не по правилам!", "ВНИМАТЕЛЬНЕЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
            }
            switch (operation)
            {
                case "+": textBox1.Text = Convert.ToString(a + b); break;
                case "-": textBox1.Text = Convert.ToString(a - b); break;
                case "*": textBox1.Text = Convert.ToString(a * b); break;
                case "/": textBox1.Text = Convert.ToString(a / b); break;
                case "E": textBox1.Text = Convert.ToString(a * Math.Pow(10, b)); break;
                case "x^y": textBox1.Text = Convert.ToString(Math.Pow(a,b)); break;
            }
            textBox3.Text = "";
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            textBox1.Clear();
            else
            textBox3.Text = "";
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                bool i = false;
                try
                {
                    a = Convert.ToDouble(textBox1.Text);
                    i = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Проверьте, пожалуйста, ввод! Возможно, в одном из полей вы ввели более 1 запятой, одно из полей пустое или знаки арифметических действий расставлены не по правилам!", "ВНИМАТЕЛЬНЕЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                }
                if (i == true)
                {
                    Button button = (Button)sender;
                    operation = button.Text;
                }
            }
            else
                MessageBox.Show("У вас пустое поле без чисел. Невозжно применить арифметическое действие, если вы ничего не ввели", "Упс, ошибочка.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch (operation)
            {
                case "-/+": textBox1.Text = Convert.ToString(a * (-1)); break;
                case "Sin": textBox1.Text = Convert.ToString(Math.Sin(a)); break;
                case "Pi": textBox1.Text = Convert.ToString(Math.PI); break;
                case "Tg": textBox1.Text = Convert.ToString(Math.Tan(a)); break;
                case "Cos": textBox1.Text = Convert.ToString(Math.Cos(a)); break;
                case "Lg": if (a > 0) textBox1.Text = Convert.ToString(Math.Log10(a)); else MessageBox.Show("Логарифм из отрицательного числа не существует!", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
                case "Sqrt": if (a > 0) textBox1.Text = Convert.ToString(Math.Sqrt(a)); else MessageBox.Show("Квадратный корень из отрицательного числа не существует!", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information); break; 
                case "Ra": Random rnd = new Random(); double t = rnd.Next(); textBox1.Text = Convert.ToString(t); break;
                case "e": textBox1.Text = Convert.ToString(Math.Pow(2.71828182846,a)); break;
                case "Log": if (a>0) textBox1.Text = Convert.ToString(Math.Log(a)); else MessageBox.Show("Логарифм из отрицательного числа не существует!", "ВНИМАНИЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information); break;
            }
        }

        private void ButtonMinus_Click(object sender, EventArgs e)
        {
            if (!(textBox1.Text == ""))
            {
                bool i = false;
                try
                {
                    a = Convert.ToDouble(textBox1.Text);
                    i = true;
                }
                catch (FormatException)
                {
                    MessageBox.Show("Проверьте, пожалуйста, ввод! Возможно, в одном из полей вы ввели более 1 запятой, одно из полей пустое или знаки арифметических действий расставлены не по правилам!", "ВНИМАТЕЛЬНЕЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox1.Clear();
                }
                if (i == true)
                {
                    Button button = (Button)sender;
                    operation = button.Text;
                    textBox3.Text = Convert.ToString(a) + " " + operation;
                    textBox1.Clear();
                }
            }
            else
                MessageBox.Show("У вас пустое поле без чисел. Невозжно применить арифметическое действие, если вы ничего не ввели", "Упс, ошибочка.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonDot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            switch (operation)
            { 

                case "MS": textBox2.Text = textBox1.Text; break;
                case "MR": textBox1.Text = textBox2.Text; break;
                case "MC": textBox2.Clear(); ; break;
                case "M+": try { textBox2.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)); }
                catch (FormatException)
                {
                MessageBox.Show("Проверьте, пожалуйста, ввод! Возможно, одно из полей пустое или знаки арифметических действий расставлены не по правилам!",
                "ВНИМАТЕЛЬНЕЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                break;
                case "M-": try { textBox2.Text = Convert.ToString(Convert.ToDouble(textBox2.Text) - Convert.ToDouble(textBox1.Text)); }
                catch (FormatException)
                {
                MessageBox.Show("Проверьте, пожалуйста, ввод! Возможно, одно из полей пустое или знаки арифметических действий расставлены не по правилам!",
                "ВНИМАТЕЛЬНЕЕ!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && (number != 8))
                e.Handled = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Tag = "";
            if (textBox1.Text == "0")
                textBox1.Clear();
            Button button = (Button)sender;
            textBox1.Text += button.Text;
        }

        
    }
}
