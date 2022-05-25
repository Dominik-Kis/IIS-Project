namespace REST_API.Models
{
    public class Weapon
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
