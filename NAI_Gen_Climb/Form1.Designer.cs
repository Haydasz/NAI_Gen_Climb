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
            this.max = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.min = new System.Windows.Forms.TextBox();
            this.asdaf = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.function = new System.Windows.Forms.ComboBox();
            this.iteration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.genIter = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.genMin = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.genY = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.genX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.population = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.climbIter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.climbMin = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.climbY = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.climbX = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.delta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Overviev.SuspendLayout();
            this.Przegląd.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.Przegląd.Controls.Add(this.max);
            this.Przegląd.Controls.Add(this.label6);
            this.Przegląd.Controls.Add(this.min);
            this.Przegląd.Controls.Add(this.asdaf);
            this.Przegląd.Controls.Add(this.label3);
            this.Przegląd.Controls.Add(this.function);
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
            // max
            // 
            this.max.Location = new System.Drawing.Point(91, 137);
            this.max.Name = "max";
            this.max.Size = new System.Drawing.Size(53, 20);
            this.max.TabIndex = 8;
            this.max.Text = "5";
            this.max.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Górny zakres";
            // 
            // min
            // 
            this.min.Location = new System.Drawing.Point(91, 95);
            this.min.Name = "min";
            this.min.Size = new System.Drawing.Size(53, 20);
            this.min.TabIndex = 6;
            this.min.Text = "-5";
            this.min.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // asdaf
            // 
            this.asdaf.AutoSize = true;
            this.asdaf.Location = new System.Drawing.Point(14, 98);
            this.asdaf.Name = "asdaf";
            this.asdaf.Size = new System.Drawing.Size(68, 13);
            this.asdaf.TabIndex = 5;
            this.asdaf.Text = "Dolny zakres";
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
            // function
            // 
            this.function.FormattingEnabled = true;
            this.function.Items.AddRange(new object[] {
            "Funkcja testowa 1",
            "Funkcja Geema",
            "Funkcja Matyasa",
            "Funkcja Bealea",
            ""});
            this.function.Location = new System.Drawing.Point(91, 55);
            this.function.Name = "function";
            this.function.Size = new System.Drawing.Size(121, 21);
            this.function.TabIndex = 3;
            // 
            // iteration
            // 
            this.iteration.Location = new System.Drawing.Point(91, 19);
            this.iteration.Name = "iteration";
            this.iteration.Size = new System.Drawing.Size(53, 20);
            this.iteration.TabIndex = 2;
            this.iteration.Text = "5000";
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
            this.tabPage1.Controls.Add(this.groupBox3);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.genIter);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.genMin);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.genY);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.genX);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Location = new System.Drawing.Point(21, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(376, 100);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wynik";
            // 
            // genIter
            // 
            this.genIter.Location = new System.Drawing.Point(273, 57);
            this.genIter.Name = "genIter";
            this.genIter.Size = new System.Drawing.Size(53, 20);
            this.genIter.TabIndex = 10;
            this.genIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(196, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "iteracja";
            // 
            // genMin
            // 
            this.genMin.Location = new System.Drawing.Point(273, 31);
            this.genMin.Name = "genMin";
            this.genMin.Size = new System.Drawing.Size(53, 20);
            this.genMin.TabIndex = 11;
            this.genMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(196, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "minimum";
            // 
            // genY
            // 
            this.genY.Location = new System.Drawing.Point(89, 57);
            this.genY.Name = "genY";
            this.genY.Size = new System.Drawing.Size(53, 20);
            this.genY.TabIndex = 7;
            this.genY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "y";
            // 
            // genX
            // 
            this.genX.Location = new System.Drawing.Point(89, 31);
            this.genX.Name = "genX";
            this.genX.Size = new System.Drawing.Size(53, 20);
            this.genX.TabIndex = 7;
            this.genX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 6;
            this.label12.Text = "x";
            // 
            // population
            // 
            this.population.Location = new System.Drawing.Point(129, 20);
            this.population.Name = "population";
            this.population.Size = new System.Drawing.Size(53, 20);
            this.population.TabIndex = 4;
            this.population.Text = "100";
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.delta);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(459, 238);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Wspinaczkowy";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.climbIter);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.climbMin);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.climbY);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.climbX);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(19, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 100);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wynik";
            // 
            // climbIter
            // 
            this.climbIter.Location = new System.Drawing.Point(273, 57);
            this.climbIter.Name = "climbIter";
            this.climbIter.Size = new System.Drawing.Size(53, 20);
            this.climbIter.TabIndex = 10;
            this.climbIter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(196, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "iteracja";
            // 
            // climbMin
            // 
            this.climbMin.Location = new System.Drawing.Point(273, 31);
            this.climbMin.Name = "climbMin";
            this.climbMin.Size = new System.Drawing.Size(53, 20);
            this.climbMin.TabIndex = 11;
            this.climbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "minimum";
            // 
            // climbY
            // 
            this.climbY.Location = new System.Drawing.Point(89, 57);
            this.climbY.Name = "climbY";
            this.climbY.Size = new System.Drawing.Size(53, 20);
            this.climbY.TabIndex = 7;
            this.climbY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(12, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(12, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "y";
            // 
            // climbX
            // 
            this.climbX.Location = new System.Drawing.Point(89, 31);
            this.climbX.Name = "climbX";
            this.climbX.Size = new System.Drawing.Size(53, 20);
            this.climbX.TabIndex = 7;
            this.climbX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(12, 13);
            this.label16.TabIndex = 6;
            this.label16.Text = "x";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Location = new System.Drawing.Point(19, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Punkt początkowy";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(89, 57);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(53, 20);
            this.textBox3.TabIndex = 7;
            this.textBox3.Text = "0.5";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "y";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(89, 31);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(53, 20);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "1";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "x";
            // 
            // delta
            // 
            this.delta.Location = new System.Drawing.Point(330, 71);
            this.delta.Name = "delta";
            this.delta.Size = new System.Drawing.Size(53, 20);
            this.delta.TabIndex = 4;
            this.delta.Text = "0,0001";
            this.delta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Dystans";
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
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.ComboBox function;
        private System.Windows.Forms.TextBox population;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox max;
        private System.Windows.Forms.TextBox min;
        private System.Windows.Forms.Label asdaf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox delta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox genY;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox genX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox genIter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox genMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox climbIter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox climbMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox climbY;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox climbX;
        private System.Windows.Forms.Label label16;
    }
}

