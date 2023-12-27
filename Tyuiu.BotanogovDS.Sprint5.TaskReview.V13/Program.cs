using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Tyuiu.BotanogovDS.Sprint5.TaskReview.V13.Lib;

namespace Tyuiu.BotanogovDS.Sprint5.TaskReview.V13
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Ботаногов Д. С. | ИСТНб-23-1 ";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: TaskReview                                                        *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #13                                                             *");
            Console.WriteLine("* Выполнил: Ботаногов Дмитрий Сергеевич | ИСТНб-23-1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:|DataSprint5|InPutDataFileTask7V13.txt в котором есть набор  *");
            Console.WriteLine("* символьных данных. Удалить все строчные латинские буквыиз файла.        *");
            Console.WriteLine("* Полчученный результат сохранить в файл OutPutDataFileTask7V13.txt.      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"D:\source\repos\Tyuiu.BotanogovDS.Sprint5.Review\Tyuiu.BotanogovDS.Sprint5.TaskReview.V13\bin\Debug\InPutDataFileTask7V13.txt";
            Console.WriteLine("Данные находятся в файле: " + path);
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask7.V13.txt";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬАТ:                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Находится в файле: ");
            pathSaveFile = ds.LoadDataAndSave(path);
            Console.WriteLine(pathSaveFile);
            Console.ReadLine();
        }
    }
}
