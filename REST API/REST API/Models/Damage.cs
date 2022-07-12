using System.Xml.Serialization;

namespace REST_API.Models
{
	[XmlRoot(ElementName = "damage")]
	public class Damage
	{

		[XmlElement(ElementName = "range")]
		public Range Range { get; set; }

		[XmlElement(ElementName = "head")]
		public int Head { get; set; }

		[XmlElement(ElementName = "body")]
		public int Body { get; set; }

		[XmlElement(ElementName = "legs")]
		public int Legs { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public int Text { get; set; }
	}
}
