namespace IIS_Client.Models
{
    public class AltFire
    {
        public string _id { get; set; }
        public string type { get; set; }
        public Attributes attributes { get; set; }
        public int __v { get; set; }
    }

    public class Attributes
    {
        public string _id { get; set; }
        public int pellet_count { get; set; }
        public double burst_rate { get; set; }
        public int __v { get; set; }
    }

    public class Damage
    {
        public string _id { get; set; }
        public Range range { get; set; }
        public int head { get; set; }
        public int body { get; set; }
        public int legs { get; set; }
        public int __v { get; set; }
    }

    public class FirstShotSpread
    {
        public string _id { get; set; }
        public double hip { get; set; }
        public int __v { get; set; }
    }

    public class Range
    {
        public string _id { get; set; }
        public int low { get; set; }
        public int high { get; set; }
        public int __v { get; set; }
    }

    public class Weapons
    {
        public List<Damage> damage { get; set; }
        public string _id { get; set; }
        public string name { get; set; }
        public int cost { get; set; }
        public string spread { get; set; }
        public string fire_type { get; set; }
        public string penetration { get; set; }
        public double fire_rate { get; set; }
        public double run_speed { get; set; }
        public double equip_speed { get; set; }
        public FirstShotSpread first_shot_spread { get; set; }
        public double reload_speed { get; set; }
        public int magazine { get; set; }
        public AltFire alt_fire { get; set; }
        public object feature { get; set; }
        public int __v { get; set; }
    }
}
