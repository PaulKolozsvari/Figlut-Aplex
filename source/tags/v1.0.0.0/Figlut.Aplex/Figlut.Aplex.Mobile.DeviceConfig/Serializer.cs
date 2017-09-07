namespace Figlut.Aplex.Mobile.DeviceConfig
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Xml;
    using System.Xml.Serialization;
    using System.IO;

    #endregion //Using Directives

    public class Serializer
    {
        #region Methods

        public static void SerializeToFile(object obj, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using(XmlWriter writer = XmlWriter.Create(filename))
            {
                serializer.Serialize(writer, obj);
            }
        }

        public static object DeserializeFromFile(Type type, string filename)
        {
            XmlSerializer serializer = new XmlSerializer(type);
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException(string.Format("Could not find file {0}", filename));
            }
            using (XmlReader reader = XmlReader.Create(filename))
            {
                return serializer.Deserialize(reader);
            }
        }

        #endregion //Methods
    }
}
