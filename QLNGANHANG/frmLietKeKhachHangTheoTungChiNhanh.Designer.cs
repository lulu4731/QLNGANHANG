
namespace QLNGANHANG
{
    partial class frmLietKeKhachHangTheoTungChiNhanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_CN = new System.Windows.Forms.ComboBox();
            this.btn_XEM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 156);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "LIỆT KÊ KHÁCH HÀNH THEO TỪNG CHI NHÁNH ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(638, 289);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn chi nhánh";
            // 
            // cmb_CN
            // 
            this.cmb_CN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_CN.FormattingEnabled = true;
            this.cmb_CN.Location = new System.Drawing.Point(876, 287);
            this.cmb_CN.Margin = new System.Windows.Forms.Padding(5);
            this.cmb_CN.Name = "cmb_CN";
            this.cmb_CN.Size = new System.Drawing.Size(399, 29);
            this.cmb_CN.TabIndex = 2;
            this.cmb_CN.SelectedIndexChanged += new System.EventHandler(this.cmb_CN_SelectedIndexChanged);
            // 
            // btn_XEM
            // 
            this.btn_XEM.BackColor = System.Drawing.Color.Lime;
            this.btn_XEM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XEM.Location = new System.Drawing.Point(775, 436);
            this.btn_XEM.Margin = new System.Windows.Forms.Padding(5);
            this.btn_XEM.Name = "btn_XEM";
            this.btn_XEM.Size = new System.Drawing.Size(166, 37);
            this.btn_XEM.TabIndex = 3;
            this.btn_XEM.Text = "XEM BÁO CÁO";
            this.btn_XEM.UseVisualStyleBackColor = false;
            this.btn_XEM.Click += new System.EventHandler(this.btn_XEM_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(1028, 436);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLietKeKhachHangTheoTungChiNhanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1501, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_XEM);
            this.Controls.Add(this.cmb_CN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLietKeKhachHangTheoTungChiNhanh";
            this.Text = "LIỆT KÊ KHÁCH HÀNG";
            this.Load += new System.EventHandler(this.frmLietKeKhachHangTheoTungChiNhanh_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_CN;
        private System.Windows.Forms.Button btn_XEM;
        private System.Windows.Forms.Button button1;
    }
}