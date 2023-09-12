namespace PenjualanWingsApp
{
    partial class Menu
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
            this.btn_buy_product = new System.Windows.Forms.Button();
            this.btn_report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_buy_product
            // 
            this.btn_buy_product.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btn_buy_product.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy_product.ForeColor = System.Drawing.Color.White;
            this.btn_buy_product.Location = new System.Drawing.Point(67, 50);
            this.btn_buy_product.Name = "btn_buy_product";
            this.btn_buy_product.Size = new System.Drawing.Size(130, 33);
            this.btn_buy_product.TabIndex = 0;
            this.btn_buy_product.Text = "BUY PRODUCT";
            this.btn_buy_product.UseVisualStyleBackColor = false;
            this.btn_buy_product.Click += new System.EventHandler(this.btn_buy_product_Click);
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.ForeColor = System.Drawing.Color.White;
            this.btn_report.Location = new System.Drawing.Point(67, 89);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(130, 33);
            this.btn_report.TabIndex = 1;
            this.btn_report.Text = "REPORT";
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "MENU";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(262, 185);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_report);
            this.Controls.Add(this.btn_buy_product);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buy_product;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}