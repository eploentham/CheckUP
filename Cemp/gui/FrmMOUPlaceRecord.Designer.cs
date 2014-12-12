namespace Cemp.gui
{
    partial class FrmMOUPlaceRecord
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
            this.txtMouNumber = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cboStaffAnalysis = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboStaffPlaceRecord = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpPlaceRecord = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMouNumber);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnPrint);
            this.groupBox1.Controls.Add(this.cboStaffAnalysis);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboStaffPlaceRecord);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtpPlaceRecord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(715, 144);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เก็บตัวอย่าง";
            // 
            // txtMouNumber
            // 
            this.txtMouNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txtMouNumber.Location = new System.Drawing.Point(161, 18);
            this.txtMouNumber.Margin = new System.Windows.Forms.Padding(2);
            this.txtMouNumber.Name = "txtMouNumber";
            this.txtMouNumber.Size = new System.Drawing.Size(200, 23);
            this.txtMouNumber.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label9.Location = new System.Drawing.Point(16, 21);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 62;
            this.label9.Text = "เลขที่ :";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(604, 34);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 39);
            this.btnSave.TabIndex = 61;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(604, 84);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(81, 39);
            this.btnPrint.TabIndex = 60;
            this.btnPrint.Text = "พิมพ์ใบรับตัวอย่าง";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // cboStaffAnalysis
            // 
            this.cboStaffAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboStaffAnalysis.FormattingEnabled = true;
            this.cboStaffAnalysis.Location = new System.Drawing.Point(161, 104);
            this.cboStaffAnalysis.Name = "cboStaffAnalysis";
            this.cboStaffAnalysis.Size = new System.Drawing.Size(231, 24);
            this.cboStaffAnalysis.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(16, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "เจ้าหน้าที่ผู้วิเคราะห์ :";
            // 
            // cboStaffPlaceRecord
            // 
            this.cboStaffPlaceRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboStaffPlaceRecord.FormattingEnabled = true;
            this.cboStaffPlaceRecord.Location = new System.Drawing.Point(161, 74);
            this.cboStaffPlaceRecord.Name = "cboStaffPlaceRecord";
            this.cboStaffPlaceRecord.Size = new System.Drawing.Size(231, 24);
            this.cboStaffPlaceRecord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "วันที่เก็บตัวอย่าง :";
            // 
            // dtpPlaceRecord
            // 
            this.dtpPlaceRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.dtpPlaceRecord.Location = new System.Drawing.Point(161, 46);
            this.dtpPlaceRecord.Name = "dtpPlaceRecord";
            this.dtpPlaceRecord.Size = new System.Drawing.Size(200, 22);
            this.dtpPlaceRecord.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(16, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "เจ้าหน้าที่ผู้เก็บตัวอย่าง :";
            // 
            // FrmMOUPlaceRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 176);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMOUPlaceRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMOUPlaceRecord";
            this.Load += new System.EventHandler(this.FrmMOUPlaceRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboStaffPlaceRecord;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpPlaceRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStaffAnalysis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtMouNumber;
        private System.Windows.Forms.Label label9;
    }
}