using System;
using System.Windows.Forms;

namespace Uge_14___miniprojekt__Pizzaria_
{
    public partial class Ingredienser : Form
    {
        public bool nyBund = true;
        public Pizza pizza;
        public Menukort menukort;
        public Ingredienser ingredienser;
        public void ShowPizzaInfo()
        {
            pizzaIDLabel.Text = $"{pizza.Id}.";
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
                pizza.ingrName = "Ananas";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!ananasCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Ananas");
            }
        }

        private void aspargesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (aspargesCheckBox.Checked)
            {
                pizza.ingrName = "Asparges";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!aspargesCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Asparges");
            }
        }

        private void baconCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (baconCheckBox.Checked)
            {
                pizza.ingrName = "Bacon";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!baconCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Bacon");
            }
        }

        private void champignonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (champignonCheckBox.Checked)
            {
                pizza.ingrName = "Champignon";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!champignonCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Champignon");
            }
        }

        private void chiliCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chiliCheckBox.Checked)
            {
                pizza.ingrName = "Chili";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +2 {menukort.valuta}\n";
                menukort.totalPrice += 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!chiliCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Chili");
            }
        }

        private void dressingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (dressingCheckBox.Checked)
            {
                pizza.ingrName = "Dressing";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!dressingCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Dressing");
            }
        }

        private void oksekødCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (oksekødCheckBox.Checked)
            {
                pizza.ingrName = "Hakket Oksekød";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!oksekødCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Hakket Oksekød");
            }
        }

        private void hvidløgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hvidløgCheckBox.Checked)
            {
                pizza.ingrName = "Hvidløg";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +2 {menukort.valuta}\n";
                menukort.totalPrice += 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!hvidløgCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Hvidløg");
            }
        }

        private void kebabCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (kebabCheckBox.Checked)
            {
                pizza.ingrName = "Kebab";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!kebabCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Kebab");
            }
        }

        private void kyllingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (kyllingCheckBox.Checked)
            {
                pizza.ingrName = "Kylling";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!kyllingCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Kylling");
            }
        }

        private void løgCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (løgCheckBox.Checked)
            {
                pizza.ingrName = "Løg";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!løgCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Løg");
            }
        }

        private void paprikaCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (paprikaCheckBox.Checked)
            {
                pizza.ingrName = "Paprika";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!paprikaCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Paprika");
            }
        }

        private void pepperoniCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
            {
                pizza.ingrName = "Pepperoni";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!pepperoniCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Pepperoni");
            }
        }

        private void rejerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (rejerCheckBox.Checked)
            {
                pizza.ingrName = "Rejer";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!rejerCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Rejer");
            }
        }

        private void salatCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (salatCheckBox.Checked)
            {
                pizza.ingrName = "Salat";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!salatCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Salat");
            }
        }

        private void skinkeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (skinkeCheckBox.Checked)
            {
                pizza.ingrName = "Skinke";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!skinkeCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Skinke");
            }
        }

        private void tabascoCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tabascoCheckBox.Checked)
            {
                pizza.ingrName = "Tabasco";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!tabascoCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Tabasco");
            }
        }

        private void tomatskiverCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tomatskiverCheckBox.Checked)
            {
                pizza.ingrName = "Tomatskiver";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                menukort.totalPrice += 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!tomatskiverCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}+5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 5;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Tomatskiver");
            }
        }

        private void tunCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (tunCheckBox.Checked)
            {
                pizza.ingrName = "Tun";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                menukort.totalPrice += 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!tunCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 10;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Tun");
            }
        }

        private void ostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (ostCheckBox.Checked)
            {
                pizza.ingrName = "Ost";
                Pizza.IngrCol.Add(pizza.ingrName);
                ordreLabel.Text += $"{pizza.ingrName}  +2 {menukort.valuta}\n";
                menukort.totalPrice += 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
            }
            else if (!ostCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 2;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                Pizza.IngrCol.Remove("Ost");
            }
        }

        private void bundComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (nyBund)
            {
                pizza.bund = bundComboBox.Text;
                ordreLabel.Text += $"{pizza.bund}  +15 {menukort.valuta}\n";
                menukort.totalPrice += 15;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                nyBund = false;
            }
            else if (!nyBund)
            {
                string replacement = ordreLabel.Text.Replace($"{pizza.bund}  +15 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                menukort.totalPrice -= 15;
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                nyBund = true;
            }
        }

        private void sodavandComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pizza.sodavand = sodavandComboBox.Text;
        }
    }
}
