using System;
using System.Windows.Forms;

namespace Uge_14___miniprojekt__Pizzaria_
{
    public partial class Menukort : Form
    {
        public void Prices()
        {
            alm1.Text = $"{Pizza.almPrice.ToString()} {valuta}";
            alm2.Text = $"{Pizza.almPrice.ToString()} {valuta}";
            alm3.Text = $"{Pizza.almPrice.ToString()} {valuta}";
            alm4.Text = $"{Pizza.almPrice.ToString()} {valuta}";
            fam1.Text = $"{Pizza.famPrice.ToString()} {valuta}";
            fam2.Text = $"{Pizza.famPrice.ToString()} {valuta}";
            fam3.Text = $"{Pizza.famPrice.ToString()} {valuta}";
            fam4.Text = $"{Pizza.famPrice.ToString()} {valuta}";
        }

        public Pizza pizza;
        public string valuta = "kr.";
        public int totalPrice = 0;

        public Menukort()
        {
            InitializeComponent();
            Prices();
        }
        private void choice1_Click(object sender, EventArgs e)
        {

            if (alm1.Checked || fam1.Checked)
                pizza = Pizza.pizzaCol[0];

            else if (alm2.Checked || fam2.Checked)
                pizza = Pizza.pizzaCol[1];

            else if (alm3.Checked || fam3.Checked)
                pizza = Pizza.pizzaCol[2];

            else if (alm4.Checked || fam4.Checked)
                pizza = Pizza.pizzaCol[3];

            else
            {
                MessageBox.Show("Vælg pizza størelse inden du kan fortsætte");
            }

            if (pizza == null)
                return;

            totalPrice = (alm1.Checked || alm2.Checked || alm3.Checked) ? Pizza.almPrice : Pizza.famPrice;
            pizza.size = (alm1.Checked || alm2.Checked || alm3.Checked) ? "Alm." : "Fam.";

            if (pizza != Pizza.pizzaCol[3])
                pizza.ShowIngredienser(this);
            else
                pizza.ShowCustom(this);
        }
    }
}
