using System.Xml.Serialization;

namespace REST_API.Models
{
	[XmlRoot(ElementName = "attributes")]
	public class Attributes
	{

		[XmlElement(ElementName = "zoom")]
		public double Zoom { get; set; }

		[XmlElement(ElementName = "fire_rate")]
		public List<string> FireRate { get; set; }

		[XmlElement(ElementName = "move_speed")]
		public List<string> MoveSpeed { get; set; }

		[XmlElement(ElementName = "rounds_per_burst")]
		public int RoundsPerBurst { get; set; }

		[XmlElement(ElementName = "special")]
		public List<string> Special { get; set; }

		[XmlElement(ElementName = "pellet_count")]
		public int PelletCount { get; set; }

		[XmlElement(ElementName = "burst_rate")]
		public double BurstRate { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public double Text { get; set; }
	}
}
