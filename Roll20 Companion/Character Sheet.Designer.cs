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
            this.label1 = new System.Windows.Forms.Label();
            this.chaAbilityMod = new System.Windows.Forms.TextBox();
            this.wisAbilityMod = new System.Windows.Forms.TextBox();
            this.intAbilityMod = new System.Windows.Forms.TextBox();
            this.conAbilityMod = new System.Windows.Forms.TextBox();
            this.dexAbilityMod = new System.Windows.Forms.TextBox();
            this.strAbilityMod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.WeaponList = new System.Windows.Forms.ListView();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.chaEnhBonus = new System.Windows.Forms.TextBox();
            this.wisEnhBonus = new System.Windows.Forms.TextBox();
            this.intEnhBonus = new System.Windows.Forms.TextBox();
            this.conEnhBonus = new System.Windows.Forms.TextBox();
            this.dexEnhBonus = new System.Windows.Forms.TextBox();
            this.strEnhBonus = new System.Windows.Forms.TextBox();
            this.strTempMod = new System.Windows.Forms.TextBox();
            this.dexTempMod = new System.Windows.Forms.TextBox();
            this.conTempMod = new System.Windows.Forms.TextBox();
            this.intTempMod = new System.Windows.Forms.TextBox();
            this.wisTempMod = new System.Windows.Forms.TextBox();
            this.chaTempMod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadButton = new System.Windows.Forms.Button();
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
            this.BAB.Location = new System.Drawing.Point(496, 69);
            this.BAB.MaxLength = 2;
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
            // chaAbilityMod
            // 
            this.chaAbilityMod.Location = new System.Drawing.Point(220, 199);
            this.chaAbilityMod.MaxLength = 2;
            this.chaAbilityMod.Name = "chaAbilityMod";
            this.chaAbilityMod.Size = new System.Drawing.Size(43, 20);
            this.chaAbilityMod.TabIndex = 34;
            // 
            // wisAbilityMod
            // 
            this.wisAbilityMod.Location = new System.Drawing.Point(220, 173);
            this.wisAbilityMod.MaxLength = 2;
            this.wisAbilityMod.Name = "wisAbilityMod";
            this.wisAbilityMod.Size = new System.Drawing.Size(43, 20);
            this.wisAbilityMod.TabIndex = 33;
            // 
            // intAbilityMod
            // 
            this.intAbilityMod.Location = new System.Drawing.Point(220, 147);
            this.intAbilityMod.MaxLength = 2;
            this.intAbilityMod.Name = "intAbilityMod";
            this.intAbilityMod.Size = new System.Drawing.Size(43, 20);
            this.intAbilityMod.TabIndex = 32;
            // 
            // conAbilityMod
            // 
            this.conAbilityMod.Location = new System.Drawing.Point(220, 121);
            this.conAbilityMod.MaxLength = 2;
            this.conAbilityMod.Name = "conAbilityMod";
            this.conAbilityMod.Size = new System.Drawing.Size(43, 20);
            this.conAbilityMod.TabIndex = 31;
            // 
            // dexAbilityMod
            // 
            this.dexAbilityMod.Location = new System.Drawing.Point(220, 95);
            this.dexAbilityMod.MaxLength = 2;
            this.dexAbilityMod.Name = "dexAbilityMod";
            this.dexAbilityMod.Size = new System.Drawing.Size(43, 20);
            this.dexAbilityMod.TabIndex = 30;
            // 
            // strAbilityMod
            // 
            this.strAbilityMod.Location = new System.Drawing.Point(220, 69);
            this.strAbilityMod.MaxLength = 2;
            this.strAbilityMod.Name = "strAbilityMod";
            this.strAbilityMod.Size = new System.Drawing.Size(43, 20);
            this.strAbilityMod.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 26);
            this.label3.TabIndex = 36;
            this.label3.Text = "Ability\r\nModifier";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 72);
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
            this.button2.Location = new System.Drawing.Point(185, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 42;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(104, 354);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 43;
            this.button3.Text = "Edit";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(20, 495);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 44;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(101, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 26);
            this.label7.TabIndex = 51;
            this.label7.Text = "Enhancement\r\nBonus";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chaEnhBonus
            // 
            this.chaEnhBonus.Location = new System.Drawing.Point(122, 199);
            this.chaEnhBonus.MaxLength = 2;
            this.chaEnhBonus.Name = "chaEnhBonus";
            this.chaEnhBonus.Size = new System.Drawing.Size(43, 20);
            this.chaEnhBonus.TabIndex = 50;
            this.chaEnhBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // wisEnhBonus
            // 
            this.wisEnhBonus.Location = new System.Drawing.Point(122, 173);
            this.wisEnhBonus.MaxLength = 2;
            this.wisEnhBonus.Name = "wisEnhBonus";
            this.wisEnhBonus.Size = new System.Drawing.Size(43, 20);
            this.wisEnhBonus.TabIndex = 49;
            this.wisEnhBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // intEnhBonus
            // 
            this.intEnhBonus.Location = new System.Drawing.Point(122, 147);
            this.intEnhBonus.MaxLength = 2;
            this.intEnhBonus.Name = "intEnhBonus";
            this.intEnhBonus.Size = new System.Drawing.Size(43, 20);
            this.intEnhBonus.TabIndex = 48;
            this.intEnhBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // conEnhBonus
            // 
            this.conEnhBonus.Location = new System.Drawing.Point(122, 121);
            this.conEnhBonus.MaxLength = 2;
            this.conEnhBonus.Name = "conEnhBonus";
            this.conEnhBonus.Size = new System.Drawing.Size(43, 20);
            this.conEnhBonus.TabIndex = 47;
            this.conEnhBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // dexEnhBonus
            // 
            this.dexEnhBonus.Location = new System.Drawing.Point(122, 95);
            this.dexEnhBonus.MaxLength = 2;
            this.dexEnhBonus.Name = "dexEnhBonus";
            this.dexEnhBonus.Size = new System.Drawing.Size(43, 20);
            this.dexEnhBonus.TabIndex = 46;
            this.dexEnhBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // strEnhBonus
            // 
            this.strEnhBonus.AcceptsReturn = true;
            this.strEnhBonus.Location = new System.Drawing.Point(122, 69);
            this.strEnhBonus.MaxLength = 2;
            this.strEnhBonus.Name = "strEnhBonus";
            this.strEnhBonus.Size = new System.Drawing.Size(43, 20);
            this.strEnhBonus.TabIndex = 45;
            this.strEnhBonus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // strTempMod
            // 
            this.strTempMod.Location = new System.Drawing.Point(171, 69);
            this.strTempMod.MaxLength = 2;
            this.strTempMod.Name = "strTempMod";
            this.strTempMod.Size = new System.Drawing.Size(43, 20);
            this.strTempMod.TabIndex = 15;
            this.strTempMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // dexTempMod
            // 
            this.dexTempMod.Location = new System.Drawing.Point(171, 95);
            this.dexTempMod.MaxLength = 2;
            this.dexTempMod.Name = "dexTempMod";
            this.dexTempMod.Size = new System.Drawing.Size(43, 20);
            this.dexTempMod.TabIndex = 16;
            this.dexTempMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // conTempMod
            // 
            this.conTempMod.Location = new System.Drawing.Point(171, 121);
            this.conTempMod.MaxLength = 2;
            this.conTempMod.Name = "conTempMod";
            this.conTempMod.Size = new System.Drawing.Size(43, 20);
            this.conTempMod.TabIndex = 17;
            this.conTempMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // intTempMod
            // 
            this.intTempMod.Location = new System.Drawing.Point(171, 147);
            this.intTempMod.MaxLength = 2;
            this.intTempMod.Name = "intTempMod";
            this.intTempMod.Size = new System.Drawing.Size(43, 20);
            this.intTempMod.TabIndex = 18;
            this.intTempMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // wisTempMod
            // 
            this.wisTempMod.Location = new System.Drawing.Point(171, 173);
            this.wisTempMod.MaxLength = 2;
            this.wisTempMod.Name = "wisTempMod";
            this.wisTempMod.Size = new System.Drawing.Size(43, 20);
            this.wisTempMod.TabIndex = 19;
            this.wisTempMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // chaTempMod
            // 
            this.chaTempMod.Location = new System.Drawing.Point(171, 199);
            this.chaTempMod.MaxLength = 2;
            this.chaTempMod.Name = "chaTempMod";
            this.chaTempMod.Size = new System.Drawing.Size(43, 20);
            this.chaTempMod.TabIndex = 20;
            this.chaTempMod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 26);
            this.label2.TabIndex = 22;
            this.label2.Text = "Temp\r\nModifier";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(122, 495);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(75, 23);
            this.LoadButton.TabIndex = 52;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_OnClick);
            // 
            // CharacterSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 559);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chaEnhBonus);
            this.Controls.Add(this.wisEnhBonus);
            this.Controls.Add(this.intEnhBonus);
            this.Controls.Add(this.conEnhBonus);
            this.Controls.Add(this.dexEnhBonus);
            this.Controls.Add(this.strEnhBonus);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.WeaponList);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chaAbilityMod);
            this.Controls.Add(this.wisAbilityMod);
            this.Controls.Add(this.intAbilityMod);
            this.Controls.Add(this.conAbilityMod);
            this.Controls.Add(this.dexAbilityMod);
            this.Controls.Add(this.strAbilityMod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chaTempMod);
            this.Controls.Add(this.wisTempMod);
            this.Controls.Add(this.intTempMod);
            this.Controls.Add(this.conTempMod);
            this.Controls.Add(this.dexTempMod);
            this.Controls.Add(this.strTempMod);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox chaAbilityMod;
        private System.Windows.Forms.TextBox wisAbilityMod;
        private System.Windows.Forms.TextBox intAbilityMod;
        private System.Windows.Forms.TextBox conAbilityMod;
        private System.Windows.Forms.TextBox dexAbilityMod;
        private System.Windows.Forms.TextBox strAbilityMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListView WeaponList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox chaEnhBonus;
        private System.Windows.Forms.TextBox wisEnhBonus;
        private System.Windows.Forms.TextBox intEnhBonus;
        private System.Windows.Forms.TextBox conEnhBonus;
        private System.Windows.Forms.TextBox dexEnhBonus;
        private System.Windows.Forms.TextBox strEnhBonus;
        private System.Windows.Forms.TextBox strTempMod;
        private System.Windows.Forms.TextBox dexTempMod;
        private System.Windows.Forms.TextBox conTempMod;
        private System.Windows.Forms.TextBox intTempMod;
        private System.Windows.Forms.TextBox wisTempMod;
        private System.Windows.Forms.TextBox chaTempMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LoadButton;
    }
}

