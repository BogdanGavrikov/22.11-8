using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _22._11_практика_задание_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string year1;
            year1 = Interaction.InputBox("Введите текущий год",
                "Ввод года");
            string age;
            age = Interaction.InputBox("Введите ваш возраст",
                "Ввод вашего возраста");
            int x = Convert.ToInt32(year1);
            int y = Convert.ToInt32(age);
            int year2 = x - y;
            string res = year2.ToString();

            MessageBox.Show(res, "ваш возраст");
        }
    }
}
