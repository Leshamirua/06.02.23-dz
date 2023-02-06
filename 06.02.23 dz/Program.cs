using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace _06._02._23_dz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region task 1
            {
                string str = "удали какой-то символ\n";
                Console.WriteLine(str);
                Console.WriteLine("Шо удаляем? ");
                int index = Convert.ToInt32(Console.ReadLine());
                str = str.Remove(index, 1);
                Console.WriteLine("Ну получилось шо-то от так: ");
                Console.WriteLine(str);
            }
            #endregion
            #region task 2
            {
                Console.WriteLine("Ну шо, Лёлик, теперь символ вводите вы, я вам не мама, щоб воодить за вас! Давай сюда(и без единиц): ");
                string str = Console.ReadLine();

                if (str.IndexOf("1") > 0)
                {
                    str = str.Remove(str.IndexOf("1"), 1);
                }
                else
                {
                    Console.WriteLine("Таки не надо ничего удалять");
                }
                Console.WriteLine(str);
                Console.WriteLine();
            }
            #endregion
            #region task 3
            {
                string str = "Вот такая вот строка, меняй куда хочешь.";
                Console.WriteLine(str);
                Console.WriteLine("Де вставляем?");
                int de = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Шо вставляем");
                string sho = Console.ReadLine();
                Console.WriteLine(str.Insert(de, sho));
            }
            #endregion
            #region task 4
            {
                Console.WriteLine("Вводим строку, шо стоим?");
                string str = Console.ReadLine();
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[str.Length - i - 1])
                    {
                        Console.Write("Не, эт не полиндром или как его называют там...");

                    }
                    else
                    {
                        Console.WriteLine("Таки да, полиндром или как его называют там...");
                        return;
                    }
                }
                Console.WriteLine();
            }
            #endregion
            #region task 5
            {
                Console.WriteLine("Предложение пожалуста: ");
                string str = Console.ReadLine();
                string[] arrayOfString = str.Split(new Char[] { ' ' });
                Console.WriteLine($"Количество слов: {arrayOfString.Length}");
            }
            #endregion
            #region task 6
            {
                Console.WriteLine("Введи текст по брацки");
                string str = Console.ReadLine();
                Console.WriteLine("Введи шо тебе надо заменить");
                string strfind = Console.ReadLine();
                Console.WriteLine("И введи на шо хош поменять");
                string strneed = Console.ReadLine();
                str = str.Replace(strfind, strneed);
                Console.WriteLine("Вышла такая вот строка: ");
                Console.WriteLine(str);
            }
            #endregion
            #region task 7
            {
                Console.WriteLine("Предложение пожалуста, я его вам переверну, шо мама родная не узнает: ");
                string str = Console.ReadLine();
                string[] arrayOfString = str.Split(new Char[] { ' ' });
                for (int i = 0; i < arrayOfString.Length - 1; i += 2)
                {
                    string buff = arrayOfString[i];
                    arrayOfString[i] = arrayOfString[i + 1];
                    arrayOfString[i + 1] = buff;
                }
                foreach (string a in arrayOfString)
                {
                    Console.Write($"{a} ");
                }
            }
            #endregion
            #region task 8
            {
                Console.WriteLine("Введи шо-то, узнаем сколько слов с класными в конце: ");
                string str = Console.ReadLine();
                string[] arrayOfString = str.Split(new Char[] { ' ' });
                int count = 0;
                for (int i = 0; i < arrayOfString.Length; i++)
                {
                    if (arrayOfString[i].EndsWith("у") || arrayOfString[i].EndsWith("е") || arrayOfString[i].EndsWith("ы") || arrayOfString[i].EndsWith("а") || arrayOfString[i].EndsWith("о") || arrayOfString[i].EndsWith ("э") || arrayOfString[i].EndsWith ("и"))
                    {
                        count++;
                    }
                }
                Console.WriteLine($"Слов которые заканчиваются на гласную: {count}");
            }
            #endregion
        }
    }
}
