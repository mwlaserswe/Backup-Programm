using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MWTools
{
    static class Tools
    {

        public static void SerializeToXmlFile(object obj, string filename, Encoding encoding)
        {
            // XmlSerializer für den Typ des Objekts erzeugen
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            // Objekt über ein StreamWriter-Objekt serialisieren
            using (StreamWriter streamWriter = new StreamWriter(filename, false, encoding))
            {
                serializer.Serialize(streamWriter, obj);

            }
        }

        public static object DeserializeFromXmlFile(string filename, Type objectType, Encoding encoding)
        {
            try
            {
                // XmlSerializer für den Typ des Objekts erzeugen
                XmlSerializer serializer = new XmlSerializer(objectType);
                // Objekt über ein StreamReader-Objekt serialisieren
                using (StreamReader streamReader = new StreamReader(filename, encoding))
                {
                    return serializer.Deserialize(streamReader);
                }
            }
            catch
            {
                return (null);
            }

        }

    }
}
