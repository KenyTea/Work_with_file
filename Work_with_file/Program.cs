using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // <= <==  <===   <====

namespace Work_with_file
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Евгений
            //string path2 = @"C:\Users\y.gertsen\Documents\New Text Document.txt";

            //try
            //{
            //    Console.WriteLine("******считываем весь файл********");
            //    using (StreamReader sr = new StreamReader(path2))
            //    {
            //        Console.WriteLine(sr.ReadToEnd());
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("******считываем построчно********");
            //    using (StreamReader sr = new StreamReader(path2, System.Text.Encoding.Default))
            //    {
            //        string line;
            //        while ((line = sr.ReadLine()) != null)
            //        {
            //            Console.WriteLine(line);
            //        }
            //    }

            //    Console.WriteLine();
            //    Console.WriteLine("******считываем блоками********");
            //    using (StreamReader sr = new StreamReader(path2, System.Text.Encoding.Default))
            //    {
            //        char[] array = new char[4];
            //        // считываем 4 символа
            //        sr.Read(array, 0, 4);

            //        Console.WriteLine(array);
            //    }
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //Console.ReadLine();
            #endregion

            //позволяет работать с файлами -  using System.IO;
            // class Stream - основной класс для работы с файлами
            // class FileStream - для чтение и записи.
            string path = Path.Combine(@"C:\Users\васильева\Documents\Visual Studio 2015\Projects\Work_with_file", "NewFile3.txt"); // 3


            NewFile(); // 1
            NewFile2(); // 2

        }

        static void NewFile() // 1
        {
            FileInfo file = new FileInfo(@"C:\Users\васильева\Documents\Visual Studio 2015\Projects\Work_with_file\NewFile.txt"); // хранит инфу о файле

            FileStream fs = file.Create(); // создание файла
            fs.Close(); // закрыли поток

        }

        static void NewFile2() // 2
        {
            FileInfo file = new FileInfo(@"C:\Users\васильева\Documents\Visual Studio 2015\Projects\Work_with_file\NewFile2.txt");

            using (FileStream fs = file.Open(FileMode.OpenOrCreate, FileAccess.Write)) // using заменяет открытие и зикрытие скобками
            { // открытие потока

                using (StreamWriter sw = new StreamWriter(fs, System.Text.Encoding.Default))
                {
                    sw.Write("Some text");
                }
            } // закрытие потока

            //метод № 2
            StreamWriter stw = new StreamWriter(@"C:\Users\васильева\Documents\Visual Studio 2015\Projects\Work_with_file\NewFile3.txt");
            stw.Write("Hi");

            CotyTo(file); // 4
            stw.Close();

        }

        static void CotyTo(FileInfo fi) // 4
        {
            fi.CopyTo(@"C:\Users\васильева\Documents\Visual Studio 2015\Projects\Work_with_file\NewFile4.txt"); // копирование
        }

    }
}
