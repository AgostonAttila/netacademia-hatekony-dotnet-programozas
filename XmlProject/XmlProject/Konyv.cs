using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace XmlProject
{
    [XmlRoot(ElementName = "book")]
    public class Konyv
    {
        [XmlAttribute(AttributeName = "id")]
        public string Id { get; set; }

        [XmlElement(ElementName = "author")]
        public string Szerzo { get; set; }

        [XmlElement(ElementName = "genre")]
        public Mufajok Mufaj { get; set; }

        [XmlElement(ElementName = "price")]
        public decimal Ar { get; set; }

        [XmlElement(ElementName = "publish_date",DataType="date")]
        public DateTime KiadasDatuma { get; set; }

        [XmlElement(ElementName = "description")]
        public string Leiras { get; set; }
    }
}

public enum Mufajok
{
    Computer,
    Fantasy,
    Romance,
    SciFi,
    Horror
}