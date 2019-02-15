namespace Roll20_Companion
{
    partial class CharacterSheet
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
            this.StrScore = new System.Windows.Forms.TextBox();
            this.BAB = new System.Windows.Forms.TextBox();
            this.StrLabel = new System.Windows.Forms.Label();
            this.DexLabel = new System.Windows.Forms.Label();
            this.DexScore = new System.Windows.Forms.TextBox();
            this.ConLabel = new System.Windows.Forms.Label();
            this.ConScore = new System.Windows.Forms.TextBox();
            this.IntLabel = new System.Windows.Forms.Label();
            this.IntScore = new System.Windows.Forms.TextBox();
            this.WisLabel = new System.Windows.Forms.Label();
            this.WisScore = new System.Windows.Forms.TextBox();
            this.ChaLabel = new System.Windows.Forms.Label();
            this.ChaScore = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WeaponList = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StrScore
            // 
            this.StrScore.Location = new System.Drawing.Point(73, 69);
            this.StrScore.MaxLength = 2;
            this.StrScore.Name = "StrScore";
            this.StrScore.Size = new System.Drawing.Size(43, 20);
            this.StrScore.TabIndex = 0;
            this.StrScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // BAB
            // 
            this.BAB.Location = new System.Drawing.Point(419, 69);
            this.BAB.Name = "BAB";
            this.BAB.Size = new System.Drawing.Size(43, 20);
            this.BAB.TabIndex = 1;
            this.BAB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // StrLabel
            // 
            this.StrLabel.AutoSize = true;
            this.StrLabel.Location = new System.Drawing.Point(17, 69);
            this.StrLabel.Name = "StrLabel";
            this.StrLabel.Size = new System.Drawing.Size(29, 13);
            this.StrLabel.TabIndex = 4;
            this.StrLabel.Text = "STR";
            // 
            // DexLabel
            // 
            this.DexLabel.AutoSize = true;
            this.DexLabel.Location = new System.Drawing.Point(17, 95);
            this.DexLabel.Name = "DexLabel";
            this.DexLabel.Size = new System.Drawing.Size(29, 13);
            this.DexLabel.TabIndex = 6;
            this.DexLabel.Text = "DEX";
            // 
            // DexScore
            // 
            this.DexScore.Location = new System.Drawing.Point(73, 95);
            this.DexScore.MaxLength = 2;
            this.DexScore.Name = "DexScore";
            this.DexScore.Size = new System.Drawing.Size(43, 20);
            this.DexScore.TabIndex = 5;
            this.DexScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // ConLabel
            // 
            this.ConLabel.AutoSize = true;
            this.ConLabel.Location = new System.Drawing.Point(17, 121);
            this.ConLabel.Name = "ConLabel";
            this.ConLabel.Size = new System.Drawing.Size(30, 13);
            this.ConLabel.TabIndex = 8;
            this.ConLabel.Text = "CON";
            // 
            // ConScore
            // 
            this.ConScore.Location = new System.Drawing.Point(73, 121);
            this.ConScore.MaxLength = 2;
            this.ConScore.Name = "ConScore";
            this.ConScore.Size = new System.Drawing.Size(43, 20);
            this.ConScore.TabIndex = 7;
            this.ConScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // IntLabel
            // 
            this.IntLabel.AutoSize = true;
            this.IntLabel.Location = new System.Drawing.Point(17, 147);
            this.IntLabel.Name = "IntLabel";
            this.IntLabel.Size = new System.Drawing.Size(25, 13);
            this.IntLabel.TabIndex = 10;
            this.IntLabel.Text = "INT";
            // 
            // IntScore
            // 
            this.IntScore.Location = new System.Drawing.Point(73, 147);
            this.IntScore.MaxLength = 2;
            this.IntScore.Name = "IntScore";
            this.IntScore.Size = new System.Drawing.Size(43, 20);
            this.IntScore.TabIndex = 9;
            this.IntScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // WisLabel
            // 
            this.WisLabel.AutoSize = true;
            this.WisLabel.Location = new System.Drawing.Point(17, 173);
            this.WisLabel.Name = "WisLabel";
            this.WisLabel.Size = new System.Drawing.Size(28, 13);
            this.WisLabel.TabIndex = 12;
            this.WisLabel.Text = "WIS";
            // 
            // WisScore
            // 
            this.WisScore.Location = new System.Drawing.Point(73, 173);
            this.WisScore.MaxLength = 2;
            this.WisScore.Name = "WisScore";
            this.WisScore.Size = new System.Drawing.Size(43, 20);
            this.WisScore.TabIndex = 11;
            this.WisScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // ChaLabel
            // 
            this.ChaLabel.AutoSize = true;
            this.ChaLabel.Location = new System.Drawing.Point(17, 199);
            this.ChaLabel.Name = "ChaLabel";
            this.ChaLabel.Size = new System.Drawing.Size(29, 13);
            this.ChaLabel.TabIndex = 14;
            this.ChaLabel.Text = "CHA";
            // 
            // ChaScore
            // 
            this.ChaScore.Location = new System.Drawing.Point(73, 199);
            this.ChaScore.MaxLength = 2;
            this.ChaScore.Name = "ChaScore";
            this.ChaScore.Size = new System.Drawing.Size(43, 20);
            this.ChaScore.TabIndex = 13;
            this.ChaScore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(135, 199);
            this.textBox1.MaxLength = 2;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 20;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(135, 173);
            this.textBox2.MaxLength = 2;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 20);
            this.textBox2.TabIndex = 19;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(135, 147);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(135, 121);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(43, 20);
            this.textBox4.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(135, 95);
            this.textBox5.MaxLength = 2;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(43, 20);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(135, 69);
            this.textBox6.MaxLength = 2;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(43, 20);
            this.textBox6.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 26);
            this.label1.TabIndex = 21;
            this.label1.Text = "Base\r\nScore\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(132, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Temp\r\nModifier";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(196, 199);
            this.textBox7.MaxLength = 2;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(43, 20);
            this.textBox7.TabIndex = 28;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(196, 173);
            this.textBox8.MaxLength = 2;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(43, 20);
            this.textBox8.TabIndex = 27;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(196, 147);
            this.textBox9.MaxLength = 2;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(43, 20);
            this.textBox9.TabIndex = 26;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(196, 121);
            this.textBox10.MaxLength = 2;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(43, 20);
            this.textBox10.TabIndex = 25;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(196, 95);
            this.textBox11.MaxLength = 2;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(43, 20);
            this.textBox11.TabIndex = 24;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(196, 69);
            this.textBox12.MaxLength = 2;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(43, 20);
            this.textBox12.TabIndex = 23;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(257, 199);
            this.textBox13.MaxLength = 2;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(43, 20);
            this.textBox13.TabIndex = 34;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(257, 173);
            this.textBox14.MaxLength = 2;
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(43, 20);
            this.textBox14.TabIndex = 33;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(257, 147);
            this.textBox15.MaxLength = 2;
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(43, 20);
            this.textBox15.TabIndex = 32;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(257, 121);
            this.textBox16.MaxLength = 2;
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(43, 20);
            this.textBox16.TabIndex = 31;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(257, 95);
            this.textBox17.MaxLength = 2;
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(43, 20);
            this.textBox17.TabIndex = 30;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(257, 69);
            this.textBox18.MaxLength = 2;
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(43, 20);
            this.textBox18.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ability\r\nModifier";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 26);
            this.label4.TabIndex = 35;
            this.label4.Text = "Calculated\r\nModifier\r\n";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(384, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 37;
            this.label5.Text = "BAB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 38;
            this.label6.Text = "Weapons";
            // 
            // WeaponList
            // 
            this.WeaponList.Location = new System.Drawing.Point(20, 261);
            this.WeaponList.Name = "WeaponList";
            this.WeaponList.Size = new System.Drawing.Size(280, 87);
            this.WeaponList.TabIndex = 39;
            this.WeaponList.UseCompatibleStateImageBehavior = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(173, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WeaponList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox18);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.ChaLabel);
            this.Controls.Add(this.ChaScore);
            this.Controls.Add(this.WisLabel);
            this.Controls.Add(this.WisScore);
            this.Controls.Add(this.IntLabel);
            this.Controls.Add(this.IntScore);
            this.Controls.Add(this.ConLabel);
            this.Controls.Add(this.ConScore);
            this.Controls.Add(this.DexLabel);
            this.Controls.Add(this.DexScore);
            this.Controls.Add(this.StrLabel);
            this.Controls.Add(this.BAB);
            this.Controls.Add(this.StrScore);
            this.Name = "CharacterSheet";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StrScore;
        private System.Windows.Forms.TextBox BAB;
        private System.Windows.Forms.Label StrLabel;
        private System.Windows.Forms.Label DexLabel;
        private System.Windows.Forms.TextBox DexScore;
        private System.Windows.Forms.Label ConLabel;
        private System.Windows.Forms.TextBox ConScore;
        private System.Windows.Forms.Label IntLabel;
        private System.Windows.Forms.TextBox IntScore;
        private System.Windows.Forms.Label WisLabel;
        private System.Windows.Forms.TextBox WisScore;
        private System.Windows.Forms.Label ChaLabel;
        private System.Windows.Forms.TextBox ChaScore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView WeaponList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

