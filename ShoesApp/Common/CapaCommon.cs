using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Common
{
    public class CapaCommon
    {
        public void SerializeToXml<T>(T obj, string fileName)

        {

            XmlSerializer ser = new XmlSerializer(typeof(T));

            //Create a FileStream object connected to the target file 

            FileStream fileStream = new FileStream(fileName, FileMode.Create);

            ser.Serialize(fileStream, obj);

            fileStream.Close();

        }

        public T DeserializeFromXml<T>(string xml)
        {
            T result;
            XmlSerializer ser = new XmlSerializer(typeof(T));
            using (TextReader tr = new StringReader(xml))
            {
                result = (T)ser.Deserialize(tr);
            }
            return result;
        }
    }
}
