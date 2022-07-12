using System.Xml.Serialization;

namespace REST_API.Models
{
	[XmlRoot(ElementName = "weapon_class")]
	public class WeaponClass
	{

		[XmlElement(ElementName = "weapons")]
		public List<Weapons> Weapons { get; set; }

		[XmlElement(ElementName = "name")]
		public string Name { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
