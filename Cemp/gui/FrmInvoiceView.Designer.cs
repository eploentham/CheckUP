namespace Cemp.gui
{
    partial class FrmInvoiceView
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
            this.dgvView = new System.Windows.Forms.DataGridView();
            this.chkMOU = new System.Windows.Forms.RadioButton();
            this.chkBillStatus2 = new System.Windows.Forms.RadioButton();
            this.chkOverDue = new System.Windows.Forms.RadioButton();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(11, 51);
            this.dgvView.Margin = new System.Windows.Forms.Padding(2);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(612, 503);
            this.dgvView.TabIndex = 8;
            this.dgvView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvView_CellDoubleClick);
            // 
            // chkMOU
            // 
            this.chkMOU.AutoSize = true;
            this.chkMOU.Location = new System.Drawing.Point(27, 12);
            this.chkMOU.Name = "chkMOU";
            this.chkMOU.Size = new System.Drawing.Size(112, 17);
            this.chkMOU.TabIndex = 10;
            this.chkMOU.TabStop = true;
            this.chkMOU.Text = "MOU ที่พร้อมทำBill";
            this.chkMOU.UseVisualStyleBackColor = true;
            this.chkMOU.Click += new System.EventHandler(this.chkMOU_Click);
            // 
            // chkBillStatus2
            // 
            this.chkBillStatus2.AutoSize = true;
            this.chkBillStatus2.Location = new System.Drawing.Point(203, 12);
            this.chkBillStatus2.Name = "chkBillStatus2";
            this.chkBillStatus2.Size = new System.Drawing.Size(213, 17);
            this.chkBillStatus2.TabIndex = 11;
            this.chkBillStatus2.TabStop = true;
            this.chkBillStatus2.Text = "วางบิลแล้ว แต่ยังไม่ถึงกำหนดรับCheque";
            this.chkBillStatus2.UseVisualStyleBackColor = true;
            this.chkBillStatus2.Click += new System.EventHandler(this.chkBillStatus2_Click);
            // 
            // chkOverDue
            // 
            this.chkOverDue.AutoSize = true;
            this.chkOverDue.Location = new System.Drawing.Point(434, 12);
            this.chkOverDue.Name = "chkOverDue";
            this.chkOverDue.Size = new System.Drawing.Size(65, 17);
            this.chkOverDue.TabIndex = 12;
            this.chkOverDue.TabStop = true;
            this.chkOverDue.Text = "ค้างชำระ";
            this.chkOverDue.UseVisualStyleBackColor = true;
            this.chkOverDue.Click += new System.EventHandler(this.chkOverDue_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(591, 8);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 39);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "ป้อนใหม่";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmInvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 562);
            this.Controls.Add(this.chkOverDue);
            this.Controls.Add(this.chkBillStatus2);
            this.Controls.Add(this.chkMOU);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvView);
            this.Name = "FrmInvoiceView";
            this.Text = "FrmBillView";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInvoiceView_Load);
            this.Resize += new System.EventHandler(this.FrmInvoiceView_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.RadioButton chkMOU;
        private System.Windows.Forms.RadioButton chkBillStatus2;
        private System.Windows.Forms.RadioButton chkOverDue;
        private System.Windows.Forms.Button btnAdd;
    }
}