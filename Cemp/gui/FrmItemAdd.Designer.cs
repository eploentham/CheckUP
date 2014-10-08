namespace Cemp.gui
{
    partial class FrmItemAdd
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
            this.label13 = new System.Windows.Forms.Label();
            this.cboDocType = new System.Windows.Forms.ComboBox();
            this.txtPriceCostReal = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.cboCustPO = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnMethodAdd = new System.Windows.Forms.Button();
            this.btnGroupAdd = new System.Windows.Forms.Button();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUnActive = new System.Windows.Forms.Button();
            this.ChkUnActive = new System.Windows.Forms.RadioButton();
            this.chkActive = new System.Windows.Forms.RadioButton();
            this.txtPriceCost = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPriceSale = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboMethod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNameE = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameT = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnalysisAdd = new System.Windows.Forms.Button();
            this.cboAnalysis = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAnalysisAdd);
            this.groupBox1.Controls.Add(this.cboAnalysis);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cboDocType);
            this.groupBox1.Controls.Add(this.txtPriceCostReal);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.cboCustPO);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btnMethodAdd);
            this.groupBox1.Controls.Add(this.btnGroupAdd);
            this.groupBox1.Controls.Add(this.cboGroup);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnUnActive);
            this.groupBox1.Controls.Add(this.ChkUnActive);
            this.groupBox1.Controls.Add(this.chkActive);
            this.groupBox1.Controls.Add(this.txtPriceCost);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtRemark);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtPriceSale);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cboMethod);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtId);
            this.groupBox1.Controls.Add(this.txtNameE);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtNameT);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 498);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label13.Location = new System.Drawing.Point(7, 168);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 17);
            this.label13.TabIndex = 138;
            this.label13.Text = "Type :";
            // 
            // cboDocType
            // 
            this.cboDocType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.cboDocType.FormattingEnabled = true;
            this.cboDocType.Location = new System.Drawing.Point(108, 163);
            this.cboDocType.Margin = new System.Windows.Forms.Padding(2);
            this.cboDocType.Name = "cboDocType";
            this.cboDocType.Size = new System.Drawing.Size(76, 25);
            this.cboDocType.TabIndex = 137;
            this.cboDocType.Enter += new System.EventHandler(this.cboDocType_Enter);
            this.cboDocType.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboDocType_KeyUp);
            this.cboDocType.Leave += new System.EventHandler(this.cboDocType_Leave);
            // 
            // txtPriceCostReal
            // 
            this.txtPriceCostReal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceCostReal.Location = new System.Drawing.Point(108, 310);
            this.txtPriceCostReal.Name = "txtPriceCostReal";
            this.txtPriceCostReal.Size = new System.Drawing.Size(100, 22);
            this.txtPriceCostReal.TabIndex = 136;
            this.txtPriceCostReal.TabStop = false;
            this.txtPriceCostReal.Enter += new System.EventHandler(this.txtPriceCostReal_Enter);
            this.txtPriceCostReal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceCostReal_KeyPress);
            this.txtPriceCostReal.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPriceCostReal_KeyUp);
            this.txtPriceCostReal.Leave += new System.EventHandler(this.txtPriceCostReal_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 313);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 16);
            this.label12.TabIndex = 135;
            this.label12.Text = "ราคาทุน2  :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(512, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 23);
            this.button1.TabIndex = 134;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cboCustPO
            // 
            this.cboCustPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCustPO.FormattingEnabled = true;
            this.cboCustPO.Location = new System.Drawing.Point(108, 345);
            this.cboCustPO.Name = "cboCustPO";
            this.cboCustPO.Size = new System.Drawing.Size(398, 24);
            this.cboCustPO.TabIndex = 133;
            this.cboCustPO.Enter += new System.EventHandler(this.cboCustPO_Enter);
            this.cboCustPO.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboCustPO_KeyUp);
            this.cboCustPO.Leave += new System.EventHandler(this.cboCustPO_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 348);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 16);
            this.label11.TabIndex = 132;
            this.label11.Text = "ส่งตรวจกับบริษัท  :";
            // 
            // btnMethodAdd
            // 
            this.btnMethodAdd.Location = new System.Drawing.Point(512, 134);
            this.btnMethodAdd.Name = "btnMethodAdd";
            this.btnMethodAdd.Size = new System.Drawing.Size(37, 23);
            this.btnMethodAdd.TabIndex = 131;
            this.btnMethodAdd.Text = "...";
            this.btnMethodAdd.UseVisualStyleBackColor = true;
            this.btnMethodAdd.Click += new System.EventHandler(this.btnMethodAdd_Click);
            // 
            // btnGroupAdd
            // 
            this.btnGroupAdd.Location = new System.Drawing.Point(512, 104);
            this.btnGroupAdd.Name = "btnGroupAdd";
            this.btnGroupAdd.Size = new System.Drawing.Size(37, 23);
            this.btnGroupAdd.TabIndex = 130;
            this.btnGroupAdd.Text = "...";
            this.btnGroupAdd.UseVisualStyleBackColor = true;
            this.btnGroupAdd.Click += new System.EventHandler(this.btnGroupAdd_Click);
            // 
            // cboGroup
            // 
            this.cboGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.Location = new System.Drawing.Point(108, 103);
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(398, 24);
            this.cboGroup.TabIndex = 129;
            this.cboGroup.Enter += new System.EventHandler(this.cboGroup_Enter);
            this.cboGroup.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboGroup_KeyUp);
            this.cboGroup.Leave += new System.EventHandler(this.cboGroup_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 16);
            this.label10.TabIndex = 128;
            this.label10.Text = "กลุ่ม :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(479, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 127;
            this.label9.Text = "label9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 126;
            this.label8.Text = "label8";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(222, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(37, 23);
            this.btnSearch.TabIndex = 125;
            this.btnSearch.Text = "...";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(439, 447);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 124;
            this.btnSave.Text = "บันทึก";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUnActive
            // 
            this.btnUnActive.Location = new System.Drawing.Point(318, 425);
            this.btnUnActive.Name = "btnUnActive";
            this.btnUnActive.Size = new System.Drawing.Size(103, 23);
            this.btnUnActive.TabIndex = 123;
            this.btnUnActive.Text = "ยกเลิกการใช้งาน";
            this.btnUnActive.UseVisualStyleBackColor = true;
            this.btnUnActive.Click += new System.EventHandler(this.btnUnActive_Click);
            // 
            // ChkUnActive
            // 
            this.ChkUnActive.AutoSize = true;
            this.ChkUnActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.ChkUnActive.Location = new System.Drawing.Point(241, 425);
            this.ChkUnActive.Margin = new System.Windows.Forms.Padding(2);
            this.ChkUnActive.Name = "ChkUnActive";
            this.ChkUnActive.Size = new System.Drawing.Size(60, 21);
            this.ChkUnActive.TabIndex = 122;
            this.ChkUnActive.TabStop = true;
            this.ChkUnActive.Text = "ยกเลิก";
            this.ChkUnActive.UseVisualStyleBackColor = true;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.chkActive.Location = new System.Drawing.Point(116, 425);
            this.chkActive.Margin = new System.Windows.Forms.Padding(2);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(61, 21);
            this.chkActive.TabIndex = 121;
            this.chkActive.TabStop = true;
            this.chkActive.Text = "ใช้งาน";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // txtPriceCost
            // 
            this.txtPriceCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceCost.Location = new System.Drawing.Point(108, 282);
            this.txtPriceCost.Name = "txtPriceCost";
            this.txtPriceCost.Size = new System.Drawing.Size(100, 22);
            this.txtPriceCost.TabIndex = 117;
            this.txtPriceCost.TabStop = false;
            this.txtPriceCost.Enter += new System.EventHandler(this.txtPriceCost_Enter);
            this.txtPriceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceCost_KeyPress);
            this.txtPriceCost.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPriceCost_KeyUp);
            this.txtPriceCost.Leave += new System.EventHandler(this.txtPriceCost_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 116;
            this.label6.Text = "ราคาทุน1  :";
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemark.Location = new System.Drawing.Point(108, 385);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(398, 22);
            this.txtRemark.TabIndex = 115;
            this.txtRemark.TabStop = false;
            this.txtRemark.Enter += new System.EventHandler(this.txtRemark_Enter);
            this.txtRemark.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRemark_KeyUp);
            this.txtRemark.Leave += new System.EventHandler(this.txtRemark_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 16);
            this.label4.TabIndex = 114;
            this.label4.Text = "หมายเหตุ :";
            // 
            // txtPriceSale
            // 
            this.txtPriceSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceSale.Location = new System.Drawing.Point(108, 254);
            this.txtPriceSale.Name = "txtPriceSale";
            this.txtPriceSale.Size = new System.Drawing.Size(100, 22);
            this.txtPriceSale.TabIndex = 113;
            this.txtPriceSale.TabStop = false;
            this.txtPriceSale.Enter += new System.EventHandler(this.txtPriceSale_Enter);
            this.txtPriceSale.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceSale_KeyPress);
            this.txtPriceSale.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPriceSale_KeyUp);
            this.txtPriceSale.Leave += new System.EventHandler(this.txtPriceSale_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 16);
            this.label5.TabIndex = 112;
            this.label5.Text = "ราคาขาย  :";
            // 
            // cboMethod
            // 
            this.cboMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMethod.FormattingEnabled = true;
            this.cboMethod.Location = new System.Drawing.Point(108, 134);
            this.cboMethod.Name = "cboMethod";
            this.cboMethod.Size = new System.Drawing.Size(398, 24);
            this.cboMethod.TabIndex = 109;
            this.cboMethod.Enter += new System.EventHandler(this.cboMethod_Enter);
            this.cboMethod.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboMethod_KeyUp);
            this.cboMethod.Leave += new System.EventHandler(this.cboMethod_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 16);
            this.label7.TabIndex = 108;
            this.label7.Text = "Method :";
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(332, 18);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(26, 22);
            this.txtId.TabIndex = 106;
            this.txtId.Visible = false;
            // 
            // txtNameE
            // 
            this.txtNameE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameE.Location = new System.Drawing.Point(108, 75);
            this.txtNameE.Name = "txtNameE";
            this.txtNameE.Size = new System.Drawing.Size(398, 22);
            this.txtNameE.TabIndex = 105;
            this.txtNameE.Enter += new System.EventHandler(this.txtNameE_Enter);
            this.txtNameE.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNameE_KeyUp);
            this.txtNameE.Leave += new System.EventHandler(this.txtNameE_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 104;
            this.label3.Text = "Name :";
            // 
            // txtNameT
            // 
            this.txtNameT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameT.Location = new System.Drawing.Point(108, 47);
            this.txtNameT.Name = "txtNameT";
            this.txtNameT.Size = new System.Drawing.Size(398, 22);
            this.txtNameT.TabIndex = 102;
            this.txtNameT.Enter += new System.EventHandler(this.txtNameT_Enter);
            this.txtNameT.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNameT_KeyUp);
            this.txtNameT.Leave += new System.EventHandler(this.txtNameT_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 16);
            this.label2.TabIndex = 103;
            this.label2.Text = "ชื่อ :";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(108, 19);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(100, 22);
            this.txtCode.TabIndex = 107;
            this.txtCode.TabStop = false;
            this.txtCode.Enter += new System.EventHandler(this.txtCode_Enter);
            this.txtCode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCode_KeyUp);
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 101;
            this.label1.Text = "รหัส  yyxxx:";
            // 
            // btnAnalysisAdd
            // 
            this.btnAnalysisAdd.Location = new System.Drawing.Point(512, 193);
            this.btnAnalysisAdd.Name = "btnAnalysisAdd";
            this.btnAnalysisAdd.Size = new System.Drawing.Size(37, 23);
            this.btnAnalysisAdd.TabIndex = 141;
            this.btnAnalysisAdd.Text = "...";
            this.btnAnalysisAdd.UseVisualStyleBackColor = true;
            this.btnAnalysisAdd.Click += new System.EventHandler(this.btnAnalysisAdd_Click);
            // 
            // cboAnalysis
            // 
            this.cboAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAnalysis.FormattingEnabled = true;
            this.cboAnalysis.Location = new System.Drawing.Point(108, 193);
            this.cboAnalysis.Name = "cboAnalysis";
            this.cboAnalysis.Size = new System.Drawing.Size(398, 24);
            this.cboAnalysis.TabIndex = 140;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 16);
            this.label14.TabIndex = 139;
            this.label14.Text = "Analysis :";
            // 
            // FrmItemAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 522);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmItemAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmItemAdd";
            this.Load += new System.EventHandler(this.FrmItemAdd_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNameE;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPriceSale;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPriceCost;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnUnActive;
        private System.Windows.Forms.RadioButton ChkUnActive;
        private System.Windows.Forms.RadioButton chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnGroupAdd;
        private System.Windows.Forms.Button btnMethodAdd;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboCustPO;
        private System.Windows.Forms.TextBox txtPriceCostReal;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboDocType;
        private System.Windows.Forms.Button btnAnalysisAdd;
        private System.Windows.Forms.ComboBox cboAnalysis;
        private System.Windows.Forms.Label label14;
    }
}