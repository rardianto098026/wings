namespace PenjualanWingsApp
{
    partial class ReportPenjualan
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.tbox_transaction = new System.Windows.Forms.TextBox();
            this.tbox_user = new System.Windows.Forms.TextBox();
            this.tbox_item = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.tbox_total = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_export = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkBox_datetimepicker = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(789, 269);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "REPORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Search : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Transaction : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "User : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(313, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Item : ";
            // 
            // tbox_search
            // 
            this.tbox_search.Location = new System.Drawing.Point(136, 38);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(150, 20);
            this.tbox_search.TabIndex = 7;
            this.tbox_search.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_search_KeyDown);
            // 
            // tbox_transaction
            // 
            this.tbox_transaction.Location = new System.Drawing.Point(136, 64);
            this.tbox_transaction.Name = "tbox_transaction";
            this.tbox_transaction.Size = new System.Drawing.Size(150, 20);
            this.tbox_transaction.TabIndex = 8;
            this.tbox_transaction.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_transaction_KeyDown);
            // 
            // tbox_user
            // 
            this.tbox_user.Location = new System.Drawing.Point(136, 90);
            this.tbox_user.Name = "tbox_user";
            this.tbox_user.Size = new System.Drawing.Size(150, 20);
            this.tbox_user.TabIndex = 9;
            this.tbox_user.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_user_KeyDown);
            // 
            // tbox_item
            // 
            this.tbox_item.Location = new System.Drawing.Point(356, 64);
            this.tbox_item.Name = "tbox_item";
            this.tbox_item.Size = new System.Drawing.Size(200, 20);
            this.tbox_item.TabIndex = 11;
            this.tbox_item.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_item_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(610, 53);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(166, 40);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "SEARCH";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // tbox_total
            // 
            this.tbox_total.Location = new System.Drawing.Point(356, 38);
            this.tbox_total.Name = "tbox_total";
            this.tbox_total.Size = new System.Drawing.Size(200, 20);
            this.tbox_total.TabIndex = 14;
            this.tbox_total.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_total_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(310, 40);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total :";
            // 
            // btn_export
            // 
            this.btn_export.Location = new System.Drawing.Point(726, 412);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(75, 23);
            this.btn_export.TabIndex = 15;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.btn_export_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 412);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(52, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "logout";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(313, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Date : ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(356, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // chkBox_datetimepicker
            // 
            this.chkBox_datetimepicker.AutoSize = true;
            this.chkBox_datetimepicker.Location = new System.Drawing.Point(563, 93);
            this.chkBox_datetimepicker.Name = "chkBox_datetimepicker";
            this.chkBox_datetimepicker.Size = new System.Drawing.Size(15, 14);
            this.chkBox_datetimepicker.TabIndex = 19;
            this.chkBox_datetimepicker.UseVisualStyleBackColor = true;
            this.chkBox_datetimepicker.CheckedChanged += new System.EventHandler(this.chkBox_datetimepicker_CheckedChanged);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(12, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReportPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(813, 447);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.chkBox_datetimepicker);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.tbox_total);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.tbox_item);
            this.Controls.Add(this.tbox_user);
            this.Controls.Add(this.tbox_transaction);
            this.Controls.Add(this.tbox_search);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportPenjualan";
            this.Load += new System.EventHandler(this.ReportPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.TextBox tbox_transaction;
        private System.Windows.Forms.TextBox tbox_user;
        private System.Windows.Forms.TextBox tbox_item;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox tbox_total;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chkBox_datetimepicker;
        private System.Windows.Forms.Button button2;
    }
}