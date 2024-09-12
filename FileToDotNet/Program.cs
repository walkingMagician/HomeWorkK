using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;


namespace FileToDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string filePath = "C:\\Users\\Юрий\\source\\repos\\HomeWork\\FileToDotNet\\201 RAW.txt";
            try
            {
                List<string> list = new List<string>(); // Список для хранения строк

                string line;
                string[] parts;
                string result;
                using (StreamReader sr = new StreamReader(filePath))
                {

                    while ((line = sr.ReadLine()) != null) // Читаем строки построчно
                    {
                        parts = line.Split(' ', '\t'); // Метод Split возвращает массив строк
                        if (parts.Length == 2)
                        {
                            string firstPart = parts[0]; // Первая часть 
                            string secondPart = parts[1]; // Вторая часть

                            parts[0] = secondPart; // Меняются местави значения
                            parts[1] = firstPart;


                            // Выводим результат
                            //Console.WriteLine("Первая часть: " + parts[0]);
                            //Console.WriteLine("Вторая часть: " + parts[1]);

                        }
                        else
                        {
                            Console.WriteLine("Строка не была разделена на две части");
                        }
                        result = string.Join(" ", parts);
                        sr.Close();
                        //Console.WriteLine(result);
                        System.IO.File.WriteAllText(filePath, result);
                    }

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            System.Diagnostics.Process.Start("notepad", filePath);




        }
    }
}

/*
192.168.100.21	00-19-99-b4-c2-ae
192.168.100.22	00-19-99-ae-a8-8e
192.168.100.23	00-19-99-b5-e9-9b
192.168.100.24	00-19-99-b4-a2-ed
192.168.100.25	00-19-99-ad-4f-51
192.168.100.26	00-19-99-dc-52-80
192.168.100.27	00-19-99-b4-a2-fb
192.168.100.28	00-19-99-b2-b3-e6
192.168.100.29	00-19-99-ae-a5-59
192.168.100.30	00-19-99-dc-52-77
192.168.100.31	00-19-99-ac-b8-11
192.168.100.32	00-19-99-b5-e9-4d
 */
