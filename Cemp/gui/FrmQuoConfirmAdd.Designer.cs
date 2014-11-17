namespace Cemp.gui
{
    partial class FrmQuoConfirmAdd
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComfirm = new System.Windows.Forms.Button();
            this.btnPicCertify = new System.Windows.Forms.Button();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCust = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.txtQuNumber = new System.Windows.Forms.TextBox();
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.txtQuId = new System.Windows.Forms.TextBox();
            this.chkComfirm = new System.Windows.Forms.RadioButton();
            this.chkNoComfirm = new System.Windows.Forms.RadioButton();
            this.picCertify = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCertify)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNoComfirm);
            this.groupBox1.Controls.Add(this.chkComfirm);
            this.groupBox1.Controls.Add(this.txtQuId);
            this.groupBox1.Controls.Add(this.btnComfirm);
            this.groupBox1.Controls.Add(this.btnPicCertify);
            this.groupBox1.Controls.Add(this.txtNetTotal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtCust);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.txtQuNumber);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(768, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnComfirm
            // 
            this.btnComfirm.Location = new System.Drawing.Point(670, 72);
            this.btnComfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnComfirm.Name = "btnComfirm";
            this.btnComfirm.Size = new System.Drawing.Size(94, 34);
            this.btnComfirm.TabIndex = 48;
            this.btnComfirm.Text = "บันทึก";
            this.btnComfirm.UseVisualStyleBackColor = true;
            this.btnComfirm.Click += new System.EventHandler(this.btnComfirm_Click);
            // 
            // btnPicCertify
            // 
            this.btnPicCertify.Location = new System.Drawing.Point(536, 79);
            this.btnPicCertify.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPicCertify.Name = "btnPicCertify";
            this.btnPicCertify.Size = new System.Drawing.Size(94, 24);
            this.btnPicCertify.TabIndex = 47;
            this.btnPicCertify.Text = "รูปเอกสารยืนยัน";
            this.btnPicCertify.UseVisualStyleBackColor = true;
            this.btnPicCertify.Click += new System.EventHandler(this.btnPicCertify_Click);
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtNetTotal.Location = new System.Drawing.Point(66, 73);
            this.txtNetTotal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.Size = new System.Drawing.Size(141, 23);
            this.txtNetTotal.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label14.Location = new System.Drawing.Point(2, 76);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 17);
            this.label14.TabIndex = 22;
            this.label14.Text = "รวมราคา :";
            // 
            // txtCust
            // 
            this.txtCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCust.Location = new System.Drawing.Point(66, 46);
            this.txtCust.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCust.Name = "txtCust";
            this.txtCust.Size = new System.Drawing.Size(424, 23);
            this.txtCust.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(11, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "ลูกค้า :";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label28.Location = new System.Drawing.Point(11, 23);
            this.label28.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(43, 17);
            this.label28.TabIndex = 25;
            this.label28.Text = "เลขที่ :";
            // 
            // txtQuNumber
            // 
            this.txtQuNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQuNumber.Location = new System.Drawing.Point(66, 17);
            this.txtQuNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQuNumber.Name = "txtQuNumber";
            this.txtQuNumber.Size = new System.Drawing.Size(138, 23);
            this.txtQuNumber.TabIndex = 24;
            // 
            // dgvView
            // 
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(9, 124);
            this.dgvView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(768, 468);
            this.dgvView.TabIndex = 3;
            // 
            // txtQuId
            // 
            this.txtQuId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtQuId.Location = new System.Drawing.Point(208, 17);
            this.txtQuId.Margin = new System.Windows.Forms.Padding(2);
            this.txtQuId.Name = "txtQuId";
            this.txtQuId.Size = new System.Drawing.Size(38, 23);
            this.txtQuId.TabIndex = 49;
            this.txtQuId.Visible = false;
            // 
            // chkComfirm
            // 
            this.chkComfirm.AutoSize = true;
            this.chkComfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkComfirm.Location = new System.Drawing.Point(266, 81);
            this.chkComfirm.Name = "chkComfirm";
            this.chkComfirm.Size = new System.Drawing.Size(52, 20);
            this.chkComfirm.TabIndex = 50;
            this.chkComfirm.TabStop = true;
            this.chkComfirm.Text = "ยืนยัน";
            this.chkComfirm.UseVisualStyleBackColor = true;
            this.chkComfirm.Click += new System.EventHandler(this.chkComfirm_Click);
            // 
            // chkNoComfirm
            // 
            this.chkNoComfirm.AutoSize = true;
            this.chkNoComfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkNoComfirm.Location = new System.Drawing.Point(390, 81);
            this.chkNoComfirm.Name = "chkNoComfirm";
            this.chkNoComfirm.Size = new System.Drawing.Size(88, 20);
            this.chkNoComfirm.TabIndex = 51;
            this.chkNoComfirm.TabStop = true;
            this.chkNoComfirm.Text = "ลูกค้าไม่ยืนยัน";
            this.chkNoComfirm.UseVisualStyleBackColor = true;
            this.chkNoComfirm.Click += new System.EventHandler(this.chkNoComfirm_Click);
            // 
            // picCertify
            // 
            this.picCertify.Location = new System.Drawing.Point(783, 13);
            this.picCertify.Name = "picCertify";
            this.picCertify.Size = new System.Drawing.Size(489, 579);
            this.picCertify.TabIndex = 4;
            this.picCertify.TabStop = false;
            // 
            // FrmQuoConfirmAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 603);
            this.Controls.Add(this.picCertify);
            this.Controls.Add(this.dgvView);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmQuoConfirmAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuoApproveAdd";
            this.Load += new System.EventHandler(this.FrmQuoConfirmAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCertify)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtQuNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCust;
        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPicCertify;
        private System.Windows.Forms.Button btnComfirm;
        private System.Windows.Forms.TextBox txtQuId;
        private System.Windows.Forms.RadioButton chkNoComfirm;
        private System.Windows.Forms.RadioButton chkComfirm;
        private System.Windows.Forms.PictureBox picCertify;
    }
}