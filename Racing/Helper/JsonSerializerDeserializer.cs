using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Racing.Helper
{
    public class JsonSerializerDeserializer<T> where T : class
    {
        private readonly DataContractJsonSerializer jsonSerializer;

        public JsonSerializerDeserializer()
        {
            this.jsonSerializer = new DataContractJsonSerializer(typeof(T));
        }

        public string SerializeToJson(T t)
        {
            try
            {
                using (var memoryStream = new MemoryStream())
                {
                    this.jsonSerializer.WriteObject(memoryStream, t);
                    memoryStream.Position = 0;
                    using (var sr = new StreamReader(memoryStream))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return string.Empty;
        }

        public T DeserializeToJson(string objectString)
        {
            try
            {
                using (var ms = new MemoryStream(System.Text.ASCIIEncoding.ASCII.GetBytes((objectString))))
                {
                    return (T)this.jsonSerializer.ReadObject(ms);
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
