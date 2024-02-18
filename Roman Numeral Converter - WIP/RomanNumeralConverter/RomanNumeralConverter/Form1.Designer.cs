
namespace RomanNumeralConverter
{
    partial class frmRomanNumeralConverter
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRomanNumeralConverter));
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnConvertToRomanNumeral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Purple;
            this.lblTitle.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(93, 40);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 46);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Enter a number";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.Color.Purple;
            this.txtNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNumber.Location = new System.Drawing.Point(292, 40);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber.Multiline = true;
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(143, 45);
            this.txtNumber.TabIndex = 1;
            // 
            // lblDisplay
            // 
            this.lblDisplay.Font = new System.Drawing.Font("Roboto Bk", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisplay.ForeColor = System.Drawing.Color.White;
            this.lblDisplay.Location = new System.Drawing.Point(93, 224);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(343, 132);
            this.lblDisplay.TabIndex = 2;
            this.lblDisplay.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnConvertToRomanNumeral
            // 
            this.btnConvertToRomanNumeral.BackColor = System.Drawing.Color.Purple;
            this.btnConvertToRomanNumeral.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnConvertToRomanNumeral.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConvertToRomanNumeral.Location = new System.Drawing.Point(183, 148);
            this.btnConvertToRomanNumeral.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnConvertToRomanNumeral.Name = "btnConvertToRomanNumeral";
            this.btnConvertToRomanNumeral.Size = new System.Drawing.Size(166, 61);
            this.btnConvertToRomanNumeral.TabIndex = 3;
            this.btnConvertToRomanNumeral.Text = "Convert To Roman Numeral";
            this.btnConvertToRomanNumeral.UseVisualStyleBackColor = false;
            this.btnConvertToRomanNumeral.Click += new System.EventHandler(this.btnConvertToRomanNumeral_Click);
            // 
            // frmRomanNumeralConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(534, 389);
            this.Controls.Add(this.btnConvertToRomanNumeral);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRomanNumeralConverter";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnConvertToRomanNumeral;
    }
}

