namespace CheckUP
{
    partial class FrmCheckUPView
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
            this.btnSfAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvView
            // 
            this.dgvView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvView.Location = new System.Drawing.Point(11, 11);
            this.dgvView.Margin = new System.Windows.Forms.Padding(2);
            this.dgvView.Name = "dgvView";
            this.dgvView.RowTemplate.Height = 24;
            this.dgvView.Size = new System.Drawing.Size(744, 558);
            this.dgvView.TabIndex = 1;
            // 
            // btnSfAdd
            // 
            this.btnSfAdd.Location = new System.Drawing.Point(769, 11);
            this.btnSfAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnSfAdd.Name = "btnSfAdd";
            this.btnSfAdd.Size = new System.Drawing.Size(56, 39);
            this.btnSfAdd.TabIndex = 3;
            this.btnSfAdd.Text = "ป้อนใหม่";
            this.btnSfAdd.UseVisualStyleBackColor = true;
            this.btnSfAdd.Click += new System.EventHandler(this.btnSfAdd_Click);
            // 
            // FrmCheckUPView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 590);
            this.Controls.Add(this.btnSfAdd);
            this.Controls.Add(this.dgvView);
            this.Name = "FrmCheckUPView";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmCheckUPView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvView;
        private System.Windows.Forms.Button btnSfAdd;

    }
}

