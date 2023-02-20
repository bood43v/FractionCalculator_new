/// Обыкновенные дроби и операции над ними test
/// Реализания методов класса
/// @author Будаев Г.Б.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classFraction
{
    public class Fraction
    {
        private int num; /// Числитель
        private int denom; /// Знаменатель

        /// Конструктор без параметров
        public Fraction()
        {
            num = 1;
            denom = 1;
        }

        /// Конструктор с параметрами
        public Fraction(int num_, int denom_)
        {
            SetNumerator(num_);
            SetDenominator(denom_);
        }

        /// Деструктор
        ~Fraction() { }


        /// Задать числитель
        public void SetNumerator(int num_)
        {
            num = num_;
        }

        /// Задать знаменатель
        public void SetDenominator(int denom_)
        {
            if (denom_ > 0)
            {
                denom = denom_;
            }
            else throw new ArgumentException("Denominator <= 0");
        }

        /// Вернуть числитель
        public int GetNumerator()
        {
            return num;
        }

        /// Вернуть знаменатель
        public int GetDenominator()
        {
            return denom;
        }

        /// Изменение параметров дроби
        public void ChangeParams(int num_, int denom_)
        {
            SetNumerator(num_);
            SetDenominator(denom_);
        }

        /// Перевод в строку
        public override string ToString()
        {
            this.Shorten();
            return Convert.ToString(num) + "/" + Convert.ToString(denom);
        }

        /// Унарный плюс
        /// Вспомогательный метод для разности дробей
        public static Fraction operator +(Fraction a)
        {
            return a;
        }

        /// Унарный минус
        /// Вспомогательный метод для разности дробей
        public static Fraction operator -(Fraction a)
        {
            return new Fraction(-a.num, a.denom);
        }

        /// Сумма дробей через перегрузку арифметического оператора
        public static Fraction operator +(Fraction a, Fraction b) {
            Fraction c = new Fraction(a.num * b.denom + b.num * a.denom, a.denom * b.denom);
            return c.Shorten();
        }

        /// Разность дробей через перегрузку арифметического оператора
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction c = a + (-b);
            return c.Shorten();
        }

        /// Произведение дробей через перегрузку арифметического оператора
        public static Fraction operator *(Fraction a, Fraction b)
        {
            Fraction c = new Fraction(a.num * b.num, a.denom * b.denom);
            return c.Shorten();
        }

        /// Частное дробей через перегрузку арифметического оператора
        public static Fraction operator /(Fraction a, Fraction b)
        {
            if (b.num == 0)/// Исключение, если знаменатель новой дроби равен нулю (a.denom изначально не может быть равным нулю)
            {
                throw new DivideByZeroException("Denominator = 0");
            }
            Fraction c = new Fraction(a.num * b.denom, a.denom * b.num);
            return c.Shorten();
        }

        /// Наибольший общий делитель для функции сокращения
        private static int GreaterCommonDivisor(int a, int b)
        {
            int t;
            if (a < b)
            {
                t = a;
                a = b;
                b = t;
            }
            while (b != 0)
            {
                t = b;
                b = a % b;
                a = t;
            }
            return Math.Abs(a);
            //a = Math.Abs(a);
            //b = Math.Abs(b);
            //while ((a != 0) && (b != 0))
            //{
            //    if (a > b)
            //    {
            //        a -= b;
            //    }
            //    else
            //    {
            //        b -= a;
            //    }
            //}
            //if (a != 0)
            //{
            //    return a;
            //}
            //else
            //{
            //    return b;
            //}
        }

        /// Сокращение дроби
        public Fraction Shorten()
        {
            int divisor = GreaterCommonDivisor(num, denom);
            num /= divisor;
            denom /= divisor;
            return this;
        }

        /// Перевод в десятичную дробь
        public double ConvertToDouble()
        {
            return (Convert.ToDouble(num) / denom);
        }

        /// Сравнение дробей: 1 - первая больше, -1 - вторая больше, 0 - равны
        public int Compare(Fraction a)
        {
            Fraction b;
            b = this - a; /// Вычитание дробей
            if (b.num > 0) /// Если числитель результата больше нуля, то первая дробь больше второй
            {
                return 1;
            }
            else
            {
                if (b.num < 0) /// Если числитель  результата меньше нуля, то первая дробь меньше второй
                {
                    return -1;
                }
                else return 0; /// Иначе дроби равны
            }
        }
    }
}
