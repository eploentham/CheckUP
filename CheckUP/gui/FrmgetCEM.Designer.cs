namespace CheckUP.gui
{
    partial class FrmgetCEM
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
            this.chkDate = new System.Windows.Forms.CheckBox();
            this.chk64Bit = new System.Windows.Forms.CheckBox();
            this.txtDateEnd = new C1.Win.Calendar.C1DateEdit();
            this.txtDateStart = new C1.Win.Calendar.C1DateEdit();
            this.btnPath = new C1.Win.C1Input.C1Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPath = new C1.Win.C1Input.C1TextBox();
            this.btnGen = new C1.Win.C1Input.C1Button();
            this.btnRetrive = new C1.Win.C1Input.C1Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNoEnd = new C1.Win.C1Input.C1NumericEdit();
            this.txtNoStart = new C1.Win.C1Input.C1NumericEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoStart)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkDate);
            this.groupBox1.Controls.Add(this.chk64Bit);
            this.groupBox1.Controls.Add(this.txtDateEnd);
            this.groupBox1.Controls.Add(this.txtDateStart);
            this.groupBox1.Controls.Add(this.btnPath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnGen);
            this.groupBox1.Controls.Add(this.btnRetrive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNoEnd);
            this.groupBox1.Controls.Add(this.txtNoStart);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(827, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เงื่อนไข";
            // 
            // chkDate
            // 
            this.chkDate.AutoSize = true;
            this.chkDate.Location = new System.Drawing.Point(561, 56);
            this.chkDate.Name = "chkDate";
            this.chkDate.Size = new System.Drawing.Size(86, 17);
            this.chkDate.TabIndex = 15;
            this.chkDate.Text = "dd/MM/yyyy";
            this.chkDate.UseVisualStyleBackColor = true;
            // 
            // chk64Bit
            // 
            this.chk64Bit.AutoSize = true;
            this.chk64Bit.Location = new System.Drawing.Point(561, 37);
            this.chk64Bit.Name = "chk64Bit";
            this.chk64Bit.Size = new System.Drawing.Size(52, 17);
            this.chk64Bit.TabIndex = 11;
            this.chk64Bit.Text = "64 bit";
            this.chk64Bit.UseVisualStyleBackColor = true;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.AllowSpinLoop = false;
            this.txtDateEnd.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.txtDateEnd.Culture = 1054;
            this.txtDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateEnd.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.txtDateEnd.ImagePadding = new System.Windows.Forms.Padding(0);
            this.txtDateEnd.Location = new System.Drawing.Point(362, 34);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(111, 20);
            this.txtDateEnd.TabIndex = 14;
            this.txtDateEnd.Tag = null;
            // 
            // txtDateStart
            // 
            this.txtDateStart.AllowSpinLoop = false;
            this.txtDateStart.Calendar.RightToLeft = System.Windows.Forms.RightToLeft.Inherit;
            this.txtDateStart.Culture = 1054;
            this.txtDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateStart.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.txtDateStart.ImagePadding = new System.Windows.Forms.Padding(0);
            this.txtDateStart.Location = new System.Drawing.Point(93, 34);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(111, 20);
            this.txtDateStart.TabIndex = 11;
            this.txtDateStart.Tag = null;
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(478, 10);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(31, 23);
            this.btnPath.TabIndex = 13;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "path Data";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPath.Location = new System.Drawing.Point(93, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(379, 20);
            this.txtPath.TabIndex = 11;
            this.txtPath.Tag = null;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(657, 52);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 9;
            this.btnGen.Text = "gen Text";
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // btnRetrive
            // 
            this.btnRetrive.Location = new System.Drawing.Point(657, 19);
            this.btnRetrive.Name = "btnRetrive";
            this.btnRetrive.Size = new System.Drawing.Size(75, 23);
            this.btnRetrive.TabIndex = 1;
            this.btnRetrive.Text = "ดึงข้อมูล";
            this.btnRetrive.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ลำดับสิ้นสุด";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(297, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "วันที่สิ้นสุด";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "ลำดับเริ่นต้น";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "วันที่เริ่มต้น";
            // 
            // txtNoEnd
            // 
            this.txtNoEnd.DataType = typeof(short);
            this.txtNoEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoEnd.ImagePadding = new System.Windows.Forms.Padding(0);
            this.txtNoEnd.Location = new System.Drawing.Point(362, 56);
            this.txtNoEnd.Name = "txtNoEnd";
            this.txtNoEnd.Size = new System.Drawing.Size(111, 20);
            this.txtNoEnd.TabIndex = 4;
            this.txtNoEnd.Tag = null;
            // 
            // txtNoStart
            // 
            this.txtNoStart.DataType = typeof(short);
            this.txtNoStart.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Integer;
            this.txtNoStart.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.txtNoStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoStart.ImagePadding = new System.Windows.Forms.Padding(0);
            this.txtNoStart.Location = new System.Drawing.Point(93, 56);
            this.txtNoStart.Name = "txtNoStart";
            this.txtNoStart.Size = new System.Drawing.Size(111, 20);
            this.txtNoStart.TabIndex = 3;
            this.txtNoStart.Tag = null;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 473);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(312, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(940, 473);
            this.panel2.TabIndex = 10;
            // 
            // FrmgetCEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmgetCEM";
            this.Text = "FrmgetCEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmgetCEM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDateStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNoStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1Input.C1NumericEdit txtNoEnd;
        private C1.Win.C1Input.C1NumericEdit txtNoStart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private C1.Win.C1Input.C1Button btnRetrive;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private C1.Win.C1Input.C1Button btnGen;
        private System.Windows.Forms.Label label5;
        private C1.Win.C1Input.C1TextBox txtPath;
        private C1.Win.C1Input.C1Button btnPath;
        private C1.Win.C1Input.C1DateEdit c1DateEdit1;
        private C1.Win.C1Input.C1DateEdit c1DateEdit2;
        private C1.Win.Calendar.C1DateEdit txtDateEnd;
        private C1.Win.Calendar.C1DateEdit txtDateStart;
        private System.Windows.Forms.CheckBox chk64Bit;
        private System.Windows.Forms.CheckBox chkDate;
    }
}