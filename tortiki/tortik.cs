using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practich5;
namespace Practich51
{
    public class tortik
    {
        private Soed form = new Soed();
        private Soed tort = new Soed();
        public static List<Soed> itog = new List<Soed>();

        private int position;

        public static string[] c = new string[tortik.itog.Count];
        public static ConsoleKeyInfo key;
        public static int a;

        private void Strelka()
        {
            key = Console.ReadKey();
            if ((key.Key == ConsoleKey.UpArrow) && (position != 2))
            {
                position--;
            }

            if ((key.Key == ConsoleKey.DownArrow) && (position < 6))
            {
                position++;
            }
            if (position == 2)
            {
                Console.SetCursorPosition(0, 3);
            }
            if (position == 7)
            {
                Console.SetCursorPosition(0, 6);
            }
        }

        public void MainMenu()
        {
            position = 2;

            Console.Clear();
            Console.WriteLine("Нажмите стрелочку вниз, чтобы отобразить меню.");
            key = Console.ReadKey();
            while ((key.Key != ConsoleKey.Enter) && (key.Key != ConsoleKey.Escape))
            {
                Strelka();
                Console.Clear();
                Console.WriteLine("Главное меню для заказа.");
                Console.WriteLine("-------------------------");
                Console.WriteLine("  1. Форма");
                Console.WriteLine("  2. Торт");
                Console.SetCursorPosition(0, position);
                Console.Write("->");


                Console.SetCursorPosition(0, 8);
                for (int i = 0; i < itog.Count; i++)
                {
                    Console.Write(itog[i].podp + " - ");
                    Console.Write(itog[i].Zena + "  ");
                }
            }

            if (key.Key == ConsoleKey.Enter)
            {
                AddMenu();
            }

            if (key.Key == ConsoleKey.Escape)
            {
                a = 0;
                Console.SetCursorPosition(0, 7);
                for (int i = 0; i < itog.Count; i++)
                {
                    a = a + itog[i].Zena;
                }

                for (int i = 0; i < tortik.itog.Count; i++)
                {
                    c.Append(Convert.ToString(tortik.itog[i]));
                }

                itog.Clear();
                Console.Write(a);
                return;
            }
        }

        public void AddMenu()
        {
            Console.Clear();
            Console.WriteLine("Нажмите стрелочку вниз, чтобы отобразить подпункты меню.");

            if (position == 2)
            {
                position = 2;
                while (key.Key != ConsoleKey.A)
                {

                    Strelka();
                    Console.Clear();
                    Console.WriteLine("Подпункты меню: Форма");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("  1. Круг");
                    Console.WriteLine("  2. Квадрат");
                    Console.WriteLine("  3. Сердце");
                    Console.SetCursorPosition(0, position);
                    Console.Write("->");
                }

                if (position == 2)
                {
                    form.podp = "Круг";
                    form.Zena = 40;
                }

                if (position == 3)
                {
                    form.podp = "Квадрат";
                    form.Zena = 20;
                }

                if (position == 4)
                {
                    form.podp = "Сердце";
                    form.Zena = 60;
                }
                itog.Add(form);
                MainMenu();
            }
            if (position == 3)
            {
                position = 2;
                while (key.Key != ConsoleKey.A)
                {

                    Strelka();
                    Console.Clear();
                    Console.WriteLine("Подпункты меню: Вкус");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("  1. Медовик");
                    Console.WriteLine("  2. Морковный");
                    Console.WriteLine("  3. Птичье молоко");
                    Console.WriteLine("  4. Чизкейк");
                    Console.SetCursorPosition(0, position);
                    Console.Write("->");
                }

                if (position == 2)
                {
                    tort.podp = "Медовик";
                    tort.Zena = 30;
                }

                if (position == 3)
                {
                    tort.podp = "Морковный";
                    tort.Zena = 60;
                }

                if (position == 4)
                {
                    tort.podp = "Птичье молоко";
                    tort.Zena = 150;
                }

                if (position == 5)
                {
                    tort.podp = "Чизкейк";
                    tort.Zena = 100;
                }
                itog.Add(tort);
                MainMenu();
            }
        }
    }
}