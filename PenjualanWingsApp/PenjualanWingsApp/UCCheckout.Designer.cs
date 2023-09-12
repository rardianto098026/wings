namespace PenjualanWingsApp
{
    partial class UCCheckout
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.tbox_qty = new System.Windows.Forms.TextBox();
            this.lbl_unit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_subtotal = new System.Windows.Forms.Label();
            this.pBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(77, 5);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(28, 16);
            this.lbl_title.TabIndex = 10;
            this.lbl_title.Text = "title";
            // 
            // tbox_qty
            // 
            this.tbox_qty.Location = new System.Drawing.Point(80, 25);
            this.tbox_qty.Name = "tbox_qty";
            this.tbox_qty.ReadOnly = true;
            this.tbox_qty.Size = new System.Drawing.Size(38, 20);
            this.tbox_qty.TabIndex = 11;
            // 
            // lbl_unit
            // 
            this.lbl_unit.AutoSize = true;
            this.lbl_unit.Location = new System.Drawing.Point(125, 29);
            this.lbl_unit.Name = "lbl_unit";
            this.lbl_unit.Size = new System.Drawing.Size(28, 13);
            this.lbl_unit.TabIndex = 12;
            this.lbl_unit.Text = "PCS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Subtotal : ";
            // 
            // lbl_subtotal
            // 
            this.lbl_subtotal.AutoSize = true;
            this.lbl_subtotal.Location = new System.Drawing.Point(164, 50);
            this.lbl_subtotal.Name = "lbl_subtotal";
            this.lbl_subtotal.Size = new System.Drawing.Size(82, 13);
            this.lbl_subtotal.TabIndex = 14;
            this.lbl_subtotal.Text = "value_sub_total";
            // 
            // pBox
            // 
            this.pBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.pBox.Location = new System.Drawing.Point(10, 9);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(50, 50);
            this.pBox.TabIndex = 9;
            this.pBox.TabStop = false;
            this.pBox.Click += new System.EventHandler(this.pBox_Click);
            // 
            // UCCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lbl_subtotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_unit);
            this.Controls.Add(this.tbox_qty);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pBox);
            this.Name = "UCCheckout";
            this.Size = new System.Drawing.Size(425, 68);
            this.Load += new System.EventHandler(this.UCCheckout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox tbox_qty;
        private System.Windows.Forms.Label lbl_unit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_subtotal;
    }
}
