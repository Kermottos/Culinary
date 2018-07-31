using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CulinaryApp.Models;

namespace CulinaryApp.Data
{
    public static class DbInitializer
    {
        public static void Initialize(RecipeContext context)
        {
            context.Database.EnsureCreated();

            if (context.Recipes.Any())
            {
                return;
            }

            var recipes = new Recipe[]
            {
                new Recipe{ Name="Pączki", Products="pomidor", Description="asdasdsadasd", Difficulty=3, Rating=5, Time=12 },
                new Recipe{ Name="Pad Thai", Products="ziemniak", Description="dxcvzxfsdf", Difficulty=2, Rating=2, Time=11 },
                new Recipe{ Name="Spaghetti", Products="mleko", Description="zxczxdgsdas", Difficulty=4, Rating=3, Time=14 }, 
                new Recipe{ Name="Rosół", Products="cebula", Description="asdfasfdszx", Difficulty=7, Rating=2, Time=13 },
                new Recipe{ Name="Naleśniki", Products="mleko", Description="zxcfasfsac", Difficulty=6, Rating=5, Time=5 },
                new Recipe{ Name="Ziemniaki pure", Products="czosnek", Description="asfsafasczx", Difficulty=2, Rating=1, Time=6 },
                new Recipe{ Name="Ser z brokułami", Products="kurczak", Description="zxcascascxzc", Difficulty=1, Rating=4, Time=7 },
                new Recipe{ Name="Pizza", Products="majonez", Description="zxcasfascxa", Difficulty=3, Rating=5, Time=13 }
            };
            foreach (Recipe s in recipes)
            {
                context.Recipes.Add(s);
            }
            context.SaveChanges();
        }
    }
}
