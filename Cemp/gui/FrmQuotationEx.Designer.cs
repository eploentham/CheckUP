namespace Cemp.gui
{
    partial class FrmQuotationEx
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
            this.chkGoSite = new System.Windows.Forms.CheckBox();
            this.chkDistanceDaily = new System.Windows.Forms.CheckBox();
            this.chkRentCar = new System.Windows.Forms.CheckBox();
            this.chkEx1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGoSiteD = new System.Windows.Forms.TextBox();
            this.txtGoSiteP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGoSiteA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDistanceDailyA = new System.Windows.Forms.TextBox();
            this.txtDistanceDailyP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDistanceDailyD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRentCarA = new System.Windows.Forms.TextBox();
            this.txtRentCarN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRentCarD = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtEx1A = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtEx2A = new System.Windows.Forms.TextBox();
            this.chkEx2 = new System.Windows.Forms.CheckBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRentCarP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDistanceDailyN = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGoSiteN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtRentRoomP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtRentRoomA = new System.Windows.Forms.TextBox();
            this.txtRentRoomN = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtRentRoomD = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.chkRentRoom = new System.Windows.Forms.CheckBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkGoSite
            // 
            this.chkGoSite.AutoSize = true;
            this.chkGoSite.Location = new System.Drawing.Point(31, 30);
            this.chkGoSite.Name = "chkGoSite";
            this.chkGoSite.Size = new System.Drawing.Size(142, 17);
            this.chkGoSite.TabIndex = 0;
            this.chkGoSite.Text = "ต้องเดินทางไปต่างจังหวัด";
            this.chkGoSite.UseVisualStyleBackColor = true;
            this.chkGoSite.Click += new System.EventHandler(this.chkGoSite_Click);
            // 
            // chkDistanceDaily
            // 
            this.chkDistanceDaily.AutoSize = true;
            this.chkDistanceDaily.Location = new System.Drawing.Point(31, 103);
            this.chkDistanceDaily.Name = "chkDistanceDaily";
            this.chkDistanceDaily.Size = new System.Drawing.Size(158, 17);
            this.chkDistanceDaily.TabIndex = 1;
            this.chkDistanceDaily.Text = "ระยะทางที่ใช้งานในแต่ละวัน";
            this.chkDistanceDaily.UseVisualStyleBackColor = true;
            this.chkDistanceDaily.Click += new System.EventHandler(this.chkDistanceDaily_Click);
            // 
            // chkRentCar
            // 
            this.chkRentCar.AutoSize = true;
            this.chkRentCar.Location = new System.Drawing.Point(31, 175);
            this.chkRentCar.Name = "chkRentCar";
            this.chkRentCar.Size = new System.Drawing.Size(74, 17);
            this.chkRentCar.TabIndex = 2;
            this.chkRentCar.Text = "ต้องเช่ารถ";
            this.chkRentCar.UseVisualStyleBackColor = true;
            this.chkRentCar.Click += new System.EventHandler(this.chkRentCar_Click);
            // 
            // chkEx1
            // 
            this.chkEx1.AutoSize = true;
            this.chkEx1.Location = new System.Drawing.Point(31, 312);
            this.chkEx1.Name = "chkEx1";
            this.chkEx1.Size = new System.Drawing.Size(98, 17);
            this.chkEx1.TabIndex = 3;
            this.chkEx1.Text = "ค่าใช้จ่ายเพิ่ม 1";
            this.chkEx1.UseVisualStyleBackColor = true;
            this.chkEx1.Click += new System.EventHandler(this.chkEx1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ระยะทางไป-กลับ กม.";
            // 
            // txtGoSiteD
            // 
            this.txtGoSiteD.Location = new System.Drawing.Point(301, 28);
            this.txtGoSiteD.Name = "txtGoSiteD";
            this.txtGoSiteD.Size = new System.Drawing.Size(59, 20);
            this.txtGoSiteD.TabIndex = 5;
            this.txtGoSiteD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoSiteD_KeyPress);
            this.txtGoSiteD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGoSiteD_KeyUp);
            // 
            // txtGoSiteP
            // 
            this.txtGoSiteP.Location = new System.Drawing.Point(421, 28);
            this.txtGoSiteP.Name = "txtGoSiteP";
            this.txtGoSiteP.Size = new System.Drawing.Size(59, 20);
            this.txtGoSiteP.TabIndex = 7;
            this.txtGoSiteP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoSiteP_KeyPress);
            this.txtGoSiteP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGoSiteP_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "ราคาน้ำมันต่อ กม.";
            // 
            // txtGoSiteA
            // 
            this.txtGoSiteA.Location = new System.Drawing.Point(597, 27);
            this.txtGoSiteA.Name = "txtGoSiteA";
            this.txtGoSiteA.Size = new System.Drawing.Size(84, 20);
            this.txtGoSiteA.TabIndex = 8;
            this.txtGoSiteA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtGoSiteA.TextChanged += new System.EventHandler(this.txtGoSiteA_TextChanged);
            this.txtGoSiteA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGoSiteA_KeyUp);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(542, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "รวมราคา";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "รวมราคา";
            // 
            // txtDistanceDailyA
            // 
            this.txtDistanceDailyA.Location = new System.Drawing.Point(597, 102);
            this.txtDistanceDailyA.Name = "txtDistanceDailyA";
            this.txtDistanceDailyA.Size = new System.Drawing.Size(84, 20);
            this.txtDistanceDailyA.TabIndex = 14;
            this.txtDistanceDailyA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDistanceDailyA.TextChanged += new System.EventHandler(this.txtDistanceDailyA_TextChanged);
            this.txtDistanceDailyA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDistanceDailyA_KeyUp);
            // 
            // txtDistanceDailyP
            // 
            this.txtDistanceDailyP.Location = new System.Drawing.Point(421, 103);
            this.txtDistanceDailyP.Name = "txtDistanceDailyP";
            this.txtDistanceDailyP.Size = new System.Drawing.Size(59, 20);
            this.txtDistanceDailyP.TabIndex = 13;
            this.txtDistanceDailyP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistanceDailyP_KeyPress);
            this.txtDistanceDailyP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDistanceDailyP_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(407, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ราคาน้ำมันต่อ กม.";
            // 
            // txtDistanceDailyD
            // 
            this.txtDistanceDailyD.Location = new System.Drawing.Point(301, 103);
            this.txtDistanceDailyD.Name = "txtDistanceDailyD";
            this.txtDistanceDailyD.Size = new System.Drawing.Size(59, 20);
            this.txtDistanceDailyD.TabIndex = 11;
            this.txtDistanceDailyD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistanceDailyD_KeyPress);
            this.txtDistanceDailyD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDistanceDailyD_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "ระยะทางเฉลี่ยแต่ละวัน";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 174);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "รวมราคา";
            // 
            // txtRentCarA
            // 
            this.txtRentCarA.Location = new System.Drawing.Point(597, 171);
            this.txtRentCarA.Name = "txtRentCarA";
            this.txtRentCarA.Size = new System.Drawing.Size(84, 20);
            this.txtRentCarA.TabIndex = 20;
            this.txtRentCarA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRentCarA.TextChanged += new System.EventHandler(this.txtRentCarA_TextChanged);
            this.txtRentCarA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRentCarA_KeyUp);
            // 
            // txtRentCarN
            // 
            this.txtRentCarN.Location = new System.Drawing.Point(201, 171);
            this.txtRentCarN.Name = "txtRentCarN";
            this.txtRentCarN.Size = new System.Drawing.Size(59, 20);
            this.txtRentCarN.TabIndex = 19;
            this.txtRentCarN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentCarP_KeyPress);
            this.txtRentCarN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRentCarP_KeyUp);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(203, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "จำนวนวัน";
            // 
            // txtRentCarD
            // 
            this.txtRentCarD.Location = new System.Drawing.Point(301, 172);
            this.txtRentCarD.Name = "txtRentCarD";
            this.txtRentCarD.Size = new System.Drawing.Size(59, 20);
            this.txtRentCarD.TabIndex = 17;
            this.txtRentCarD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentCarD_KeyPress);
            this.txtRentCarD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRentCarD_KeyUp);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(298, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "ค่าเช่ารถต่อวัน";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(542, 312);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "รวมราคา";
            // 
            // txtEx1A
            // 
            this.txtEx1A.Location = new System.Drawing.Point(597, 309);
            this.txtEx1A.Name = "txtEx1A";
            this.txtEx1A.Size = new System.Drawing.Size(84, 20);
            this.txtEx1A.TabIndex = 22;
            this.txtEx1A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEx1A.TextChanged += new System.EventHandler(this.txtEx1A_TextChanged);
            this.txtEx1A.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEx1A_KeyUp);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(542, 399);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "รวมราคา";
            // 
            // txtEx2A
            // 
            this.txtEx2A.Location = new System.Drawing.Point(597, 396);
            this.txtEx2A.Name = "txtEx2A";
            this.txtEx2A.Size = new System.Drawing.Size(84, 20);
            this.txtEx2A.TabIndex = 25;
            this.txtEx2A.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtEx2A.TextChanged += new System.EventHandler(this.txtEx2A_TextChanged);
            this.txtEx2A.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtEx2A_KeyUp);
            // 
            // chkEx2
            // 
            this.chkEx2.AutoSize = true;
            this.chkEx2.Location = new System.Drawing.Point(31, 399);
            this.chkEx2.Name = "chkEx2";
            this.chkEx2.Size = new System.Drawing.Size(98, 17);
            this.chkEx2.TabIndex = 24;
            this.chkEx2.Text = "ค่าใช้จ่ายเพิ่ม 2";
            this.chkEx2.UseVisualStyleBackColor = true;
            this.chkEx2.Click += new System.EventHandler(this.chkEx2_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(597, 473);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(84, 20);
            this.txtAmount.TabIndex = 27;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(708, 470);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 28;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtRentCarP
            // 
            this.txtRentCarP.Location = new System.Drawing.Point(421, 171);
            this.txtRentCarP.Name = "txtRentCarP";
            this.txtRentCarP.Size = new System.Drawing.Size(59, 20);
            this.txtRentCarP.TabIndex = 30;
            this.txtRentCarP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentCarN_KeyPress);
            this.txtRentCarP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRentCarN_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(425, 155);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(53, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "จำนวนรถ";
            // 
            // txtDistanceDailyN
            // 
            this.txtDistanceDailyN.Location = new System.Drawing.Point(202, 103);
            this.txtDistanceDailyN.Name = "txtDistanceDailyN";
            this.txtDistanceDailyN.Size = new System.Drawing.Size(59, 20);
            this.txtDistanceDailyN.TabIndex = 32;
            this.txtDistanceDailyN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistanceDailyN_KeyPress);
            this.txtDistanceDailyN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDistanceDailyN_KeyUp);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(206, 87);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(54, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "จำนวนวัน";
            // 
            // txtGoSiteN
            // 
            this.txtGoSiteN.Location = new System.Drawing.Point(202, 30);
            this.txtGoSiteN.Name = "txtGoSiteN";
            this.txtGoSiteN.Size = new System.Drawing.Size(59, 20);
            this.txtGoSiteN.TabIndex = 34;
            this.txtGoSiteN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGoSiteN_KeyPress);
            this.txtGoSiteN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGoSiteN_KeyUp);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(206, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "จำนวนวัน";
            // 
            // txtRentRoomP
            // 
            this.txtRentRoomP.Location = new System.Drawing.Point(421, 240);
            this.txtRentRoomP.Name = "txtRentRoomP";
            this.txtRentRoomP.Size = new System.Drawing.Size(59, 20);
            this.txtRentRoomP.TabIndex = 43;
            this.txtRentRoomP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentRoomP_KeyPress);
            this.txtRentRoomP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRentRoomP_KeyUp);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(425, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 42;
            this.label15.Text = "จำนวนห้อง";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(542, 243);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "รวมราคา";
            // 
            // txtRentRoomA
            // 
            this.txtRentRoomA.Location = new System.Drawing.Point(597, 240);
            this.txtRentRoomA.Name = "txtRentRoomA";
            this.txtRentRoomA.Size = new System.Drawing.Size(84, 20);
            this.txtRentRoomA.TabIndex = 40;
            this.txtRentRoomA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRentRoomN
            // 
            this.txtRentRoomN.Location = new System.Drawing.Point(201, 240);
            this.txtRentRoomN.Name = "txtRentRoomN";
            this.txtRentRoomN.Size = new System.Drawing.Size(59, 20);
            this.txtRentRoomN.TabIndex = 39;
            this.txtRentRoomN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentRoomN_KeyPress);
            this.txtRentRoomN.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRentRoomN_KeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(203, 224);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(54, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "จำนวนวัน";
            // 
            // txtRentRoomD
            // 
            this.txtRentRoomD.Location = new System.Drawing.Point(301, 241);
            this.txtRentRoomD.Name = "txtRentRoomD";
            this.txtRentRoomD.Size = new System.Drawing.Size(59, 20);
            this.txtRentRoomD.TabIndex = 37;
            this.txtRentRoomD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRentRoomD_KeyPress);
            this.txtRentRoomD.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRentRoomD_KeyUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(298, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = "ค่าเช่าห้องต่อวัน";
            // 
            // chkRentRoom
            // 
            this.chkRentRoom.AutoSize = true;
            this.chkRentRoom.Location = new System.Drawing.Point(31, 244);
            this.chkRentRoom.Name = "chkRentRoom";
            this.chkRentRoom.Size = new System.Drawing.Size(94, 17);
            this.chkRentRoom.TabIndex = 35;
            this.chkRentRoom.Text = "ต้องเช่าห้องพัก";
            this.chkRentRoom.UseVisualStyleBackColor = true;
            this.chkRentRoom.Click += new System.EventHandler(this.chkRentRoom_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(687, 27);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(33, 20);
            this.txtId.TabIndex = 44;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtId.Visible = false;
            // 
            // FrmQuotationEx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 517);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtRentRoomP);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtRentRoomA);
            this.Controls.Add(this.txtRentRoomN);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtRentRoomD);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.chkRentRoom);
            this.Controls.Add(this.txtGoSiteN);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtDistanceDailyN);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRentCarP);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtEx2A);
            this.Controls.Add(this.chkEx2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtEx1A);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRentCarA);
            this.Controls.Add(this.txtRentCarN);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtRentCarD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDistanceDailyA);
            this.Controls.Add(this.txtDistanceDailyP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDistanceDailyD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGoSiteA);
            this.Controls.Add(this.txtGoSiteP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtGoSiteD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEx1);
            this.Controls.Add(this.chkRentCar);
            this.Controls.Add(this.chkDistanceDaily);
            this.Controls.Add(this.chkGoSite);
            this.Name = "FrmQuotationEx";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmQuotationEx";
            this.Load += new System.EventHandler(this.FrmQuotationEx_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkGoSite;
        private System.Windows.Forms.CheckBox chkDistanceDaily;
        private System.Windows.Forms.CheckBox chkRentCar;
        private System.Windows.Forms.CheckBox chkEx1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGoSiteD;
        private System.Windows.Forms.TextBox txtGoSiteP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGoSiteA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDistanceDailyA;
        private System.Windows.Forms.TextBox txtDistanceDailyP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDistanceDailyD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRentCarA;
        private System.Windows.Forms.TextBox txtRentCarN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRentCarD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtEx1A;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtEx2A;
        private System.Windows.Forms.CheckBox chkEx2;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtRentCarP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDistanceDailyN;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGoSiteN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtRentRoomP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtRentRoomA;
        private System.Windows.Forms.TextBox txtRentRoomN;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtRentRoomD;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.CheckBox chkRentRoom;
        private System.Windows.Forms.TextBox txtId;
    }
}