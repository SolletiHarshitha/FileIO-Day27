using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperationsDemo
{
    class Json
    {
        public static void Serialization()
        {
            try
            {
                string path = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\JsonData.json";
                Contact contact = new Contact() { Id = 101, FirstName = "Kavitha", LastName = "P" };
                string res = JsonConvert.SerializeObject(contact);
                File.WriteAllText(path,res);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Deserialization()
        {
            try
            {
                string path = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\JsonData.json";
                string res=File.ReadAllText(path);
                Contact result = JsonConvert.DeserializeObject<Contact>(res);
                if (result != null)
                {
                    Console.WriteLine("Person Details : ");
                    Console.WriteLine("Id : {0}\tFirstName : {1}\tLastName : {2}", result.Id, result.FirstName,result.LastName);
                }
                else
                    Console.WriteLine("No Person Details");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public class Contact
        {
            public int Id { get; set; } 
            public string FirstName { get; set; } 
            public string LastName { get; set; } 
        }
    }
}
