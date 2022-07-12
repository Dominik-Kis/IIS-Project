using System.Xml.Serialization;

namespace REST_API.Models
{
	[XmlRoot(ElementName = "weapons")]
	public class Weapons
	{

		[XmlElement(ElementName = "damage")]
		public List<Damage> Damage { get; set; }

		[XmlElement(ElementName = "name")]
		public string Name { get; set; }

		[XmlElement(ElementName = "cost")]
		public int Cost { get; set; }

		[XmlElement(ElementName = "spread")]
		public string Spread { get; set; }

		[XmlElement(ElementName = "fire_type")]
		public string FireType { get; set; }

		[XmlElement(ElementName = "penetration")]
		public string Penetration { get; set; }

		[XmlElement(ElementName = "fire_rate")]
		public double FireRate { get; set; }

		[XmlElement(ElementName = "run_speed")]
		public double RunSpeed { get; set; }

		[XmlElement(ElementName = "equip_speed")]
		public double EquipSpeed { get; set; }

		[XmlElement(ElementName = "first_shot_spread")]
		public FirstShotSpread FirstShotSpread { get; set; }

		[XmlElement(ElementName = "reload_speed")]
		public double ReloadSpeed { get; set; }

		[XmlElement(ElementName = "magazine")]
		public int Magazine { get; set; }

		[XmlElement(ElementName = "alt_fire")]
		public AltFire AltFire { get; set; }

		[XmlElement(ElementName = "feature")]
		public Feature Feature { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
