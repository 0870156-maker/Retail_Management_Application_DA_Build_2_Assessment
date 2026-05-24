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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.lblHomePage = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnVisitInventory = new System.Windows.Forms.Button();
            this.btnBuildOrder = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRevenue = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHomePage
            // 
            this.lblHomePage.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblHomePage.Font = new System.Drawing.Font("Tempus Sans ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHomePage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHomePage.Location = new System.Drawing.Point(16, 24);
            this.lblHomePage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHomePage.Name = "lblHomePage";
            this.lblHomePage.Size = new System.Drawing.Size(1496, 131);
            this.lblHomePage.TabIndex = 0;
            this.lblHomePage.Text = " Home Page";
            this.lblHomePage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnLogout.Font = new System.Drawing.Font("Tempus Sans ITC", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(104, 53);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(95, 80);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblWelcome.Font = new System.Drawing.Font("Tempus Sans ITC", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(18, 165);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(350, 297);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "Welcome Back, Anjun Feng!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblWelcome.UseMnemonic = false;
            // 
            // btnVisitInventory
            // 
            this.btnVisitInventory.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnVisitInventory.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVisitInventory.Location = new System.Drawing.Point(383, 165);
            this.btnVisitInventory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVisitInventory.Name = "btnVisitInventory";
            this.btnVisitInventory.Size = new System.Drawing.Size(280, 80);
            this.btnVisitInventory.TabIndex = 3;
            this.btnVisitInventory.Text = "View Inventory";
            this.btnVisitInventory.UseVisualStyleBackColor = false;
            this.btnVisitInventory.Click += new System.EventHandler(this.btnVisitInventory_Click);
            // 
            // btnBuildOrder
            // 
            this.btnBuildOrder.BackColor = System.Drawing.Color.LavenderBlush;
            this.btnBuildOrder.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuildOrder.Location = new System.Drawing.Point(667, 165);
            this.btnBuildOrder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuildOrder.Name = "btnBuildOrder";
            this.btnBuildOrder.Size = new System.Drawing.Size(278, 80);
            this.btnBuildOrder.TabIndex = 4;
            this.btnBuildOrder.Text = "Build Order";
            this.btnBuildOrder.UseVisualStyleBackColor = false;
            this.btnBuildOrder.Click += new System.EventHandler(this.btnBuildOrder_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 478);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1512, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblRevenue
            // 
            this.lblRevenue.BackColor = System.Drawing.Color.LavenderBlush;
            this.lblRevenue.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenue.Location = new System.Drawing.Point(949, 165);
            this.lblRevenue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRevenue.Name = "lblRevenue";
            this.lblRevenue.Size = new System.Drawing.Size(283, 80);
            this.lblRevenue.TabIndex = 6;
            this.lblRevenue.Text = "Revenue";
            this.lblRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(1155, 686);
            this.Controls.Add(this.lblRevenue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuildOrder);
            this.Controls.Add(this.btnVisitInventory);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblHomePage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "HomeForm";
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHomePage;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnVisitInventory;
        private System.Windows.Forms.Button btnBuildOrder;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRevenue;
    }
}