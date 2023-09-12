namespace PenjualanWingsApp
{
    partial class UCProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_buy = new System.Windows.Forms.Button();
            this.lbl_price_after_discount = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            this.tBox_qty = new System.Windows.Forms.TextBox();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_buy
            // 
            this.btn_buy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btn_buy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buy.ForeColor = System.Drawing.Color.White;
            this.btn_buy.Location = new System.Drawing.Point(353, 15);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(59, 36);
            this.btn_buy.TabIndex = 12;
            this.btn_buy.Text = "BUY";
            this.btn_buy.UseVisualStyleBackColor = false;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // lbl_price_after_discount
            // 
            this.lbl_price_after_discount.AutoSize = true;
            this.lbl_price_after_discount.Location = new System.Drawing.Point(67, 44);
            this.lbl_price_after_discount.Name = "lbl_price_after_discount";
            this.lbl_price_after_discount.Size = new System.Drawing.Size(103, 13);
            this.lbl_price_after_discount.TabIndex = 11;
            this.lbl_price_after_discount.Text = "price_after_discount";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(66, 27);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(30, 13);
            this.lbl_price.TabIndex = 10;
            this.lbl_price.Text = "price";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Location = new System.Drawing.Point(66, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(23, 13);
            this.lbl_title.TabIndex = 9;
            this.lbl_title.Text = "title";
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.pBox.Location = new System.Drawing.Point(10, 9);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(50, 50);
            this.pBox.TabIndex = 8;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            // 
            // tBox_qty
            // 
            this.tBox_qty.Location = new System.Drawing.Point(342, 24);
            this.tBox_qty.Name = "tBox_qty";
            this.tBox_qty.ReadOnly = true;
            this.tBox_qty.Size = new System.Drawing.Size(34, 20);
            this.tBox_qty.TabIndex = 13;
            // 
            // btn_minus
            // 
            this.btn_minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btn_minus.Location = new System.Drawing.Point(310, 23);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(26, 23);
            this.btn_minus.TabIndex = 14;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.btn_minus_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.btn_plus.Location = new System.Drawing.Point(382, 23);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(30, 23);
            this.btn_plus.TabIndex = 15;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.btn_plus_Click);
            // 
            // UCProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.tBox_qty);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.lbl_price_after_discount);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pBox);
            this.Name = "UCProduct";
            this.Size = new System.Drawing.Size(425, 68);
            this.Load += new System.EventHandler(this.UCProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_buy;
        private System.Windows.Forms.Label lbl_price_after_discount;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.TextBox tBox_qty;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn_plus;
    }
}
