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

        }

    }
}
