
namespace QLNGANHANG
{
    partial class frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian
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
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dt_BD = new DevExpress.XtraEditors.DateEdit();
            this.dt_KT = new DevExpress.XtraEditors.DateEdit();
            this.btn_XEM = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dt_BD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_BD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(516, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(913, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAO KÊ GIAO DỊCH CỦA MỘT TÀI KHOẢN TRONG MỘT KHOẢNG THỜI GIAN ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(597, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập số tài khoản ";
            // 
            // txt_TK
            // 
            this.txt_TK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TK.Location = new System.Drawing.Point(800, 236);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(505, 29);
            this.txt_TK.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(683, 336);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1018, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 22);
            this.label4.TabIndex = 4;
            this.label4.Text = "đến ngày";
            // 
            // dt_BD
            // 
            this.dt_BD.EditValue = null;
            this.dt_BD.Location = new System.Drawing.Point(800, 334);
            this.dt_BD.Name = "dt_BD";
            this.dt_BD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_BD.Properties.Appearance.Options.UseFont = true;
            this.dt_BD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_BD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_BD.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dt_BD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_BD.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dt_BD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_BD.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dt_BD.Size = new System.Drawing.Size(163, 28);
            this.dt_BD.TabIndex = 5;
            // 
            // dt_KT
            // 
            this.dt_KT.EditValue = null;
            this.dt_KT.Location = new System.Drawing.Point(1144, 334);
            this.dt_KT.Name = "dt_KT";
            this.dt_KT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dt_KT.Properties.Appearance.Options.UseFont = true;
            this.dt_KT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_KT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dt_KT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dt_KT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_KT.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dt_KT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dt_KT.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dt_KT.Size = new System.Drawing.Size(161, 28);
            this.dt_KT.TabIndex = 6;
            // 
            // btn_XEM
            // 
            this.btn_XEM.BackColor = System.Drawing.Color.Lime;
            this.btn_XEM.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_XEM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_XEM.Location = new System.Drawing.Point(825, 441);
            this.btn_XEM.Name = "btn_XEM";
            this.btn_XEM.Size = new System.Drawing.Size(169, 37);
            this.btn_XEM.TabIndex = 7;
            this.btn_XEM.Text = "XEM BÁO CÁO";
            this.btn_XEM.UseVisualStyleBackColor = false;
            this.btn_XEM.Click += new System.EventHandler(this.btn_XEM_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1093, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1501, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_XEM);
            this.Controls.Add(this.dt_KT);
            this.Controls.Add(this.dt_BD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian";
            this.Text = "SAO KÊ TÀI KHOẢN TRONG MỘT KHOẢNG  THỜI GIAN";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSaoKeGiaoDichTaiKhoanTrongKhangThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dt_BD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_BD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dt_KT.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.DateEdit dt_BD;
        private DevExpress.XtraEditors.DateEdit dt_KT;
        private System.Windows.Forms.Button btn_XEM;
        private System.Windows.Forms.Button button1;
    }
}