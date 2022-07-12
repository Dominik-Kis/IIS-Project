using System.Xml.Serialization;

namespace REST_API.Models
{
	[XmlRoot(ElementName = "feature")]
	public class Feature
	{

		[XmlElement(ElementName = "attributes")]
		public List<string> Attributes { get; set; }

		[XmlElement(ElementName = "type")]
		public string Type { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
