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
            //ReadDataAtOnce(filePath);
            //CopyFileFromSouceToDestination(filePath);
            //DeleteFile();
            //ReadDataFromStream(filePath);
            //WriteDataInToStream(filePath);
            //Binary.Serialization();
            //Binary.Deserialization();
            //Json.Serialization();
            Json.Deserialization();
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

        /// <summary>
        /// Read Data At Once
        /// </summary>
        /// <param name="filePath"></param>
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

        /// <summary>
        /// Copy the contents from source file to destination file
        /// </summary>
        /// <param name="sourceFile"></param>
        public static void CopyFileFromSouceToDestination(string sourceFile)
        {
            string destinationFile= @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\NewSampleData.txt";
            try
            {
                if (FileExists(sourceFile))
                {
                    File.Copy(sourceFile,destinationFile);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Delete an existing file
        /// </summary>
        public static void DeleteFile()
        {
            string destinationFile = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\NewSampleData.txt";
            try
            {
                if (FileExists(destinationFile))
                {
                    File.Delete(destinationFile);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Reading data from Stream Reader
        /// </summary>
        /// <param name="filePath"></param>
        public static void ReadDataFromStream(string filePath)
        {
            try
            {
                if (FileExists(filePath))
                {
                    string line = " ";
                    using (StreamReader sr = File.OpenText(filePath))
                    {
                        while((line=sr.ReadLine())!=null)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /// <summary>
        /// Writing Data using Stream Writer
        /// </summary>
        /// <param name="filePath"></param>
        public static void WriteDataInToStream(string filePath)
        {
            try
            { 
                using (StreamWriter sw = File.AppendText(filePath))
                {
                    sw.WriteLine("\nHello world - .Net is awesome");
                    sw.Close();
                }
                ReadDataFromStream(filePath);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
