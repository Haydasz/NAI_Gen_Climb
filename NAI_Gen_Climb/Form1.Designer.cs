namespace NAI_Gen_Climb
{
    partial class Form1
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
            this.Overviev = new System.Windows.Forms.TabControl();
            this.Przegląd = new System.Windows.Forms.TabPage();
            this.iteration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.population = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Overviev.SuspendLayout();
            this.Przegląd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Overviev
            // 
            this.Overviev.Controls.Add(this.Przegląd);
            this.Overviev.Controls.Add(this.tabPage1);
            this.Overviev.Controls.Add(this.tabPage3);
            this.Overviev.Location = new System.Drawing.Point(12, 41);
            this.Overviev.Name = "Overviev";
            this.Overviev.SelectedIndex = 0;
            this.Overviev.Size = new System.Drawing.Size(467, 264);
            this.Overviev.TabIndex = 0;
            // 
            // Przegląd
            // 
            this.Przegląd.Controls.Add(this.label3);
            this.Przegląd.Controls.Add(this.comboBox1);
            this.Przegląd.Controls.Add(this.iteration);
            this.Przegląd.Controls.Add(this.label2);
            this.Przegląd.Controls.Add(this.generate);
            this.Przegląd.Location = new System.Drawing.Point(4, 22);
            this.Przegląd.Name = "Przegląd";
            this.Przegląd.Padding = new System.Windows.Forms.Padding(3);
            this.Przegląd.Size = new System.Drawing.Size(459, 238);
            this.Przegląd.TabIndex = 1;
            this.Przegląd.Text = "Start";
            this.Przegląd.UseVisualStyleBackColor = true;
            // 
            // iteration
            // 
            this.iteration.Location = new System.Drawing.Point(91, 19);
            this.iteration.Name = "iteration";
            this.iteration.Size = new System.Drawing.Size(53, 20);
            this.iteration.TabIndex = 2;
            this.iteration.Text = "500";
            this.iteration.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Liczba iteracji";
            // 
            // generate
            // 
            this.generate.Location = new System.Drawing.Point(301, 180);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(75, 23);
            this.generate.TabIndex = 0;
            this.generate.Text = "Generuj";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.population);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(459, 238);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Genetyczny";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 238);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Wspinaczkowy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Symulacja optymalizacji funkcji za pomocą algorytmów";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Funkcja jakaś"});
            this.comboBox1.Location = new System.Drawing.Point(91, 55);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Funkcja";
            // 
            // population
            // 
            this.population.Location = new System.Drawing.Point(129, 20);
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(53, 20);
            this.population.TabIndex = 4;
            this.population.Text = "10";
            this.population.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wielkość populacji";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 317);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Overviev);
            this.Name = "Form1";
            this.Text = "Symulacja optymalizacji funkcji za pomocą algorytmów";
            this.Overviev.ResumeLayout(false);
            this.Przegląd.ResumeLayout(false);
            this.Przegląd.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Overviev;
        private System.Windows.Forms.TabPage Przegląd;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox iteration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox population;
        private System.Windows.Forms.Label label4;
    }
}

