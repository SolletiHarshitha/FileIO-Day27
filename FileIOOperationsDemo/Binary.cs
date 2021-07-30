using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperationsDemo
{
    class Binary
    {
        
        public static void Serialization()
        {
            string exportPath = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\Binary.txt";
            Person obj = new Person();
            FileStream stream = File.OpenWrite(exportPath);
            BinaryFormatter binary = new BinaryFormatter();
            //Converting object into stream of bytes
            binary.Serialize(stream, obj);
        }

        public static void Deserialization()
        {
            try
            {
                string importPath = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\Binary.txt";
                FileStream stream = File.OpenRead(importPath);
                BinaryFormatter binary = new BinaryFormatter();
                //Casting from stream of bytes into object
                Person result = (Person)binary.Deserialize(stream);
                if (result != null)
                {
                    Console.WriteLine("Person Details : ");
                    Console.WriteLine("Id : {0}\tName : {1}", result.Id, result.Name);
                }
                else
                    Console.WriteLine("No Person Details");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    [Serializable]
    public class Person
    {
        public int Id { get; set; } = 101;
        public string Name { get; set; } = "Saranya";
    }
}
