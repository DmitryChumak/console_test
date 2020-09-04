using Newtonsoft.Json;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace TestApp
{
     public class FileMethods
    {
        public void Save_Txt(string filePath, string data)
        {
            File.AppendAllText(filePath, data);
        }
        public void Save_Dat(string filePath, string data)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate);
            bf.Serialize(fs, data);
            fs.Close();
        }
        public void Save_Json(string filePath, string data)
        {
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.AppendAllText(filePath, json);
        }
        public void Save_Xml(string filePath, string data)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(string));
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, data);
            }
        }

        public string Open_Txt(string filePath)
        {
            return File.ReadAllText(filePath);
        }

        public string Open_Dat(string filePath)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                return bf.Deserialize(fs) as string;
                
            }
            
        }

        public string Open_Json(string filePath)
        {
            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject(json) as string;
        }

        public string Open_Xml(string filePath)
        {
            XmlSerializer formatter = new XmlSerializer(typeof(string));
            using (FileStream fs = new FileStream(filePath, FileMode.Open))
            {
                return (string)formatter.Deserialize(fs);
            }
        }
    }
}
