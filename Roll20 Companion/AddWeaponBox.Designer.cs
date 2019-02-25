namespace Roll20_Companion
{
    partial class AddWeaponBox
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
            this.components = new System.ComponentModel.Container();
            this.WeaponName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.WeaponAttackBonus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WeaponDamageDice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.WeaponDamageBonus = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.WeaponCritRange = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.WeaponCritBonus = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.WeaponDamageType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.WeaponAttackStat = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.WeaponDamageStat = new System.Windows.Forms.ComboBox();
            this.characterSheetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.IsTwoHanded = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.characterSheetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // WeaponName
            // 
            this.WeaponName.Location = new System.Drawing.Point(55, 97);
            this.WeaponName.Name = "WeaponName";
            this.WeaponName.Size = new System.Drawing.Size(100, 20);
            this.WeaponName.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Weapon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(158, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Attack Bonus";
            // 
            // WeaponAttackBonus
            // 
            this.WeaponAttackBonus.Location = new System.Drawing.Point(161, 97);
            this.WeaponAttackBonus.Name = "WeaponAttackBonus";
            this.WeaponAttackBonus.Size = new System.Drawing.Size(100, 20);
            this.WeaponAttackBonus.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(264, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Damage Dice";
            // 
            // WeaponDamageDice
            // 
            this.WeaponDamageDice.Location = new System.Drawing.Point(267, 97);
            this.WeaponDamageDice.Name = "WeaponDamageDice";
            this.WeaponDamageDice.Size = new System.Drawing.Size(100, 20);
            this.WeaponDamageDice.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Damage Bonus";
            // 
            // WeaponDamageBonus
            // 
            this.WeaponDamageBonus.Location = new System.Drawing.Point(373, 97);
            this.WeaponDamageBonus.Name = "WeaponDamageBonus";
            this.WeaponDamageBonus.Size = new System.Drawing.Size(100, 20);
            this.WeaponDamageBonus.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Crit Range";
            // 
            // WeaponCritRange
            // 
            this.WeaponCritRange.Location = new System.Drawing.Point(55, 293);
            this.WeaponCritRange.Name = "WeaponCritRange";
            this.WeaponCritRange.Size = new System.Drawing.Size(100, 20);
            this.WeaponCritRange.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(158, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crit Bonus";
            // 
            // WeaponCritBonus
            // 
            this.WeaponCritBonus.Location = new System.Drawing.Point(161, 293);
            this.WeaponCritBonus.Name = "WeaponCritBonus";
            this.WeaponCritBonus.Size = new System.Drawing.Size(100, 20);
            this.WeaponCritBonus.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(264, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Damage Type";
            // 
            // WeaponDamageType
            // 
            this.WeaponDamageType.Location = new System.Drawing.Point(267, 140);
            this.WeaponDamageType.Name = "WeaponDamageType";
            this.WeaponDamageType.Size = new System.Drawing.Size(100, 20);
            this.WeaponDamageType.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(58, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Attack Stat";
            // 
            // WeaponAttackStat
            // 
            this.WeaponAttackStat.FormattingEnabled = true;
            this.WeaponAttackStat.Location = new System.Drawing.Point(55, 187);
            this.WeaponAttackStat.Name = "WeaponAttackStat";
            this.WeaponAttackStat.Size = new System.Drawing.Size(100, 21);
            this.WeaponAttackStat.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Damage Stat";
            // 
            // WeaponDamageStat
            // 
            this.WeaponDamageStat.FormattingEnabled = true;
            this.WeaponDamageStat.Location = new System.Drawing.Point(161, 187);
            this.WeaponDamageStat.Name = "WeaponDamageStat";
            this.WeaponDamageStat.Size = new System.Drawing.Size(100, 21);
            this.WeaponDamageStat.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(55, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(161, 363);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // IsTwoHanded
            // 
            this.IsTwoHanded.AutoSize = true;
            this.IsTwoHanded.Location = new System.Drawing.Point(374, 140);
            this.IsTwoHanded.Name = "IsTwoHanded";
            this.IsTwoHanded.Size = new System.Drawing.Size(94, 17);
            this.IsTwoHanded.TabIndex = 22;
            this.IsTwoHanded.Text = "Two Handed?";
            this.IsTwoHanded.UseVisualStyleBackColor = true;
            // 
            // AddWeaponBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IsTwoHanded);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.WeaponDamageStat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.WeaponAttackStat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.WeaponDamageType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WeaponCritBonus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WeaponCritRange);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WeaponDamageBonus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WeaponDamageDice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeaponAttackBonus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WeaponName);
            this.Name = "AddWeaponBox";
            this.Text = "AddWeaponBox";
            ((System.ComponentModel.ISupportInitialize)(this.characterSheetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WeaponName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox WeaponAttackBonus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox WeaponDamageDice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox WeaponDamageBonus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox WeaponCritRange;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox WeaponCritBonus;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox WeaponDamageType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox WeaponAttackStat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox WeaponDamageStat;
        private System.Windows.Forms.BindingSource characterSheetBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox IsTwoHanded;
    }
}