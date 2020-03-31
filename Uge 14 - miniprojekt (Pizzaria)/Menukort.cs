using System;
using System.Windows.Forms;

namespace Uge_14___miniprojekt__Pizzaria_
{
    public partial class Menukort : Form
    {
        public void Prices()
        {
            alm1.Text = $"{almPrice.ToString()}";
            alm2.Text = $"{almPrice.ToString()}";
            alm3.Text = $"{almPrice.ToString()}";
            fam1.Text = $"{famPrice.ToString()}";
            fam2.Text = $"{famPrice.ToString()}";
            fam3.Text = $"{famPrice.ToString()}";
        }




        internal Pizza pizza;
        public const int almPrice = 69;
        public const int famPrice = 100;
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

            else
            {
                MessageBox.Show("Vælg pizza størelse inden du kan fortsætte");
            }

            if (pizza != null)
            {
                pizza.ShowIngredienser();
                totalPrice += (alm1.Checked || alm2.Checked || alm3.Checked) ? almPrice : famPrice;
            }
                
        }
    }
}
