﻿using System.Xml.Serialization;

namespace REST_API.Models
{
	[XmlRoot(ElementName = "alt_fire")]
	public class AltFire
	{

		[XmlElement(ElementName = "type")]
		public string Type { get; set; }

		[XmlElement(ElementName = "attributes")]
		public Attributes Attributes { get; set; }

		[XmlAttribute(AttributeName = "id")]
		public string Id { get; set; }

		[XmlText]
		public string Text { get; set; }
	}
}
