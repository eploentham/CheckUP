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
            this.c1NumericEdit1 = new C1.Win.C1Input.C1NumericEdit();
            this.c1NumericEdit2 = new C1.Win.C1Input.C1NumericEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRetrive = new C1.Win.C1Input.C1Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnGen = new C1.Win.C1Input.C1Button();
            this.txtPath = new C1.Win.C1Input.C1TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPath = new C1.Win.C1Input.C1Button();
            this.c1DateEdit1 = new C1.Win.C1Input.C1DateEdit();
            this.c1DateEdit2 = new C1.Win.C1Input.C1DateEdit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.c1DateEdit2);
            this.groupBox1.Controls.Add(this.c1DateEdit1);
            this.groupBox1.Controls.Add(this.btnPath);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtPath);
            this.groupBox1.Controls.Add(this.btnGen);
            this.groupBox1.Controls.Add(this.btnRetrive);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.c1NumericEdit2);
            this.groupBox1.Controls.Add(this.c1NumericEdit1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 81);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เงื่อนไข";
            // 
            // c1NumericEdit1
            // 
            this.c1NumericEdit1.DataType = typeof(short);
            this.c1NumericEdit1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.Integer;
            this.c1NumericEdit1.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText) 
            | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) 
            | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd) 
            | C1.Win.C1Input.FormatInfoInheritFlags.CalendarType)));
            this.c1NumericEdit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1NumericEdit1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1NumericEdit1.Location = new System.Drawing.Point(93, 56);
            this.c1NumericEdit1.Name = "c1NumericEdit1";
            this.c1NumericEdit1.Size = new System.Drawing.Size(111, 20);
            this.c1NumericEdit1.TabIndex = 3;
            this.c1NumericEdit1.Tag = null;
            // 
            // c1NumericEdit2
            // 
            this.c1NumericEdit2.DataType = typeof(short);
            this.c1NumericEdit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1NumericEdit2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1NumericEdit2.Location = new System.Drawing.Point(306, 56);
            this.c1NumericEdit2.Name = "c1NumericEdit2";
            this.c1NumericEdit2.Size = new System.Drawing.Size(111, 20);
            this.c1NumericEdit2.TabIndex = 4;
            this.c1NumericEdit2.Tag = null;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "วันที่สิ้นสุด";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(241, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "ลำดับสิ้นสุด";
            // 
            // btnRetrive
            // 
            this.btnRetrive.Location = new System.Drawing.Point(550, 19);
            this.btnRetrive.Name = "btnRetrive";
            this.btnRetrive.Size = new System.Drawing.Size(75, 23);
            this.btnRetrive.TabIndex = 1;
            this.btnRetrive.Text = "ดึงข้อมูล";
            this.btnRetrive.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(534, 473);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(552, 99);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 473);
            this.panel2.TabIndex = 10;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(550, 52);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(75, 23);
            this.btnGen.TabIndex = 9;
            this.btnGen.Text = "gen Text";
            this.btnGen.UseVisualStyleBackColor = true;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(93, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(379, 18);
            this.txtPath.TabIndex = 11;
            this.txtPath.Tag = null;
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
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(478, 10);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(31, 23);
            this.btnPath.TabIndex = 13;
            this.btnPath.Text = "...";
            this.btnPath.UseVisualStyleBackColor = true;
            
            // 
            // c1DateEdit1
            // 
            this.c1DateEdit1.AllowSpinLoop = false;
            // 
            // 
            // 
            this.c1DateEdit1.Calendar.DayNameLength = 1;
            this.c1DateEdit1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.c1DateEdit1.ImagePadding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.c1DateEdit1.Location = new System.Drawing.Point(93, 35);
            this.c1DateEdit1.Name = "c1DateEdit1";
            this.c1DateEdit1.Size = new System.Drawing.Size(111, 18);
            this.c1DateEdit1.TabIndex = 11;
            this.c1DateEdit1.Tag = null;
            // 
            // c1DateEdit2
            // 
            this.c1DateEdit2.AllowSpinLoop = false;
            // 
            // 
            // 
            this.c1DateEdit2.Calendar.DayNameLength = 1;
            this.c1DateEdit2.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.c1DateEdit2.ImagePadding = new System.Windows.Forms.Padding(0);
            this.c1DateEdit2.Location = new System.Drawing.Point(306, 35);
            this.c1DateEdit2.Name = "c1DateEdit2";
            this.c1DateEdit2.Size = new System.Drawing.Size(111, 18);
            this.c1DateEdit2.TabIndex = 14;
            this.c1DateEdit2.Tag = null;
            // 
            // FrmgetCEM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 584);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmgetCEM";
            this.Text = "FrmgetCEM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmgetCEM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1NumericEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRetrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnGen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateEdit2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit2;
        private C1.Win.C1Input.C1NumericEdit c1NumericEdit1;
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
    }
}