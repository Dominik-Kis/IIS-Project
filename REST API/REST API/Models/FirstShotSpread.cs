using System.Xml.Serialization;

namespace REST_API.Models
{
	[XmlRoot(ElementName = "first_shot_spread")]
	public class FirstShotSpread
	{

		[XmlElement(ElementName = "hip")]
		public double Hip { get; set; }

		[XmlElement(ElementName = "ads")]
		public double Ads { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public double Text { get; set; }
	}
}
