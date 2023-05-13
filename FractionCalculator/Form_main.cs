/// Обыкновенные дроби и операции над ними
/// Обработчики событий
/// @author Будаев Г.Б.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using classFraction;

namespace FractionCalculator
{
    public partial class Form_main : Form
    {
        /// Создание ссылок на объекты
        Fraction F1 = new Fraction();
        Fraction F2 = new Fraction();
        Fraction F3 = new Fraction();
        /// Переменная для подсчёта ошибок ввода данных
        int count;

        public Form_main()
        {
            InitializeComponent();
        }


        /// Проверка правильности введённых данных
        private int CheckParams()
        {
            int count = 0; /// Счётчик ошибок
            int temp1; /// Переменная для проверки ввода 
            if (int.TryParse(textBox_num1.Text, out temp1) == false) ///
            {
                textBox_num1.BackColor = Color.LightPink;
                count++;
            }
            else textBox_num1.BackColor = Color.White;


            int temp2;
            if (int.TryParse(textBox_num2.Text, out temp2) == false)
            {
                textBox_num2.BackColor = Color.LightPink;
                count++;
            }
            else textBox_num2.BackColor = Color.White;


            int temp3;
            if (int.TryParse(textBox_denom1.Text, out temp3) == false || Convert.ToInt32(textBox_denom1.Text) <= 0)
            {
                textBox_denom1.BackColor = Color.LightPink;
                count++;
            }
            else textBox_denom1.BackColor = Color.White;


            int temp4;
            if (int.TryParse(textBox_denom1.Text, out temp4) == false || Convert.ToInt32(textBox_denom2.Text) <= 0)
            {
                textBox_denom2.BackColor = Color.LightPink;
                count++;
            }
            else textBox_denom2.BackColor = Color.White;
            return count;
        }

        /// Установить параметры дробей
        private void SetParams()
        {
            F1.SetNumerator(Convert.ToInt32(textBox_num1.Text));
            F1.SetDenominator(Convert.ToInt32(textBox_denom1.Text));
            F2.SetNumerator(Convert.ToInt32(textBox_num2.Text));
            F2.SetDenominator(Convert.ToInt32(textBox_denom2.Text));
        }

        /// Очищение полей результата
        private void EmptyFields()
        {
            textBox_num_res.Text = " ";
            textBox_denom_res.Text = " ";
        }

        /// Поместить результат арифметической операции на форму(* / + -)
        private void SetResult()
        {
            textBox_num_res.Text = Convert.ToString(F3.GetNumerator());
            textBox_denom_res.Text = Convert.ToString(F3.GetDenominator());
        }


        /// Обработчик событий на нажатие кнопки "+"
        private void button_add_Click(object sender, EventArgs e)
        {
            if (CheckParams() == 0) /// Если ошибок ввода нет
            {
                SetParams();
                F3 = F1 + F2;
                SetResult();
                richTextBox_report.Text += F1.ToString() + " + " + F2.ToString() + " = " + F3.ToString() + "\n";
            }
            else /// Если есть хотя бы одна ошибка
            {
                richTextBox_report.Text += "Error: One or more denominators <= 0" + "\n";
                EmptyFields();
            }

        }

        /// Обработчик событий на нажатие кнопки "-"
        private void button_sub_Click(object sender, EventArgs e)
        {
            if (CheckParams() == 0)
            {
                SetParams();
                F3 = F1 - F2;
                SetResult();
                richTextBox_report.Text += F1.ToString() + " - " + F2.ToString() + " = " + F3.ToString() + "\n";
            }
            else
            {
                richTextBox_report.Text += "Error: One or more denominators <= 0" + "\n"; ;
                EmptyFields();
            }
        }

        /// Обработчик событий на нажатие кнопки "*"
        private void button_mult_Click(object sender, EventArgs e)
        {
            if (CheckParams() == 0)
            {
                SetParams();
                F3 = F1 * F2;
                SetResult();
                richTextBox_report.Text += F1.ToString() + " * " + F2.ToString() + " = " + F3.ToString() + "\n";
            }
            else
            {
                richTextBox_report.Text += "Error: One or more denominators <= 0" + "\n";
                EmptyFields();
            }
        }

        /// Обработчик событий на нажатие кнопки "/"
        private void button_div_Click(object sender, EventArgs e)
        {
            if (CheckParams() == 0)
            {
                if (Convert.ToInt32(textBox_num2.Text) != 0)
                {
                    textBox_num2.BackColor = Color.White;

                    SetParams();
                    F3 = F1 / F2;
                    SetResult();
                    richTextBox_report.Text += F1.ToString() + " / " + F2.ToString() + " = " + F3.ToString() + "\n";
                }
                else
                {
                    textBox_num2.BackColor = Color.LightPink;
                    richTextBox_report.Text += "Error: Division by zero" + "\n";
                    EmptyFields();
                }
            }
            else
            {
                richTextBox_report.Text += "Error: One or more denominators <= 0" + "\n";
                EmptyFields();
            }
        }

        /// Обработчик событий на нажатие кнопки сравнить
        private void button_compare_Click(object sender, EventArgs e)
        {
            if (CheckParams() == 0)
            {
                SetParams();
                int c = F1.Compare(F2);
                if (c == 1)
                {
                    richTextBox_report.Text += F1.ToString() + " > " + F2.ToString() + "\n";
                }
                else
                    if (c == -1)
                {
                    richTextBox_report.Text += F1.ToString() + " < " + F2.ToString() + "\n";
                }
                else
                        if (c == 0)
                {
                    richTextBox_report.Text += F1.ToString() + " = " + F2.ToString() + "\n";
                }
            }
            else
            {
                richTextBox_report.Text += "Error: One or more denominators <= 0" + "\n";
                EmptyFields();
            }
        }

        /// Обработчик событий на нажатие кнопки 123.45 (преобразовать в вещественное)
        private void button_convertDouble_Click(object sender, EventArgs e)
        {
            if (CheckParams() == 0)
            {
                if(textBox_num_res.Text != " " && textBox_denom_res.Text != " ")
                {
                    F1.SetNumerator(Convert.ToInt32(textBox_num_res.Text));
                    F1.SetDenominator(Convert.ToInt32(textBox_denom_res.Text));
                    richTextBox_report.Text += F1.ToString() + " = " + Convert.ToString(Math.Round(F1.ConvertToDouble(), 3) + "\n");
                }
                else
                {
                    richTextBox_report.Text += "Error: Result is empty" + "\n";
                    EmptyFields();
                }
            }
            else
            {
                richTextBox_report.Text += "Error: One or more denominators <= 0" + "\n";
                EmptyFields();
            }
        }

        private void обАвтореToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Будаев Г.Б., ВМК-21", "Об авторе");
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" - Программа выполняет арифметические операции над дробями. \n - Введите значения числителей и знаменателей в поля слева и выберите нужную операцию. \n - Результат появится в правых полях, его можно перевести в десятичную форму, нажав на кнопку 123.45", "Инструкция");
        }
    }
}
