using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uge_14___miniprojekt__Pizzaria_
{
    public class Pizza
    {
        public int Id = 0;
        public string Name = "";
        public string Info = "";

        public static Pizza[] pizzaCol =
        {
            new Pizza(1, "Margarita", "Tomat, Ost, Oregano"),
            new Pizza(2, "Proscitto", "Tomat, Ost, Skinke"),
            new Pizza(3, "Hawaii", "Tomat, Ost, Skinke, Ananas")
        };


        public void ShowIngredienser()
        {
            new Ingredienser(this).Show();
        }

        public Pizza(int Id, string Name, string Info)
        {
            this.Id = Id;
            this.Name = Name;
            this.Info = Info;
        }


    }
}
