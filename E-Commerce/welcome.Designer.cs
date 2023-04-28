namespace E_Commerce
{
    partial class welcome
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
            this.cartbtn = new System.Windows.Forms.Button();
            this.profilebtn = new System.Windows.Forms.Button();
            this.balancebtn = new System.Windows.Forms.Button();
            this.reviewbtn = new System.Windows.Forms.Button();
            this.orderstatbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cartbtn
            // 
            this.cartbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cartbtn.Location = new System.Drawing.Point(29, 101);
            this.cartbtn.Name = "cartbtn";
            this.cartbtn.Size = new System.Drawing.Size(182, 65);
            this.cartbtn.TabIndex = 1;
            this.cartbtn.Text = "Cart";
            this.cartbtn.UseVisualStyleBackColor = true;
            this.cartbtn.Click += new System.EventHandler(this.cartbtn_Click);
            // 
            // profilebtn
            // 
            this.profilebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profilebtn.Location = new System.Drawing.Point(29, 12);
            this.profilebtn.Name = "profilebtn";
            this.profilebtn.Size = new System.Drawing.Size(182, 65);
            this.profilebtn.TabIndex = 2;
            this.profilebtn.Text = "Profile";
            this.profilebtn.UseVisualStyleBackColor = true;
            this.profilebtn.Click += new System.EventHandler(this.profilebtn_Click);
            // 
            // balancebtn
            // 
            this.balancebtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.balancebtn.Location = new System.Drawing.Point(29, 187);
            this.balancebtn.Name = "balancebtn";
            this.balancebtn.Size = new System.Drawing.Size(182, 65);
            this.balancebtn.TabIndex = 3;
            this.balancebtn.Text = "Balance";
            this.balancebtn.UseVisualStyleBackColor = true;
            this.balancebtn.Click += new System.EventHandler(this.balancebtn_Click);
            // 
            // reviewbtn
            // 
            this.reviewbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reviewbtn.Location = new System.Drawing.Point(29, 278);
            this.reviewbtn.Name = "reviewbtn";
            this.reviewbtn.Size = new System.Drawing.Size(182, 65);
            this.reviewbtn.TabIndex = 4;
            this.reviewbtn.Text = "Review";
            this.reviewbtn.UseVisualStyleBackColor = true;
            this.reviewbtn.Click += new System.EventHandler(this.reviewbtn_Click);
            // 
            // orderstatbtn
            // 
            this.orderstatbtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderstatbtn.Location = new System.Drawing.Point(29, 370);
            this.orderstatbtn.Name = "orderstatbtn";
            this.orderstatbtn.Size = new System.Drawing.Size(182, 65);
            this.orderstatbtn.TabIndex = 5;
            this.orderstatbtn.Text = "Order Status";
            this.orderstatbtn.UseVisualStyleBackColor = true;
            this.orderstatbtn.Click += new System.EventHandler(this.orderstatbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(282, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome to DESHI DOSH";
            // 
            // welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 553);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.orderstatbtn);
            this.Controls.Add(this.reviewbtn);
            this.Controls.Add(this.balancebtn);
            this.Controls.Add(this.profilebtn);
            this.Controls.Add(this.cartbtn);
            this.Name = "welcome";
            this.Text = "welcome";
            this.Load += new System.EventHandler(this.welcome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cartbtn;
        private System.Windows.Forms.Button profilebtn;
        private System.Windows.Forms.Button balancebtn;
        private System.Windows.Forms.Button reviewbtn;
        private System.Windows.Forms.Button orderstatbtn;
        private System.Windows.Forms.Label label1;
    }
}