using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FileIOOperations
{
    class Xml
    {
        public static void Serialization()
        {
            try
            {
                string path = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\XmlData.xml";
                //Object Initialization
                Contact contact = new Contact() { Id = 101, FirstName = "Sarayu", LastName = "K" };
                var result = File.OpenWrite(path);
                XmlSerializer xml = new XmlSerializer(typeof(Contact));
                xml.Serialize(result, contact);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Deserialization()
        {
            try
            {
                string path = @"D:\tvstraining\FileIOOperationsDemo\FileIOOperationsDemo\XmlData.xml";
                var res = File.OpenRead(path);
                XmlSerializer xml = new XmlSerializer(typeof(Contact));
                Contact result = (Contact)xml.Deserialize(res);
                if (result != null)
                {
                    Console.WriteLine("Person Details : ");
                    Console.WriteLine("Id : {0}\tFirstName : {1}\tLastName : {2}", result.Id, result.FirstName, result.LastName);
                }
                else
                    Console.WriteLine("No Person Details");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

    public class Contact
    {
        public int Id { get; set; } 
        public string FirstName { get; set; }
        public string LastName { get; set; } 
    }
}
