
namespace Mo_phong_do_thi.GUI
{
    partial class FrmDijkstraThemCanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDijkstraThemCanh));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbxDinhXP = new DevExpress.XtraEditors.LookUpEdit();
            this.cbxDinhKT = new DevExpress.XtraEditors.LookUpEdit();
            this.txtTrongSo = new DevExpress.XtraEditors.TextEdit();
            this.cbxLoaiCanh = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDinhXP.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDinhKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongSo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiCanh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(94, 17);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(120, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Đỉnh xuất phát :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(94, 47);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(110, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Đỉnh kết thúc :";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(94, 76);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(76, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "Trọng số :";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(94, 105);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(81, 21);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Loại cạnh :";
            // 
            // cbxDinhXP
            // 
            this.cbxDinhXP.Location = new System.Drawing.Point(243, 12);
            this.cbxDinhXP.Name = "cbxDinhXP";
            this.cbxDinhXP.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDinhXP.Properties.Appearance.Options.UseFont = true;
            this.cbxDinhXP.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDinhXP.Properties.NullText = "Chọn đỉnh";
            this.cbxDinhXP.Size = new System.Drawing.Size(275, 24);
            this.cbxDinhXP.TabIndex = 4;
            // 
            // cbxDinhKT
            // 
            this.cbxDinhKT.Location = new System.Drawing.Point(243, 46);
            this.cbxDinhKT.Name = "cbxDinhKT";
            this.cbxDinhKT.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDinhKT.Properties.Appearance.Options.UseFont = true;
            this.cbxDinhKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxDinhKT.Properties.NullText = "Chọn đỉnh";
            this.cbxDinhKT.Size = new System.Drawing.Size(275, 24);
            this.cbxDinhKT.TabIndex = 5;
            // 
            // txtTrongSo
            // 
            this.txtTrongSo.Location = new System.Drawing.Point(243, 76);
            this.txtTrongSo.Name = "txtTrongSo";
            this.txtTrongSo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrongSo.Properties.Appearance.Options.UseFont = true;
            this.txtTrongSo.Size = new System.Drawing.Size(275, 24);
            this.txtTrongSo.TabIndex = 6;
            // 
            // cbxLoaiCanh
            // 
            this.cbxLoaiCanh.Location = new System.Drawing.Point(243, 105);
            this.cbxLoaiCanh.Name = "cbxLoaiCanh";
            this.cbxLoaiCanh.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxLoaiCanh.Properties.Appearance.Options.UseFont = true;
            this.cbxLoaiCanh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbxLoaiCanh.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.cbxLoaiCanh.Size = new System.Drawing.Size(275, 24);
            this.cbxLoaiCanh.TabIndex = 7;
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(578, 12);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(152, 46);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(578, 66);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(152, 46);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // FrmDijkstraThemCanh
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 160);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cbxLoaiCanh);
            this.Controls.Add(this.txtTrongSo);
            this.Controls.Add(this.cbxDinhKT);
            this.Controls.Add(this.cbxDinhXP);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IconOptions.Image = ((System.Drawing.Image)(resources.GetObject("FrmDijkstraThemCanh.IconOptions.Image")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmDijkstraThemCanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Thêm cạnh";
            this.Load += new System.EventHandler(this.FrmDijkstraThemCanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbxDinhXP.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxDinhKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTrongSo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbxLoaiCanh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit cbxDinhXP;
        private DevExpress.XtraEditors.LookUpEdit cbxDinhKT;
        private DevExpress.XtraEditors.TextEdit txtTrongSo;
        private DevExpress.XtraEditors.ComboBoxEdit cbxLoaiCanh;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
    }
}