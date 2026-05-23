namespace IT_Assesment_Start
{
    partial class OrderForm
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
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvCart = new System.Windows.Forms.DataGridView();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnRemoveFromCart = new System.Windows.Forms.Button();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(28, 59);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowHeadersWidth = 51;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(240, 150);
            this.dgvInventory.TabIndex = 0;
            // 
            // dgvCart
            // 
            this.dgvCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCart.Location = new System.Drawing.Point(456, 59);
            this.dgvCart.Name = "dgvCart";
            this.dgvCart.RowHeadersWidth = 51;
            this.dgvCart.RowTemplate.Height = 24;
            this.dgvCart.Size = new System.Drawing.Size(240, 150);
            this.dgvCart.TabIndex = 1;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(91, 243);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 22);
            this.txtQuantity.TabIndex = 2;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(350, 241);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(75, 23);
            this.btnAddToCart.TabIndex = 3;
            this.btnAddToCart.Text = "button1";
            this.btnAddToCart.UseVisualStyleBackColor = true;
            this.btnAddToCart.Click += new System.EventHandler(this.btnAddToCart_Click);
            // 
            // btnRemoveFromCart
            // 
            this.btnRemoveFromCart.Location = new System.Drawing.Point(350, 271);
            this.btnRemoveFromCart.Name = "btnRemoveFromCart";
            this.btnRemoveFromCart.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveFromCart.TabIndex = 4;
            this.btnRemoveFromCart.Text = "button2";
            this.btnRemoveFromCart.UseVisualStyleBackColor = true;
            this.btnRemoveFromCart.Click += new System.EventHandler(this.btnRemoveFromCart_Click);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(350, 301);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(75, 23);
            this.btnCheckout.TabIndex = 5;
            this.btnCheckout.Text = "button3";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheckout_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(518, 307);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 16);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "label1";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnRemoveFromCart);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.dgvCart);
            this.Controls.Add(this.dgvInventory);
            this.Name = "OrderForm";
            this.Text = "OrderForm";
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvCart;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnRemoveFromCart;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Label lblTotal;
    }
}