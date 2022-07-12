using REST_API.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddXmlDataContractSerializerFormatters();

List<WeaponClass> weaponClasses = createDatabase();

builder.Services.AddSingleton<List<WeaponClass>>(weaponClasses);

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();

List<WeaponClass> createDatabase()
{
    return new List<WeaponClass>
            {
                new WeaponClass
                {
                    Id = "615d417e4b126600042c3a68",
                    Name = "Sidearms",
                    Weapons = new List<Weapons>
                    {
                        new Weapons
                        {
                            Id = "615ea05bffbc7300043f21b5",
                            Name = "Ghost",
                            Cost = 500,
                            Spread = "https://valorant-api-project.herokuapp.com/images/ghost",
                            FireType = "Semi",
                            Penetration = "Medium",
                            FireRate = 6.75,
                            RunSpeed = 5.73,
                            EquipSpeed= 0.75,
                            FirstShotSpread = new FirstShotSpread{
                            Id = "615ea05bffbc7300043f21b0",
                                Hip= 0.3,
                                Text= 0
                            },
                            ReloadSpeed= 1.5,
                            Magazine= 15,
                            AltFire= null,
                            Feature= null,
                            Damage = new List<Damage>
                            {
                                new Damage
                                {
                                    Id = "615ea05bffbc7300043f21b2",
                                    Head = 105,
                                    Body = 30,
                                    Legs = 25,
                                    Text = 0,
                                    Range = new REST_API.Models.Range
                                    {
                                        Id = "615ea05bffbc7300043f21b1",
                                        Low = 0,
                                        High = 30,
                                        Text = 0
                                    }
                                },

                                new Damage
                                {
                                    Id = "615ea05bffbc7300043f21b4",
                                    Head = 87,
                                    Body = 25,
                                    Legs = 21,
                                    Text = 0,
                                    Range = new REST_API.Models.Range
                                    {
                                        Id = "615ea05bffbc7300043f21b3",
                                        Low = 30,
                                        High = 50,
                                        Text = 0
                                    }
                                }
                            },

                            Text = "24"
                        }
                    }
                },

                new WeaponClass
                {
                    Id = "615d41a44b126600042c3a6b",
                    Name = "Rifles",
                    Text = "4",
                    Weapons = new List<Weapons>
                    {
                        new Weapons
                        {
                            Id = "615ea989ffbc7300043f21fd",
                            Name = "Phantom",
                            Cost = 2900,
                            Spread = "https://valorant-api-project.herokuapp.com/images/phantom",
                            FireType = "Auto",
                            Penetration = "Medium",
                            FireRate = 11,
                            RunSpeed = 5.4,
                            EquipSpeed= 1,
                            FirstShotSpread = new FirstShotSpread{
                                Id = "615ea989ffbc7300043f21f3",
                                Hip= 0.2,
                                Ads = 0.11,
                                Text = 0
                            },
                            ReloadSpeed= 2.5,
                            Magazine= 30,
                            AltFire = new AltFire
                            {
                                Id = "615ea989ffbc7300043f21fb",
                                Type = "Aim Down Sights",
                                Attributes = new Attributes{
                                Id = "615ea989ffbc7300043f21fa",
                                    Zoom = 1.25,
                                    FireRate = new List<string>{
                                        "90%",
                                        "9.9"
                                    },
                                    MoveSpeed = new List<string>{
                                        "76%",
                                        "4.104"
                                    },
                                    Special = new List<string>{
                                        "Slight spread and recoil reduction",
                                        "Crosshair follows recoil"
                                    },
                                    Text= 0
                                },
                                Text = "0"
                            },
                            Feature = new Feature
                            {
                                Attributes = new List<string>{
                                    "Tracers not visible to enemies",
                                    "Firing sound can't be heard at distances of 40m+ except in direction of fire"
                                },
                                Id = "615ea989ffbc7300043f21fc",
                                Type = "Silenced",
                                Text = "0"
                            },
                            Damage = new List<Damage>
                            {
                                new Damage
                                {
                                    Id = "615ea989ffbc7300043f21f5",
                                    Head = 156,
                                    Body = 39,
                                    Legs = 33,
                                    Text = 0,
                                    Range = new REST_API.Models.Range
                                    {
                                        Id = "615ea989ffbc7300043f21f4",
                                        Low = 0,
                                        High = 15,
                                        Text = 0
                                    }
                                },

                                new Damage
                                {
                                    Id = "615ea989ffbc7300043f21f7",
                                    Head = 140,
                                    Body = 35,
                                    Legs = 29,
                                    Text = 0,
                                    Range = new REST_API.Models.Range
                                    {
                                        Id = "615ea989ffbc7300043f21f6",
                                        Low = 15,
                                        High = 30,
                                        Text = 0
                                    }
                                },


                                new Damage
                                {
                                    Id = "615ea989ffbc7300043f21f9",
                                    Head = 124,
                                    Body = 31,
                                    Legs = 26,
                                    Text = 0,
                                    Range = new REST_API.Models.Range
                                    {
                                        Id = "615ea989ffbc7300043f21f8",
                                        Low = 30,
                                        High = 50,
                                        Text = 0
                                    }
                                }
                            },

                            Text = "0"
                        }
                    }
                },
            };
}