using System.Windows.Forms;

namespace Uge_14___miniprojekt__Pizzaria_
{
    public partial class Ingredienser : Form
    {
        public Pizza pizza;
        public Menukort menukort;
        public Ingredienser ingredienser;
        public void ShowPizzaInfo()
        {
            pizzaIDLabel.Text = $"{pizza.Id.ToString()}.";
            pizzaNameLabel.Text = $"{pizza.Name}";
            pizzaInfoLabel.Text = $"{pizza.Info}";
        }

        public void CreateOrder()
        {
            if (eggCheckBox.Checked)
            {
                ordreLabel.Text += $"Æg  +5 {menukort.valuta}";
            }
        }

        public Ingredienser(Menukort menukort)
        {
            InitializeComponent();
            this.pizza = menukort.pizza;
            this.menukort = menukort;
            ShowPizzaInfo();
            totalPriceLabel.Text = menukort.totalPrice.ToString();
            CreateOrder();
        }
    }
}
