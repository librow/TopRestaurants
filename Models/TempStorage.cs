using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TopRestaurants.Models
{
    //A model that temporarily stores the information submitted on the website
    public class TempStorage
    {
        private static List<Suggestion> suggestions = new List<Suggestion>();

        public static IEnumerable<Suggestion> Suggestion => suggestions;

        public static void AddRestaurant(Suggestion suggestion)
        {
            suggestions.Add(suggestion);
        }
    }
}
