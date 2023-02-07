using Practich51;
using Practich5;
using System.Threading.Tasks;
using System.Drawing;
using System.Globalization;
using System.Data;

tortik.key = Console.ReadKey();

while (tortik.key.Key != ConsoleKey.Enter)
{
    tortik zakas = new tortik();
    zakas.MainMenu();
    Console.Clear();
    DateTime date = new DateTime();
    date = DateTime.Now;
    string a = Convert.ToString(tortik.a);
    File.AppendAllText("C:\\Users\\Grigoriy\\tort\\Заказ.txt", date.ToString());
    File.AppendAllText("C:\\Users\\Grigoriy\\tort\\Заказ.txt", a);
    File.AppendAllText("C:\\Users\\Grigoriy\\tort\\Заказ.txt", Convert.ToString(tortik.c));
    Console.WriteLine("Сумма заказа " + tortik.a);
    Console.WriteLine("Чтобы выйти из программы нажмите Enter, если хотите сделать новый заказ, нажмите любую клавишу.");
    Array.Clear(tortik.c);
    tortik.key = Console.ReadKey();
}
