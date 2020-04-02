using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt__Pizzaria_
{
    public class Pizza
    {

        public int price = 0;
        public string ingrName = "";

        public static List<string> IngrCol = new List<string>();

        public int Id = 0;
        public string Name = "";
        public string Info = "";
        public static int almPrice = 69;
        public static int famPrice = 100;
        public string size = "";

        public static Pizza[] pizzaCol =
        {
            new Pizza(1, "Margarita", "Tomat, Ost, Oregano"),
            new Pizza(2, "Proscitto", "Tomat, Ost, Skinke"),
            new Pizza(3, "Hawaii", "Tomat, Ost, Skinke, Ananas"),
            new Pizza(4, "Lav selv", "Tomat, Vælg 4 ingredienser")
        };

        public Pizza(int Id, string Name, string Info)
        {
            this.Id = Id;
            this.Name = Name;
            this.Info = Info;
        }
        public void ShowIngredienser(Menukort menukort)
        {
            new Ingredienser(menukort).Show();
        }

        public void ShowCustom(Menukort menukort)
        {
            new Custom(menukort).Show();
        }

    }
}
