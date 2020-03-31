using System.Windows.Forms;

namespace Uge_14___miniprojekt__Pizzaria_
{
    public partial class Ingredienser : Form
    {
        public void ShowPizzaInfo()
        {
            pizzaIDLabel.Text = $"{pizza.Id.ToString()}.";
            pizzaNameLabel.Text = $"{pizza.Name}";
            pizzaInfoLabel.Text = $"{pizza.Info}";
        }


        public Pizza pizza;
        public Ingredienser(Pizza pizza)
        {
            InitializeComponent();
            this.pizza = pizza;
            ShowPizzaInfo();

        }

    }
}
