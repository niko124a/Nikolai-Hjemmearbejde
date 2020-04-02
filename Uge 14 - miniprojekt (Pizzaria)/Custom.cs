using System.Windows.Forms;

namespace Uge_14___miniprojekt__Pizzaria_
{
    public partial class Custom : Form
    {
        public Pizza pizza;
        public Menukort menukort;
        public Ingredienser ingredienser;

        public int antalIngredienserValgt = 0;

        public void ShowPizzaInfo()
        {
            pizzaIDLabel.Text = $"{pizza.Id.ToString()}.";
            pizzaNameLabel.Text = $"{pizza.Name}";
            pizzaInfoLabel.Text = $"{pizza.Info}";
        }

        public Custom(Menukort menukort)
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
                ordreLabel.Text += $"Æg  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!eggCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Æg  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void agurkCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (agurkCheckBox.Checked)
            {
                ordreLabel.Text += $"Agurk  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!agurkCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Agurk  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void ananasCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ananasCheckBox.Checked)
            {
                ordreLabel.Text += $"Ananas  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!ananasCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Ananas  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void aspargesCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (aspargesCheckBox.Checked)
            {
                ordreLabel.Text += $"Asparges  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!aspargesCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Asparges  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void baconCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (baconCheckBox.Checked)
            {
                ordreLabel.Text += $"Bacon  +10 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!baconCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Bacon  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void champignonCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (champignonCheckBox.Checked)
            {
                ordreLabel.Text += $"Champignon  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!champignonCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Champignon  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void chiliCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chiliCheckBox.Checked)
            {
                ordreLabel.Text += $"Chili  +2 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 2;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!chiliCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Chili  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 2;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void dressingCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (dressingCheckBox.Checked)
            {
                ordreLabel.Text += $"Dressing  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!dressingCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Dressing  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void oksekødCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (oksekødCheckBox.Checked)
            {
                ordreLabel.Text += $"Hakket Oksekød  +10 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!oksekødCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Hakket Oksekød  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void hvidløgCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (hvidløgCheckBox.Checked)
            {
                ordreLabel.Text += $"Hvidløg  +2 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 2;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!hvidløgCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Hvidløg  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 2;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void kebabCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (kebabCheckBox.Checked)
            {
                ordreLabel.Text += $"Kebab  +10 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!kebabCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Kebab  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void kyllingCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (kyllingCheckBox.Checked)
            {
                ordreLabel.Text += $"Kylling  +10 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!kyllingCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Kylling  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void løgCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (løgCheckBox.Checked)
            {
                ordreLabel.Text += $"Løg  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!løgCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Løg  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void paprikaCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (paprikaCheckBox.Checked)
            {
                ordreLabel.Text += $"Paprika  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!paprikaCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Paprika  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void pepperoniCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
            {
                ordreLabel.Text += $"Pepperoni  +10 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!pepperoniCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Pepperoni  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void rejerCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rejerCheckBox.Checked)
            {
                ordreLabel.Text += $"Rejer  +10 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!rejerCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Rejer  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void salatCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (salatCheckBox.Checked)
            {
                ordreLabel.Text += $"Salat  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!salatCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Salat  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void skinkeCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (skinkeCheckBox.Checked)
            {
                ordreLabel.Text += $"Skinke  +10 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!skinkeCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Skinke  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void tabascoCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (tabascoCheckBox.Checked)
            {
                ordreLabel.Text += $"Tabasco  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!tabascoCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Tabasco  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void tomatskiverCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (tomatskiverCheckBox.Checked)
            {
                ordreLabel.Text += $"Tomatskiver  +5 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!tomatskiverCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Tomatskiver  +5 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 5;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void tunCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (tunCheckBox.Checked)
            {
                ordreLabel.Text += $"Tun  +10 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!tunCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Tun  +10 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                    menukort.totalPrice -= 10;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }

        private void ostCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ostCheckBox.Checked)
            {
                ordreLabel.Text += $"Ost  +2 {menukort.valuta}\n";
                if (antalIngredienserValgt >= 4)
                    menukort.totalPrice += 2;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!ostCheckBox.Checked)
            {
                string replacement = ordreLabel.Text.Replace($"Ost  +2 {menukort.valuta}\n", "");
                ordreLabel.Text = replacement;
                if (antalIngredienserValgt > 4)
                menukort.totalPrice -= 2;

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
            }
        }
    }
}
