using System.Xml.Serialization;

namespace REST_API.Models
{
	[XmlRoot(ElementName = "range")]
	public class Range
	{

		[XmlElement(ElementName = "low")]
		public int Low { get; set; }

		[XmlElement(ElementName = "high")]
		public int High { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public int Text { get; set; }

		[XmlElement(ElementName = "special")]
		public string Special { get; set; }
	}
}
