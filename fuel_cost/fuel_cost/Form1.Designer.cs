namespace fuel_cost
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.paliwo = new System.Windows.Forms.Label();
            this.spalanie = new System.Windows.Forms.Label();
            this.km = new System.Windows.Forms.Label();
            this.wynik = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // paliwo
            // 
            this.paliwo.AutoSize = true;
            this.paliwo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.paliwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paliwo.Font = new System.Drawing.Font("Univers Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.paliwo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.paliwo.Location = new System.Drawing.Point(12, 91);
            this.paliwo.Name = "paliwo";
            this.paliwo.Size = new System.Drawing.Size(117, 21);
            this.paliwo.TabIndex = 0;
            this.paliwo.Text = "Cena za 1l paliwa";
            // 
            // spalanie
            // 
            this.spalanie.AutoSize = true;
            this.spalanie.BackColor = System.Drawing.SystemColors.ControlLight;
            this.spalanie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.spalanie.Font = new System.Drawing.Font("Univers Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.spalanie.Location = new System.Drawing.Point(12, 142);
            this.spalanie.Name = "spalanie";
            this.spalanie.Size = new System.Drawing.Size(131, 21);
            this.spalanie.TabIndex = 1;
            this.spalanie.Text = "Spalanie na 100 km";
            // 
            // km
            // 
            this.km.AutoSize = true;
            this.km.BackColor = System.Drawing.SystemColors.ControlLight;
            this.km.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.km.Font = new System.Drawing.Font("Univers Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.km.Location = new System.Drawing.Point(12, 191);
            this.km.Name = "km";
            this.km.Size = new System.Drawing.Size(147, 21);
            this.km.TabIndex = 2;
            this.km.Text = "Ilość przejechanych km";
            // 
            // wynik
            // 
            this.wynik.AutoSize = true;
            this.wynik.BackColor = System.Drawing.SystemColors.ControlLight;
            this.wynik.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wynik.Font = new System.Drawing.Font("Univers Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.wynik.Location = new System.Drawing.Point(12, 244);
            this.wynik.Name = "wynik";
            this.wynik.Size = new System.Drawing.Size(154, 21);
            this.wynik.TabIndex = 3;
            this.wynik.Text = "Tyle zapłacisz za podróż";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(98, 305);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "Naciśnij by otrzymać rezultat";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(244, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 143);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(244, 191);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(244, 244);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 8;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(369, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.oProgramieToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("oProgramieToolStripMenuItem.BackgroundImage")));
            this.oProgramieToolStripMenuItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.oProgramieToolStripMenuItem.Font = new System.Drawing.Font("Univers Condensed", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.oProgramieToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(369, 364);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wynik);
            this.Controls.Add(this.km);
            this.Controls.Add(this.spalanie);
            this.Controls.Add(this.paliwo);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Motokoszt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label paliwo;
        private System.Windows.Forms.Label spalanie;
        private System.Windows.Forms.Label km;
        private System.Windows.Forms.Label wynik;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
    }
}

