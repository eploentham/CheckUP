namespace Cemp.gui
{
    partial class FrmResultAdd
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
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboCust = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtResultId = new System.Windows.Forms.TextBox();
            this.txtMachinery = new System.Windows.Forms.RichTextBox();
            this.cboMachinery = new System.Windows.Forms.ComboBox();
            this.cboMOU = new System.Windows.Forms.ComboBox();
            this.dtpDateResult = new System.Windows.Forms.DateTimePicker();
            this.txtMeasurement = new System.Windows.Forms.RichTextBox();
            this.cboMesaurement = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCompName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dgvResult = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.RichTextBox();
            this.btnUnActive = new System.Windows.Forms.Button();
            this.ChkUnActive = new System.Windows.Forms.RadioButton();
            this.chkActive = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "MOU :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboCust);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtResultId);
            this.groupBox1.Controls.Add(this.txtMachinery);
            this.groupBox1.Controls.Add(this.cboMachinery);
            this.groupBox1.Controls.Add(this.cboMOU);
            this.groupBox1.Controls.Add(this.dtpDateResult);
            this.groupBox1.Controls.Add(this.txtMeasurement);
            this.groupBox1.Controls.Add(this.cboMesaurement);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCompName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCustAddress);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(570, 546);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // cboCust
            // 
            this.cboCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboCust.FormattingEnabled = true;
            this.cboCust.Location = new System.Drawing.Point(123, 23);
            this.cboCust.Margin = new System.Windows.Forms.Padding(2);
            this.cboCust.Name = "cboCust";
            this.cboCust.Size = new System.Drawing.Size(370, 25);
            this.cboCust.TabIndex = 139;
            this.cboCust.SelectedIndexChanged += new System.EventHandler(this.cboCust_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(8, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 138;
            this.label9.Text = "บริษัท :";
            // 
            // txtResultId
            // 
            this.txtResultId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtResultId.Location = new System.Drawing.Point(455, 137);
            this.txtResultId.Margin = new System.Windows.Forms.Padding(2);
            this.txtResultId.Name = "txtResultId";
            this.txtResultId.Size = new System.Drawing.Size(38, 23);
            this.txtResultId.TabIndex = 136;
            this.txtResultId.Visible = false;
            // 
            // txtMachinery
            // 
            this.txtMachinery.Location = new System.Drawing.Point(123, 230);
            this.txtMachinery.Margin = new System.Windows.Forms.Padding(2);
            this.txtMachinery.Name = "txtMachinery";
            this.txtMachinery.Size = new System.Drawing.Size(429, 127);
            this.txtMachinery.TabIndex = 132;
            this.txtMachinery.Text = "";
            // 
            // cboMachinery
            // 
            this.cboMachinery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboMachinery.FormattingEnabled = true;
            this.cboMachinery.Location = new System.Drawing.Point(123, 201);
            this.cboMachinery.Margin = new System.Windows.Forms.Padding(2);
            this.cboMachinery.Name = "cboMachinery";
            this.cboMachinery.Size = new System.Drawing.Size(370, 25);
            this.cboMachinery.TabIndex = 131;
            // 
            // cboMOU
            // 
            this.cboMOU.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboMOU.FormattingEnabled = true;
            this.cboMOU.Location = new System.Drawing.Point(123, 52);
            this.cboMOU.Margin = new System.Windows.Forms.Padding(2);
            this.cboMOU.Name = "cboMOU";
            this.cboMOU.Size = new System.Drawing.Size(370, 25);
            this.cboMOU.TabIndex = 130;
            this.cboMOU.SelectedIndexChanged += new System.EventHandler(this.cboMOU_SelectedIndexChanged);
            // 
            // dtpDateResult
            // 
            this.dtpDateResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpDateResult.Location = new System.Drawing.Point(123, 137);
            this.dtpDateResult.Margin = new System.Windows.Forms.Padding(2);
            this.dtpDateResult.Name = "dtpDateResult";
            this.dtpDateResult.Size = new System.Drawing.Size(106, 23);
            this.dtpDateResult.TabIndex = 129;
            // 
            // txtMeasurement
            // 
            this.txtMeasurement.Location = new System.Drawing.Point(122, 390);
            this.txtMeasurement.Margin = new System.Windows.Forms.Padding(2);
            this.txtMeasurement.Name = "txtMeasurement";
            this.txtMeasurement.Size = new System.Drawing.Size(430, 107);
            this.txtMeasurement.TabIndex = 48;
            this.txtMeasurement.Text = "";
            // 
            // cboMesaurement
            // 
            this.cboMesaurement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboMesaurement.FormattingEnabled = true;
            this.cboMesaurement.Location = new System.Drawing.Point(123, 361);
            this.cboMesaurement.Margin = new System.Windows.Forms.Padding(2);
            this.cboMesaurement.Name = "cboMesaurement";
            this.cboMesaurement.Size = new System.Drawing.Size(298, 25);
            this.cboMesaurement.TabIndex = 47;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(0, 361);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 46;
            this.label6.Text = "วิธีการตรวจวัด :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(8, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 45;
            this.label4.Text = "เครื่องมือ :";
            // 
            // txtCompName
            // 
            this.txtCompName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCompName.Location = new System.Drawing.Point(123, 164);
            this.txtCompName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCompName.Name = "txtCompName";
            this.txtCompName.Size = new System.Drawing.Size(370, 23);
            this.txtCompName.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(8, 163);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "ตรวจวัดโดย :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(8, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "วันที่ตรวจวัด :";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtCustAddress.Location = new System.Drawing.Point(123, 110);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(370, 23);
            this.txtCustAddress.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(8, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "ที่อยู่1 :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1032, 14);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 39);
            this.btnSave.TabIndex = 135;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(1178, 14);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 39);
            this.btnPrint.TabIndex = 134;
            this.btnPrint.Text = "พิมพ์ Result";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dgvResult
            // 
            this.dgvResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResult.Location = new System.Drawing.Point(583, 57);
            this.dgvResult.Margin = new System.Windows.Forms.Padding(2);
            this.dgvResult.Name = "dgvResult";
            this.dgvResult.RowTemplate.Height = 24;
            this.dgvResult.Size = new System.Drawing.Size(714, 461);
            this.dgvResult.TabIndex = 133;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(583, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 17);
            this.label7.TabIndex = 49;
            this.label7.Text = "ผลการตรวจวัด :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label8.Location = new System.Drawing.Point(9, 573);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 17);
            this.label8.TabIndex = 50;
            this.label8.Text = "สรุปผลการตรวจวัด :";
            // 
            // txtSummary
            // 
            this.txtSummary.Location = new System.Drawing.Point(122, 573);
            this.txtSummary.Margin = new System.Windows.Forms.Padding(2);
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(457, 99);
            this.txtSummary.TabIndex = 51;
            this.txtSummary.Text = "";
            // 
            // btnUnActive
            // 
            this.btnUnActive.Location = new System.Drawing.Point(914, 22);
            this.btnUnActive.Name = "btnUnActive";
            this.btnUnActive.Size = new System.Drawing.Size(86, 23);
            this.btnUnActive.TabIndex = 138;
            this.btnUnActive.Text = "ยกเลิกการใช้งาน";
            this.btnUnActive.UseVisualStyleBackColor = true;
            this.btnUnActive.Click += new System.EventHandler(this.btnUnActive_Click);
            // 
            // ChkUnActive
            // 
            this.ChkUnActive.AutoSize = true;
            this.ChkUnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ChkUnActive.Location = new System.Drawing.Point(852, 22);
            this.ChkUnActive.Margin = new System.Windows.Forms.Padding(2);
            this.ChkUnActive.Name = "ChkUnActive";
            this.ChkUnActive.Size = new System.Drawing.Size(60, 21);
            this.ChkUnActive.TabIndex = 137;
            this.ChkUnActive.TabStop = true;
            this.ChkUnActive.Text = "ยกเลิก";
            this.ChkUnActive.UseVisualStyleBackColor = true;
            this.ChkUnActive.Click += new System.EventHandler(this.ChkUnActive_Click);
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkActive.Location = new System.Drawing.Point(768, 22);
            this.chkActive.Margin = new System.Windows.Forms.Padding(2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(61, 21);
            this.chkActive.TabIndex = 136;
            this.chkActive.TabStop = true;
            this.chkActive.Text = "ใช้งาน";
            this.chkActive.UseVisualStyleBackColor = true;
            this.chkActive.Click += new System.EventHandler(this.chkActive_Click);
            // 
            // FrmResultAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1308, 786);
            this.Controls.Add(this.btnUnActive);
            this.Controls.Add(this.ChkUnActive);
            this.Controls.Add(this.chkActive);
            this.Controls.Add(this.txtSummary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvResult);
            this.Controls.Add(this.label7);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmResultAdd";
            this.Text = "FrmResultAdd";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmResultAdd_Load);
            this.Resize += new System.EventHandler(this.FrmResultAdd_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCompName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox txtMeasurement;
        private System.Windows.Forms.ComboBox cboMesaurement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtSummary;
        private System.Windows.Forms.DateTimePicker dtpDateResult;
        private System.Windows.Forms.ComboBox cboMOU;
        private System.Windows.Forms.RichTextBox txtMachinery;
        private System.Windows.Forms.ComboBox cboMachinery;
        private System.Windows.Forms.DataGridView dgvResult;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtResultId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboCust;
        private System.Windows.Forms.Button btnUnActive;
        private System.Windows.Forms.RadioButton ChkUnActive;
        private System.Windows.Forms.RadioButton chkActive;
    }
}