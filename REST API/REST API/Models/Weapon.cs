using System.Runtime.Serialization;

namespace REST_API.Models
{
	[DataContract(Namespace = "http://schemas.datacontract.org/2004/07/REST_API.Models")]
	public class Weapon
	{
		[DataMember(Order = 0)]
		public string Id { get; set; }

		[DataMember(Order = 1)]
		public string Name { get; set; }

		[DataMember(Order = 2)]
		public int Cost { get; set; }

		[DataMember(Order = 3)]
		public double Penetration { get; set; }

		[DataMember(Order = 4)]
		public double FireRate { get; set; }

		[DataMember(Order = 5)]
		public double RunSpeed { get; set; }

		[DataMember(Order = 6)]
		public double EquipSpeed { get; set; }

		[DataMember(Order = 7)]
		public double ReloadSpeed { get; set; }

		[DataMember(Order = 8)]
		public int Magazine { get; set; }
	}
}
