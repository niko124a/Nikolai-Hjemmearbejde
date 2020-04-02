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

        public static Pizza[] ingredienserCol =
        {
            new Pizza(5, "Æg"), 
            new Pizza(5, "Agurk"), 
            new Pizza(5, "Ananas"), 
            new Pizza(5, "Asparges"), 
            new Pizza(10, "Bacon"), 
            new Pizza(5, "Champignon"), 
            new Pizza(2, "Chili"), 
            new Pizza(5, "Dressing"), 
            new Pizza(10, "Hakket Oksekød"), 
            new Pizza(2, "Hvidløg"), 
            new Pizza(10, "Kebab"), 
            new Pizza(10, "Kylling"), 
            new Pizza(5, "Løg"), 
            new Pizza(5, "Paprika"), 
            new Pizza(10, "Pepperoni"), 
            new Pizza(10, "Rejer"), 
            new Pizza(5, "Salat"), 
            new Pizza(10, "Skinke"), 
            new Pizza(5, "Tabasco"), 
            new Pizza(5, "Tomatskiver"), 
            new Pizza(10, "Tun"), 
            new Pizza(2, "Ost")
        };

        public Pizza(int price, string ingrName)
        {
            this.price = price;
            this.ingrName = ingrName;
        }

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
            new Pizza(4, "Lav selv", "")
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
