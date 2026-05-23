namespace IT_Assesment_Start
{
    partial class HomeForm
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
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnVisitInventory = new System.Windows.Forms.Button();
            this.btnBuildOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHomePage
            // 
            this.lblHomePage.Font = new System.Drawing.Font("Tempus Sans ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHomePage.Location = new System.Drawing.Point(12, 25);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(759, 81);
            this.lblHomePage.TabIndex = 0;
            this.lblHomePage.Text = " Home Page";
            this.lblHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Tempus Sans ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(34, 51);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 33);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(31, 106);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(185, 318);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome Back, Anjun Feng!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.UseMnemonic = false;
            // 
            // btnVisitInventory
            // 
            this.btnVisitInventory.Font = new System.Drawing.Font("Tempus Sans ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitInventory.Location = new System.Drawing.Point(243, 109);
            this.btnVisitInventory.Name = "btnVisitInventory";
            this.btnVisitInventory.Size = new System.Drawing.Size(147, 23);
            this.btnVisitInventory.TabIndex = 3;
            this.btnVisitInventory.Text = "View Inventory";
            this.btnVisitInventory.UseVisualStyleBackColor = true;
            this.btnVisitInventory.Click += new System.EventHandler(this.btnVisitInventory_Click);
            // 
            // btnBuildOrder
            // 
            this.btnBuildOrder.Font = new System.Drawing.Font("Tempus Sans ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildOrder.Location = new System.Drawing.Point(416, 109);
            this.btnBuildOrder.Name = "btnBuildOrder";
            this.btnBuildOrder.Size = new System.Drawing.Size(147, 23);
            this.btnBuildOrder.TabIndex = 4;
            this.btnBuildOrder.Text = "BuildOrder";
            this.btnBuildOrder.UseVisualStyleBackColor = true;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuildOrder);
            this.Controls.Add(this.btnVisitInventory);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHomePage);
            this.Name = "HomeForm";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnVisitInventory;
        private System.Windows.Forms.Button btnBuildOrder;
    }
}