using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using System.Text.RegularExpressions;


namespace FileToDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string FilePath = "C:\\Users\\Егорка\\Source\\Repos\\HomeWorkK\\FileToDotNet\\201 RAW.txt";
            //FileWrite(FilePath);
            FileHostWrite(FilePath);

        }

        static public void FileWrite(string filePath)
        {
            // столбецы 1 и 2
            int columIndex_1 = 0; 
            int columIndex_2 = 1;

            try
            {
                string[] lines = File.ReadAllLines(filePath); // чтение всех строк файла

                for (int i = 0; i < lines.Length; i++)
                {
                    // разделение строки на столбцы файла (разделение происходит при помощи пробела или табуляии)
                    string[] colum = lines[i].Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    if (colum.Length > Math.Max(columIndex_1, columIndex_2)) // чтоб не выйти за пределы массива
                    {
                        string temp = colum[columIndex_1]; // временная переменая 
                        colum[columIndex_1] = colum[columIndex_2];
                        colum[columIndex_2] = temp;

                        lines[i] = string.Join(" ", colum); // собираем обратно всё в строку
                    }
                }
                File.WriteAllLines(filePath, lines); // записываем обратно в файл
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            System.Diagnostics.Process.Start("notepad", filePath);
        }

        static public void FileHostWrite(string filePatch)
        {
            string fileCopy = "201.dhcpd.txt";

                System.Diagnostics.Process.Start("notepad", fileCopy);
        }

    }
}

/*
192.168.100.21 00-19-99-b4-c2-ae
192.168.100.22 00-19-99-ae-a8-8e
192.168.100.23 00-19-99-b5-e9-9b
192.168.100.24 00-19-99-b4-a2-ed
192.168.100.25 00-19-99-ad-4f-51

192.168.100.26 00-19-99-dc-52-80
192.168.100.27 00-19-99-b4-a2-fb
192.168.100.28 00-19-99-b2-b3-e6

192.168.100.29 00-19-99-ae-a5-59
192.168.100.30 00-19-99-dc-52-77
192.168.100.31 00-19-99-ac-b8-11
192.168.100.32 00-19-99-b5-e9-4d
 */
