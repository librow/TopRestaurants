using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    public class Restaurant
    {
        //creating the attributes of a Restaurant object
        public Restaurant(int rank) //ensures no one can go in and set the restaurant rank
        {
            RestRank = rank;
        }
        [Required]
        public int RestRank { get; }
        [Required]
        public string RestName { get; set; }
#nullable enable
        public string? FavDish { get; set; } = "It's all tasty!";   //adds default if null
#nullable disable
        [Required]
        public string Address { get; set; }
#nullable enable
        [Phone]
        public string? PhoneNum { get; set; }
        public string? Website { get; set; } = "Coming soon.";

        public static Restaurant[] GetRestaurants() //method to create instances of a restaurant
        {
            Restaurant r1 = new Restaurant(1)
            {
                RestName = "Guru's",
                FavDish = "Chicken Quesadilla",
                Address = "45 E Center St",
                PhoneNum = "8013754878",
                Website = "guruscafe.com"
            };

            Restaurant r2 = new Restaurant(2)
            {
                RestName = "Cubby's",
                //FavDish = "Chicken Quesadilla",
                Address = "1258 N State St"
                //PhoneNum = "8013754878",
                //Website = "guruscafe.com"
            };

            Restaurant r3 = new Restaurant(3)
            {
                RestName = "Seven Brothers",
                FavDish = "Fries",
                Address = "Riverwoods",
                //PhoneNum = "8013754878",
                //Website = "guruscafe.com"
            };

            Restaurant r4 = new Restaurant(4)
            {
                RestName = "Two Jacks Pizza",
                FavDish = "Cheese Bread",
                Address = "Center Street",
                //PhoneNum = "8013754878",
                //Website = "guruscafe.com"
            };

            Restaurant r5 = new Restaurant(5)
            {
                RestName = "Kohinoor",
                //FavDish = "Fries",
                Address = "75 State St",
                PhoneNum = "8012266666",
                Website = "kohinoorut.com"
            };

            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }
    }
}
