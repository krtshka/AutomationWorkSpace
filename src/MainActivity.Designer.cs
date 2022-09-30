
namespace VKR
{
    partial class MainActivity
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
            this.components = new System.ComponentModel.Container();
            this.labelLights = new System.Windows.Forms.Label();
            this.labelCabin = new System.Windows.Forms.Label();
            this.labelAdress = new System.Windows.Forms.Label();
            this.labelCom = new System.Windows.Forms.Label();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.comboBoxCabin = new System.Windows.Forms.ComboBox();
            this.comboBoxAdress = new System.Windows.Forms.ComboBox();
            this.labelPositionNum = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelLight = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelModeNum = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelReversorNum = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.labelStatus1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonNull = new System.Windows.Forms.Button();
            this.buttonNeutral = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelLights
            // 
            this.labelLights.AutoSize = true;
            this.labelLights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLights.ForeColor = System.Drawing.Color.Blue;
            this.labelLights.Location = new System.Drawing.Point(3, 49);
            this.labelLights.Name = "labelLights";
            this.labelLights.Size = new System.Drawing.Size(115, 13);
            this.labelLights.TabIndex = 8;
            this.labelLights.Text = "Буферные фонари";
            // 
            // labelCabin
            // 
            this.labelCabin.AutoSize = true;
            this.labelCabin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCabin.Location = new System.Drawing.Point(63, 628);
            this.labelCabin.Name = "labelCabin";
            this.labelCabin.Size = new System.Drawing.Size(77, 25);
            this.labelCabin.TabIndex = 9;
            this.labelCabin.Text = "Кабина";
            // 
            // labelAdress
            // 
            this.labelAdress.AutoSize = true;
            this.labelAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAdress.Location = new System.Drawing.Point(63, 603);
            this.labelAdress.Name = "labelAdress";
            this.labelAdress.Size = new System.Drawing.Size(189, 25);
            this.labelAdress.TabIndex = 10;
            this.labelAdress.Text = "Адрес локомотива";
            // 
            // labelCom
            // 
            this.labelCom.AutoSize = true;
            this.labelCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCom.Location = new System.Drawing.Point(63, 576);
            this.labelCom.Name = "labelCom";
            this.labelCom.Size = new System.Drawing.Size(186, 25);
            this.labelCom.TabIndex = 11;
            this.labelCom.Text = "Выбор COM-порта";
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(255, 580);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCOM.TabIndex = 17;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonConnect.Location = new System.Drawing.Point(382, 580);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(85, 24);
            this.buttonConnect.TabIndex = 18;
            this.buttonConnect.Text = "Connect";
            this.buttonConnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // comboBoxCabin
            // 
            this.comboBoxCabin.FormattingEnabled = true;
            this.comboBoxCabin.Location = new System.Drawing.Point(255, 628);
            this.comboBoxCabin.Name = "comboBoxCabin";
            this.comboBoxCabin.Size = new System.Drawing.Size(121, 21);
            this.comboBoxCabin.TabIndex = 19;
            this.comboBoxCabin.SelectedIndexChanged += new System.EventHandler(this.comboBoxCabin_SelectedIndexChanged);
            // 
            // comboBoxAdress
            // 
            this.comboBoxAdress.FormattingEnabled = true;
            this.comboBoxAdress.Location = new System.Drawing.Point(255, 606);
            this.comboBoxAdress.Name = "comboBoxAdress";
            this.comboBoxAdress.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAdress.TabIndex = 23;
            this.comboBoxAdress.SelectedIndexChanged += new System.EventHandler(this.comboBoxAdress_SelectedIndexChanged);
            // 
            // labelPositionNum
            // 
            this.labelPositionNum.AutoSize = true;
            this.labelPositionNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.labelPositionNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPositionNum.ForeColor = System.Drawing.Color.Blue;
            this.labelPositionNum.Location = new System.Drawing.Point(83, 0);
            this.labelPositionNum.Name = "labelPositionNum";
            this.labelPositionNum.Size = new System.Drawing.Size(14, 13);
            this.labelPositionNum.TabIndex = 3;
            this.labelPositionNum.Text = "0";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelPosition.Location = new System.Drawing.Point(4, 0);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(58, 13);
            this.labelPosition.TabIndex = 2;
            this.labelPosition.Text = "Позиция";
            // 
            // labelLight
            // 
            this.labelLight.AutoSize = true;
            this.labelLight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelLight.Location = new System.Drawing.Point(42, 62);
            this.labelLight.Name = "labelLight";
            this.labelLight.Size = new System.Drawing.Size(42, 13);
            this.labelLight.TabIndex = 27;
            this.labelLight.Text = "Выкл.";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::VKR.Properties.Resources.newBackground;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.labelStatus1);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.buttonPlus);
            this.panel1.Controls.Add(this.buttonMinus);
            this.panel1.Controls.Add(this.buttonNull);
            this.panel1.Controls.Add(this.buttonNeutral);
            this.panel1.Location = new System.Drawing.Point(68, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(977, 561);
            this.panel1.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.panel7);
            this.panel2.Controls.Add(this.labelLight);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.labelLights);
            this.panel2.Location = new System.Drawing.Point(544, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(147, 113);
            this.panel2.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel7.Controls.Add(this.labelPosition);
            this.panel7.Controls.Add(this.labelPositionNum);
            this.panel7.Location = new System.Drawing.Point(9, 87);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(109, 25);
            this.panel7.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Location = new System.Drawing.Point(77, 9);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(63, 37);
            this.panel4.TabIndex = 1;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.ForeColor = System.Drawing.Color.Blue;
            this.label22.Location = new System.Drawing.Point(3, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Режим";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.labelModeNum);
            this.panel6.Location = new System.Drawing.Point(3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(57, 21);
            this.panel6.TabIndex = 0;
            // 
            // labelModeNum
            // 
            this.labelModeNum.AutoSize = true;
            this.labelModeNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelModeNum.ForeColor = System.Drawing.Color.Blue;
            this.labelModeNum.Location = new System.Drawing.Point(3, 3);
            this.labelModeNum.Name = "labelModeNum";
            this.labelModeNum.Size = new System.Drawing.Size(41, 13);
            this.labelModeNum.TabIndex = 1;
            this.labelModeNum.Text = "СТОП";
            this.labelModeNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Location = new System.Drawing.Point(3, 9);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 37);
            this.panel3.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Реверсор";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.labelReversorNum);
            this.panel5.Location = new System.Drawing.Point(4, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 18);
            this.panel5.TabIndex = 32;
            // 
            // labelReversorNum
            // 
            this.labelReversorNum.AutoSize = true;
            this.labelReversorNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelReversorNum.ForeColor = System.Drawing.Color.Blue;
            this.labelReversorNum.Location = new System.Drawing.Point(-1, 2);
            this.labelReversorNum.Name = "labelReversorNum";
            this.labelReversorNum.Size = new System.Drawing.Size(64, 13);
            this.labelReversorNum.TabIndex = 0;
            this.labelReversorNum.Text = "Нейтраль";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::VKR.Properties.Resources.LIGHTS;
            this.pictureBox5.Location = new System.Drawing.Point(264, 145);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(18, 70);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 30;
            this.pictureBox5.TabStop = false;
            // 
            // labelStatus1
            // 
            this.labelStatus1.AutoSize = true;
            this.labelStatus1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelStatus1.Location = new System.Drawing.Point(355, 20);
            this.labelStatus1.Name = "labelStatus1";
            this.labelStatus1.Size = new System.Drawing.Size(215, 24);
            this.labelStatus1.TabIndex = 28;
            this.labelStatus1.Text = "Выберите COM-порт";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::VKR.Properties.Resources.button1;
            this.pictureBox4.Location = new System.Drawing.Point(487, 374);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::VKR.Properties.Resources.button1;
            this.pictureBox3.Location = new System.Drawing.Point(487, 317);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::VKR.Properties.Resources.button1;
            this.pictureBox2.Location = new System.Drawing.Point(129, 374);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 27;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VKR.Properties.Resources.button1;
            this.pictureBox1.Location = new System.Drawing.Point(129, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(551, 642);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(83, 13);
            this.labelStatus.TabIndex = 25;
            this.labelStatus.Text = "Выберите порт";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(284, 327);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(24, 32);
            this.buttonPlus.TabIndex = 12;
            this.buttonPlus.Text = "^";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.buttonPlus_Click_1);
            this.buttonPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonPlus_MouseDown);
            this.buttonPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonPlus_MouseUp);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackgroundImage = global::VKR.Properties.Resources.VNIZ1;
            this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMinus.Location = new System.Drawing.Point(284, 365);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(24, 33);
            this.buttonMinus.TabIndex = 13;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.buttonMinus_Click_1);
            this.buttonMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonMinus_MouseDown);
            // 
            // buttonNull
            // 
            this.buttonNull.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNull.Location = new System.Drawing.Point(314, 347);
            this.buttonNull.Name = "buttonNull";
            this.buttonNull.Size = new System.Drawing.Size(18, 29);
            this.buttonNull.TabIndex = 14;
            this.buttonNull.Text = "0";
            this.buttonNull.UseVisualStyleBackColor = true;
            this.buttonNull.Click += new System.EventHandler(this.buttonNull_Click);
            // 
            // buttonNeutral
            // 
            this.buttonNeutral.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNeutral.Location = new System.Drawing.Point(71, 365);
            this.buttonNeutral.Name = "buttonNeutral";
            this.buttonNeutral.Size = new System.Drawing.Size(52, 31);
            this.buttonNeutral.TabIndex = 21;
            this.buttonNeutral.Text = "Н";
            this.buttonNeutral.UseVisualStyleBackColor = true;
            this.buttonNeutral.Click += new System.EventHandler(this.buttonNeutral_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 667);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCabin);
            this.Controls.Add(this.comboBoxCabin);
            this.Controls.Add(this.comboBoxAdress);
            this.Controls.Add(this.labelAdress);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.labelCom);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelPositionNum;
        private System.Windows.Forms.Label labelLights;
        private System.Windows.Forms.Label labelCabin;
        private System.Windows.Forms.Label labelAdress;
        private System.Windows.Forms.Label labelCom;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button buttonNull;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.ComboBox comboBoxCabin;
        private System.Windows.Forms.Button buttonNeutral;
        private System.Windows.Forms.ComboBox comboBoxAdress;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label labelLight;
        private System.Windows.Forms.Label labelStatus1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label labelReversorNum;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label labelModeNum;
        private System.Windows.Forms.Panel panel7;
    }
}

