using MvcShoelaces.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcShoelaces.Data
{
    public class SeedData
    {
        public static List<Shoelaces> Shoelaces = new List<Shoelaces>() {

            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Golf",
             Color = "White",
             Length = 14,
             Cost = 111.2m,
             Rating =1,
             CreatedDate = DateTime.Now.AddDays(-1),
             ModifiedDate = DateTime.Now.AddDays(-1)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Sperry",
             Color = "Brown",
             Length = 8,
             Cost = 200m,
             Rating =3,
             CreatedDate = DateTime.Now.AddDays(-2),
             ModifiedDate = DateTime.Now.AddDays(-2)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Thorogood",
             Color = "Black",
             Length = 16,
             Cost = 110.8m,
             Rating =4,
             CreatedDate = DateTime.Now.AddDays(-3),
             ModifiedDate = DateTime.Now.AddDays(-3)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "ECCO",
             Color = "Blue",
             Length = 14,
             Cost = 111.2m,
             Rating =2,
             CreatedDate = DateTime.Now.AddDays(-4),
             ModifiedDate = DateTime.Now.AddDays(-4)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Thorogood",
             Color = "Red",
             Length = 10,
             Cost = 200m,
             Rating =5,
             CreatedDate = DateTime.Now.AddDays(-5),
             ModifiedDate = DateTime.Now.AddDays(-5)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Golf",
             Color = "White",
             Length = 9,
             Cost = 210m,
             Rating =4,
             CreatedDate = DateTime.Now.AddDays(-6),
             ModifiedDate = DateTime.Now.AddDays(-6)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Sperry",
             Color = "Brown",
             Length = 19,
             Cost = 111.2m,
             Rating =2,
             CreatedDate = DateTime.Now.AddDays(-7),
             ModifiedDate = DateTime.Now.AddDays(-7)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Thorogood",
             Color = "Red",
             Length = 8,
             Cost = 102m,
             Rating =1,
             CreatedDate = DateTime.Now.AddDays(-8),
             ModifiedDate = DateTime.Now.AddDays(-8)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Sperry",
             Color = "Blue",
             Length = 10,
             Cost = 145m,
             Rating =5,
             CreatedDate = DateTime.Now.AddDays(-9),
             ModifiedDate = DateTime.Now.AddDays(-9)
            },
            new Shoelaces(){
             Id = Guid.NewGuid().ToString(),
             Brand = "Thorogood",
             Color = "Black",
             Length = 15,
             Cost = 150m,
             Rating =3,
             CreatedDate = DateTime.Now.AddDays(-10),
             ModifiedDate = DateTime.Now.AddDays(-10)
            }
        };
    }
}
