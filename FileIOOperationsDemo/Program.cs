using System;
using System.IO;

namespace FileIOOperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\SampleData.txt";
            //FileExists(filePath);
            //ReadLineByLine(filePath);
            ReadDataAtOnce(filePath);
        }
        /// <summary>
        /// Checking File Exists or Not
        /// </summary>
        /// <param name="filePath"></param>
        public static bool FileExists(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Console.WriteLine("File exists");
                    return true;
                }
                else
                {
                    Console.WriteLine("File does not exists");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        /// <summary>
        /// Read Line By Line
        /// </summary>
        /// <param name="filePath"></param>
        public static void ReadLineByLine(string filePath)
        {
            try
            {
                if (FileExists(filePath))
                {
                    string[] lines = File.ReadAllLines(filePath);
                    foreach(string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void ReadDataAtOnce(string filePath)
        {
            try
            {
                if (FileExists(filePath))
                {
                    string line = File.ReadAllText(filePath);
                    Console.WriteLine(line);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
