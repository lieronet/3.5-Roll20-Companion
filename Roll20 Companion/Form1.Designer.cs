namespace Roll20_Companion
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
            this.Str = new System.Windows.Forms.TextBox();
            this.BAB = new System.Windows.Forms.TextBox();
            this.generateMacro = new System.Windows.Forms.Button();
            this.ResultsBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Str
            // 
            this.Str.Location = new System.Drawing.Point(85, 12);
            this.Str.MaxLength = 2;
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(43, 20);
            this.Str.TabIndex = 0;
            this.Str.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // BAB
            // 
            this.BAB.Location = new System.Drawing.Point(85, 135);
            this.BAB.Name = "BAB";
            this.BAB.Size = new System.Drawing.Size(43, 20);
            this.BAB.TabIndex = 1;
            this.BAB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateNumeric);
            // 
            // generateMacro
            // 
            this.generateMacro.Location = new System.Drawing.Point(364, 200);
            this.generateMacro.Name = "generateMacro";
            this.generateMacro.Size = new System.Drawing.Size(75, 23);
            this.generateMacro.TabIndex = 2;
            this.generateMacro.Text = "Do";
            this.generateMacro.UseVisualStyleBackColor = true;
            this.generateMacro.Click += new System.EventHandler(this.MakeMacro);
            // 
            // ResultsBox
            // 
            this.ResultsBox.Location = new System.Drawing.Point(318, 273);
            this.ResultsBox.Name = "ResultsBox";
            this.ResultsBox.Size = new System.Drawing.Size(209, 146);
            this.ResultsBox.TabIndex = 3;
            this.ResultsBox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ResultsBox);
            this.Controls.Add(this.generateMacro);
            this.Controls.Add(this.BAB);
            this.Controls.Add(this.Str);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Str;
        private System.Windows.Forms.TextBox BAB;
        private System.Windows.Forms.Button generateMacro;
        private System.Windows.Forms.RichTextBox ResultsBox;
    }
}

