using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Racing.Helper
{
    public class XmlSerializerDeserializer<T> where T : class
    {
        public string SerializeToXml(T data)
        {
            try
            {
                StringBuilder sbData = new StringBuilder();
                XmlSerializer employeeSerializer = new XmlSerializer(typeof(T));
                StringWriter swWriter = new StringWriter(sbData);
                employeeSerializer.Serialize(swWriter, data);
                return sbData.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return string.Empty;
        }

        public T DeserilazeFromXml(string filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    return (T)serializer.Deserialize(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return default(T);
        }
    }
}
