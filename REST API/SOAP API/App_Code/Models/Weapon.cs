using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

/// <summary>
/// Summary description for Weapon
/// </summary>
public class Weapon
{
	public string Id { get; set; }

	public string Name { get; set; }

	public int Cost { get; set; }

	public double Penetration { get; set; }

	public double FireRate { get; set; }

	public double RunSpeed { get; set; }

	public double EquipSpeed { get; set; }

	public double ReloadSpeed { get; set; }

	public int Magazine { get; set; }
};