
namespace Shopping_Cart
{
    partial class frmShoppingCart
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOrderForm = new System.Windows.Forms.TabPage();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.btnAddToOrder = new System.Windows.Forms.Button();
            this.dudProducts = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOrderAddress = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lstProducts = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtMailingLabel = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabOrderForm.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOrderForm);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(715, 415);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabShoppingCart_SelectedIndexChanged);
            // 
            // tabOrderForm
            // 
            this.tabOrderForm.BackColor = System.Drawing.Color.Black;
            this.tabOrderForm.Controls.Add(this.btnExit);
            this.tabOrderForm.Controls.Add(this.btnNewOrder);
            this.tabOrderForm.Controls.Add(this.lblItemsOrdered);
            this.tabOrderForm.Controls.Add(this.btnAddToOrder);
            this.tabOrderForm.Controls.Add(this.dudProducts);
            this.tabOrderForm.Controls.Add(this.label1);
            this.tabOrderForm.Controls.Add(this.txtOrderAddress);
            this.tabOrderForm.Location = new System.Drawing.Point(4, 24);
            this.tabOrderForm.Name = "tabOrderForm";
            this.tabOrderForm.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrderForm.Size = new System.Drawing.Size(707, 387);
            this.tabOrderForm.TabIndex = 0;
            this.tabOrderForm.Text = "Order Form";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(543, 312);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(300, 312);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(120, 29);
            this.btnNewOrder.TabIndex = 5;
            this.btnNewOrder.Text = "New Order";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblItemsOrdered.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblItemsOrdered.Location = new System.Drawing.Point(135, 263);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(447, 21);
            this.lblItemsOrdered.TabIndex = 4;
            this.lblItemsOrdered.Text = " Items Ordered  :  0";
            this.lblItemsOrdered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddToOrder
            // 
            this.btnAddToOrder.Location = new System.Drawing.Point(300, 213);
            this.btnAddToOrder.Name = "btnAddToOrder";
            this.btnAddToOrder.Size = new System.Drawing.Size(120, 23);
            this.btnAddToOrder.TabIndex = 3;
            this.btnAddToOrder.Text = "Add to order";
            this.btnAddToOrder.UseVisualStyleBackColor = true;
            this.btnAddToOrder.Click += new System.EventHandler(this.btnAddToOrder_Click);
            // 
            // dudProducts
            // 
            this.dudProducts.ForeColor = System.Drawing.Color.Black;
            this.dudProducts.Location = new System.Drawing.Point(300, 161);
            this.dudProducts.Name = "dudProducts";
            this.dudProducts.Size = new System.Drawing.Size(120, 23);
            this.dudProducts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(48, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Address ";
            // 
            // txtOrderAddress
            // 
            this.txtOrderAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrderAddress.Location = new System.Drawing.Point(48, 43);
            this.txtOrderAddress.Multiline = true;
            this.txtOrderAddress.Name = "txtOrderAddress";
            this.txtOrderAddress.Size = new System.Drawing.Size(615, 101);
            this.txtOrderAddress.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.lblTotalCost);
            this.tabPage2.Controls.Add(this.lstProducts);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(707, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ShoppingCart";
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTotalCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCost.Font = new System.Drawing.Font("Roboto Cn", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalCost.Location = new System.Drawing.Point(73, 318);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(577, 23);
            this.lblTotalCost.TabIndex = 1;
            this.lblTotalCost.Text = "Total Cost";
            // 
            // lstProducts
            // 
            this.lstProducts.FormattingEnabled = true;
            this.lstProducts.ItemHeight = 15;
            this.lstProducts.Location = new System.Drawing.Point(73, 31);
            this.lstProducts.Name = "lstProducts";
            this.lstProducts.Size = new System.Drawing.Size(577, 274);
            this.lstProducts.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.txtMailingLabel);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(707, 387);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mailing label";
            // 
            // txtMailingLabel
            // 
            this.txtMailingLabel.Enabled = false;
            this.txtMailingLabel.Location = new System.Drawing.Point(72, 53);
            this.txtMailingLabel.Multiline = true;
            this.txtMailingLabel.Name = "txtMailingLabel";
            this.txtMailingLabel.Size = new System.Drawing.Size(566, 255);
            this.txtMailingLabel.TabIndex = 0;
            // 
            // frmShoppingCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmShoppingCart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " | XVI | Shopping Cart | XVI |";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOrderForm.ResumeLayout(false);
            this.tabOrderForm.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOrderForm;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.Label lblItemsOrdered;
        private System.Windows.Forms.Button btnAddToOrder;
        private System.Windows.Forms.DomainUpDown dudProducts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrderAddress;
        private System.Windows.Forms.Label lblTotalCost;
        private System.Windows.Forms.ListBox lstProducts;
        private System.Windows.Forms.TextBox txtMailingLabel;
    }
}

