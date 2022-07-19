using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

/// <summary>
/// Summary description for SOAP
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class SOAP : System.Web.Services.WebService
{
    private List<Weapon> weapons;
    public SOAP()
    {
        weapons = new List<Weapon>
        {
            new Weapon
            {
                Id = "1",
                Name = "Ghost",
                Cost = 500,
                Penetration = 1.5,
                FireRate = 5,
                RunSpeed = 1.5,
                EquipSpeed = 1.5,
                ReloadSpeed = 1.5,
                Magazine = 15
            },

            new Weapon
            {
                Id = "2",
                Name = "Clasic",
                Cost = 0,
                Penetration = 1.0,
                FireRate = 4.5,
                RunSpeed = 2,
                EquipSpeed = 1.2,
                ReloadSpeed = 1.2,
                Magazine = 11
            },

            new Weapon
            {
                Id = "3",
                Name = "Frenzy",
                Cost = 450,
                Penetration = 1.2,
                FireRate = 12,
                RunSpeed = 1.5,
                EquipSpeed = 1.8,
                ReloadSpeed = 1.8,
                Magazine = 35
            }
        };
    }

    [WebMethod]
    public string SearchWeapon(string name)
    {
        XElement xmlDoc = new XElement("Weapons");

        foreach (var weapon in weapons)
        {
            xmlDoc.Add(
                new XElement("Weapon", 
                new XElement("Id", weapon.Id),
                new XElement("Name", weapon.Name),
                new XElement("Cost", weapon.Cost),
                new XElement("Penetration", weapon.Penetration),
                new XElement("FireRate", weapon.FireRate),
                new XElement("RunSpeed", weapon.RunSpeed),
                new XElement("EquipSpeed", weapon.EquipSpeed),
                new XElement("ReloadSpeed", weapon.ReloadSpeed),
                new XElement("Magazine", weapon.Magazine)
                ));
        }

        string value = xmlDoc.XPathSelectElement("Weapon/Name[text()='" + name + "']/parent::Weapon").ToString();
        string path = Directory.GetParent((string)HttpContext.Current.Server.MapPath("~/")).Parent.Parent.FullName;
        System.Console.WriteLine(path);


        XmlDocument xml = new XmlDocument();
        xml.LoadXml(xmlDoc.ToString());
        xml.Save(path + "/JAXB/jaxb.xml");


        return value;
    }

}
