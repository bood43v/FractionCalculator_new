/// Обыкновенные дроби и операции над ними
/// Главная программа
/// @author Будаев Г.Б.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using classFraction;

namespace FractionCalculator
{

    internal static class Program_main
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_main());
        }

    }

}

