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
                pizza.ingrName = "Æg";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";


                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!eggCheckBox.Checked)
            {
                pizza.ingrName = "Æg";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Æg");
            }
        }

        private void agurkCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (agurkCheckBox.Checked)
            {
                pizza.ingrName = "Agurk";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";


                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!agurkCheckBox.Checked)
            {
                pizza.ingrName = "Agurk";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Agurk");
            }
        }

        private void ananasCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ananasCheckBox.Checked)
            {
                pizza.ingrName = "Ananas";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";


                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!ananasCheckBox.Checked)
            {
                pizza.ingrName = "Ananas";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Ananas");
            }
        }

        private void aspargesCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (aspargesCheckBox.Checked)
            {
                pizza.ingrName = "Asparges";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";


                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!aspargesCheckBox.Checked)
            {
                pizza.ingrName = "Asparges";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Asparges");
            }
        }

        private void baconCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (baconCheckBox.Checked)
            {
                pizza.ingrName = "Bacon";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                    menukort.totalPrice += 10;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";


                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!baconCheckBox.Checked)
            {
                pizza.ingrName = "Bacon";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 10;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Bacon");
            }
        }

        private void champignonCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (champignonCheckBox.Checked)
            {
                pizza.ingrName = "Champignon";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";


                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!champignonCheckBox.Checked)
            {
                pizza.ingrName = "Champignon";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }
                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Champignon");
            }
        }

        private void chiliCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (chiliCheckBox.Checked)
            {
                pizza.ingrName = "Chili";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +2 {menukort.valuta}\n";
                    menukort.totalPrice += 2;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!chiliCheckBox.Checked)
            {
                pizza.ingrName = "Chili";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +2 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 2;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Chili");
            }
        }

        private void dressingCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (dressingCheckBox.Checked)
            {
                pizza.ingrName = "Dressing";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";


                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!dressingCheckBox.Checked)
            {
                pizza.ingrName = "Dressing";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Dressing");
            }
        }

        private void oksekødCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (oksekødCheckBox.Checked)
            {
                pizza.ingrName = "Hakket Oksekød";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                    menukort.totalPrice += 10;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";


                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!oksekødCheckBox.Checked)
            {
                pizza.ingrName = "Hakket Oksekød";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 10;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Hakket Oksekød");
            }
        }

        private void hvidløgCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (hvidløgCheckBox.Checked)
            {
                pizza.ingrName = "Hvidløg";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +2 {menukort.valuta}\n";
                    menukort.totalPrice += 2;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!hvidløgCheckBox.Checked)
            {
                pizza.ingrName = "Hvidløg";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +2 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 2;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Hvidløg");
            }
        }

        private void kebabCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (kebabCheckBox.Checked)
            {
                pizza.ingrName = "Kebab";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                    menukort.totalPrice += 10;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!kebabCheckBox.Checked)
            {
                pizza.ingrName = "Kebab";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 10;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Kebab");
            }
        }

        private void kyllingCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (kyllingCheckBox.Checked)
            {
                pizza.ingrName = "Kylling";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                    menukort.totalPrice += 10;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!kyllingCheckBox.Checked)
            {
                pizza.ingrName = "Kylling";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 10;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Kylling");
            }
        }

        private void løgCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (løgCheckBox.Checked)
            {
                pizza.ingrName = "Løg";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!løgCheckBox.Checked)
            {
                pizza.ingrName = "Løg";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Løg");
            }
        }

        private void paprikaCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (paprikaCheckBox.Checked)
            {
                pizza.ingrName = "Paprika";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!paprikaCheckBox.Checked)
            {
                pizza.ingrName = "Paprika";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Paprika");
            }
        }

        private void pepperoniCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (pepperoniCheckBox.Checked)
            {
                pizza.ingrName = "Pepperoni";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                    menukort.totalPrice += 10;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!pepperoniCheckBox.Checked)
            {
                pizza.ingrName = "Pepperoni";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 10;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Pepperoni");
            }
        }

        private void rejerCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (rejerCheckBox.Checked)
            {
                pizza.ingrName = "Rejer";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                    menukort.totalPrice += 10;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!rejerCheckBox.Checked)
            {
                pizza.ingrName = "Rejer";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 10;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Rejer");
            }
        }

        private void salatCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (salatCheckBox.Checked)
            {
                pizza.ingrName = "Salat";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!salatCheckBox.Checked)
            {
                pizza.ingrName = "Salat";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Add("Salat");
            }
        }

        private void skinkeCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (skinkeCheckBox.Checked)
            {
                pizza.ingrName = "Skinke";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                    menukort.totalPrice += 10;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!skinkeCheckBox.Checked)
            {
                pizza.ingrName = "Skinke";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 10;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Skinke");
            }
        }

        private void tabascoCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (tabascoCheckBox.Checked)
            {
                pizza.ingrName = "Tabasco";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!tabascoCheckBox.Checked)
            {
                pizza.ingrName = "Tabasco";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Tabasco");
            }
        }

        private void tomatskiverCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (tomatskiverCheckBox.Checked)
            {
                pizza.ingrName = "Tomatskiver";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +5 {menukort.valuta}\n";
                    menukort.totalPrice += 5;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!tomatskiverCheckBox.Checked)
            {
                pizza.ingrName = "Tomatskiver";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +5 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 5;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Tomatskiver");
            }
        }

        private void tunCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (tunCheckBox.Checked)
            {
                pizza.ingrName = "Tun";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +10 {menukort.valuta}\n";
                    menukort.totalPrice += 10;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!tunCheckBox.Checked)
            {
                pizza.ingrName = "Tun";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +10 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 10;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Tun");
            }
        }

        private void ostCheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (ostCheckBox.Checked)
            {
                pizza.ingrName = "Ost";
                Pizza.IngrCol.Add(pizza.ingrName);
                if (antalIngredienserValgt >= 4)
                {
                    ordreLabel.Text += $"{pizza.ingrName}  +2 {menukort.valuta}\n";
                    menukort.totalPrice += 2;
                }
                else
                    ordreLabel.Text += $"{pizza.ingrName}\n";

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt++;
            }
            else if (!ostCheckBox.Checked)
            {
                pizza.ingrName = "Ost";
                if (antalIngredienserValgt > 4)
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}  +2 {menukort.valuta}\n", "");
                    ordreLabel.Text = replacement;
                    menukort.totalPrice -= 2;
                }
                else
                {
                    string replacement = ordreLabel.Text.Replace($"{pizza.ingrName}\n", "");
                    ordreLabel.Text = replacement;
                }

                totalPriceLabel.Text = menukort.totalPrice.ToString();
                antalIngredienserValgt--;
                Pizza.IngrCol.Remove("Ost");
            }
        }
    }
}
