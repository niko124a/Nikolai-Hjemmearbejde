namespace Uge_14___miniprojekt__Pizzaria_
{
    partial class Ingredienser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pizzaIDLabel = new System.Windows.Forms.Label();
            this.pizzaInfoLabel = new System.Windows.Forms.Label();
            this.pizzaNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valgmuligheder";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pizzaIDLabel
            // 
            this.pizzaIDLabel.AutoSize = true;
            this.pizzaIDLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaIDLabel.Location = new System.Drawing.Point(22, 44);
            this.pizzaIDLabel.Name = "pizzaIDLabel";
            this.pizzaIDLabel.Size = new System.Drawing.Size(28, 33);
            this.pizzaIDLabel.TabIndex = 1;
            this.pizzaIDLabel.Text = "0";
            // 
            // pizzaInfoLabel
            // 
            this.pizzaInfoLabel.AutoSize = true;
            this.pizzaInfoLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaInfoLabel.Location = new System.Drawing.Point(53, 77);
            this.pizzaInfoLabel.Name = "pizzaInfoLabel";
            this.pizzaInfoLabel.Size = new System.Drawing.Size(48, 18);
            this.pizzaInfoLabel.TabIndex = 2;
            this.pizzaInfoLabel.Text = "label3";
            // 
            // pizzaNameLabel
            // 
            this.pizzaNameLabel.AutoSize = true;
            this.pizzaNameLabel.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaNameLabel.Location = new System.Drawing.Point(50, 44);
            this.pizzaNameLabel.Name = "pizzaNameLabel";
            this.pizzaNameLabel.Size = new System.Drawing.Size(76, 33);
            this.pizzaNameLabel.TabIndex = 3;
            this.pizzaNameLabel.Text = "label4";
            // 
            // Ingredienser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 658);
            this.Controls.Add(this.pizzaNameLabel);
            this.Controls.Add(this.pizzaInfoLabel);
            this.Controls.Add(this.pizzaIDLabel);
            this.Controls.Add(this.label1);
            this.Name = "Ingredienser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredienser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pizzaIDLabel;
        private System.Windows.Forms.Label pizzaInfoLabel;
        private System.Windows.Forms.Label pizzaNameLabel;
    }
}