
namespace QLNGANHANG
{
    partial class frmLietKeTaiKhoanTrongMotKhoangThoiGian
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
            this.dateEdit_KT = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Xem = new System.Windows.Forms.Button();
            this.dateEdit_BD = new DevExpress.XtraEditors.DateEdit();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_KT.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_KT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_BD.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_BD.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dateEdit_KT
            // 
            this.dateEdit_KT.EditValue = null;
            this.dateEdit_KT.Location = new System.Drawing.Point(1123, 288);
            this.dateEdit_KT.Margin = new System.Windows.Forms.Padding(5);
            this.dateEdit_KT.Name = "dateEdit_KT";
            this.dateEdit_KT.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_KT.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_KT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_KT.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_KT.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEdit_KT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_KT.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEdit_KT.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_KT.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit_KT.Size = new System.Drawing.Size(167, 28);
            this.dateEdit_KT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(510, 129);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(780, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "LIỆT KÊ TÀI KHOẢN MỞ TRONG MỘT KHOẢNG THỜI GIAN CỦA CHI NHÁNH";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 291);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trong khoảng thời gian từ ngày";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1016, 291);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "đến ngày";
            // 
            // btn_Xem
            // 
            this.btn_Xem.BackColor = System.Drawing.Color.Lime;
            this.btn_Xem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xem.Location = new System.Drawing.Point(731, 437);
            this.btn_Xem.Margin = new System.Windows.Forms.Padding(5);
            this.btn_Xem.Name = "btn_Xem";
            this.btn_Xem.Size = new System.Drawing.Size(167, 37);
            this.btn_Xem.TabIndex = 8;
            this.btn_Xem.Text = "XEM BÁO CÁO";
            this.btn_Xem.UseVisualStyleBackColor = false;
            this.btn_Xem.Click += new System.EventHandler(this.btn_Xem_Click);
            // 
            // dateEdit_BD
            // 
            this.dateEdit_BD.EditValue = null;
            this.dateEdit_BD.Location = new System.Drawing.Point(814, 287);
            this.dateEdit_BD.Margin = new System.Windows.Forms.Padding(5);
            this.dateEdit_BD.Name = "dateEdit_BD";
            this.dateEdit_BD.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateEdit_BD.Properties.Appearance.Options.UseFont = true;
            this.dateEdit_BD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_BD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit_BD.Properties.DisplayFormat.FormatString = "dd/MM/yyyy";
            this.dateEdit_BD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_BD.Properties.EditFormat.FormatString = "dd/MM/yyyy";
            this.dateEdit_BD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dateEdit_BD.Properties.Mask.EditMask = "dd/MM/yyyy";
            this.dateEdit_BD.Size = new System.Drawing.Size(172, 28);
            this.dateEdit_BD.TabIndex = 9;
            this.dateEdit_BD.EditValueChanged += new System.EventHandler(this.dateEdit_BD_EditValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1020, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 37);
            this.button1.TabIndex = 10;
            this.button1.Text = "THOÁT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLietKeTaiKhoanTrongMotKhoangThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1501, 570);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateEdit_BD);
            this.Controls.Add(this.btn_Xem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateEdit_KT);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmLietKeTaiKhoanTrongMotKhoangThoiGian";
            this.Text = "LIỆT KÊ TÀI KHOẢN";
            this.Load += new System.EventHandler(this.frmLietKeTaiKhoanTrongMotKhoangThoiGian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_KT.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_KT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_BD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit_BD.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.DateEdit dateEdit_KT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Xem;
        private DevExpress.XtraEditors.DateEdit dateEdit_BD;
        private System.Windows.Forms.Button button1;
    }
}