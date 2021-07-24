using System;
using System.IO;

namespace FileIOOperationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\SampleData.txt";
            FileExists(filePath);
        }
        public static void FileExists(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    Console.WriteLine("File exists");
                }
                else
                {
                    Console.WriteLine("File does not exists");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
