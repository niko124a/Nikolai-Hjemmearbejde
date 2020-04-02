using System;
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
            pizzaNameLabel.Text = $"{pizza.Name} {pizza.size}";
            pizzaInfoLabel.Text = $"{pizza.Info}";
            valgtPizzaLabel.Text = $"{pizza.Name} {pizza.size}";
        }

        public Ingredienser(Menukort menukort)
        {
            InitializeComponent();
            this.pizza = menukort.pizza;
            this.menukort = menukort;
            ShowPizzaInfo();
            totalPriceLabel.Text = menukort.totalPrice.ToString();
            ordreLabel.Text = "";
        }

        private void eggCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (eggCheckBox.Checked)
            {
                pizza.ingrName = "Æg";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!eggCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Æg");
            }
        }

        private void agurkCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (agurkCheckBox.Checked)
            {
                pizza.ingrName = "Agurk";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!agurkCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Agurk");
            }
        }

        private void ananasCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ananasCheckBox.Checked)
            {
                ordreLabel.Text += $"Ananas  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!ananasCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Ananas  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void aspargesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (aspargesCheckBox.Checked)
            {
                ordreLabel.Text += $"Asparges  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!aspargesCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Asparges  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void baconCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (baconCheckBox.Checked)
            {
                ordreLabel.Text += $"Bacon  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!baconCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Bacon  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void champignonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (champignonCheckBox.Checked)
            {
                ordreLabel.Text += $"Champignon  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!champignonCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Champignon  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void chiliCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chiliCheckBox.Checked)
            {
                ordreLabel.Text += $"Chili  +2 {menukort.valuta}\n";
                menukort.totalPrice += 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!chiliCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Chili  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void dressingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dressingCheckBox.Checked)
            {
                ordreLabel.Text += $"Dressing  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!dressingCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Dressing  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void oksekødCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oksekødCheckBox.Checked)
            {
                ordreLabel.Text += $"Hakket Oksekød  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!oksekødCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Hakket Oksekød  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void hvidløgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hvidløgCheckBox.Checked)
            {
                ordreLabel.Text += $"Hvidløg  +2 {menukort.valuta}\n";
                menukort.totalPrice += 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!hvidløgCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Hvidløg  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void kebabCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (kebabCheckBox.Checked)
            {
                ordreLabel.Text += $"Kebab  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!kebabCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Kebab  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void kyllingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (kyllingCheckBox.Checked)
            {
                ordreLabel.Text += $"Kylling  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!kyllingCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Kylling  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void løgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (løgCheckBox.Checked)
            {
                ordreLabel.Text += $"Løg  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!løgCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Løg  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void paprikaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (paprikaCheckBox.Checked)
            {
                ordreLabel.Text += $"Paprika  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!paprikaCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Paprika  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void pepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
            {
                ordreLabel.Text += $"Pepperoni  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!pepperoniCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Pepperoni  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void rejerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rejerCheckBox.Checked)
            {
                ordreLabel.Text += $"Rejer  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!rejerCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Rejer  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void salatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (salatCheckBox.Checked)
            {
                ordreLabel.Text += $"Salat  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!salatCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Salat  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void skinkeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (skinkeCheckBox.Checked)
            {
                ordreLabel.Text += $"Skinke  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!skinkeCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Skinke  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void tabascoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tabascoCheckBox.Checked)
            {
                ordreLabel.Text += $"Tabasco  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!tabascoCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Tabasco  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void tomatskiverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tomatskiverCheckBox.Checked)
            {
                ordreLabel.Text += $"Tomatskiver  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!tomatskiverCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Tomatskiver  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void tunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tunCheckBox.Checked)
            {
                ordreLabel.Text += $"Tun  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!tunCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Tun  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }

        private void ostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ostCheckBox.Checked)
            {
                ordreLabel.Text += $"Ost  +2 {menukort.valuta}\n";
                menukort.totalPrice += 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!ostCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Ost  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
        }
    }
}
