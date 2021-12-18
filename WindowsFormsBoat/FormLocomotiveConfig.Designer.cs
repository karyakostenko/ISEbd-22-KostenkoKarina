namespace WindowsFormsLocomotive
{
    partial class FormLocomotiveConfig
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
			this.checkAkum = new System.Windows.Forms.CheckBox();
			this.checkRoga = new System.Windows.Forms.CheckBox();
			this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
			this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBoxLocomotive = new System.Windows.Forms.PictureBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.labelEletrovoz = new System.Windows.Forms.Label();
			this.labelLocomotive = new System.Windows.Forms.Label();
			this.panelLocomotive = new System.Windows.Forms.Panel();
			this.Цвета = new System.Windows.Forms.GroupBox();
			this.panelGrey = new System.Windows.Forms.Panel();
			this.panelGreen = new System.Windows.Forms.Panel();
			this.panelBlack = new System.Windows.Forms.Panel();
			this.panelWhite = new System.Windows.Forms.Panel();
			this.panelBlue = new System.Windows.Forms.Panel();
			this.panelYellow = new System.Windows.Forms.Panel();
			this.panelRed = new System.Windows.Forms.Panel();
			this.panelInfo = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.labelBaseColor = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.buttonCancel = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocomotive)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.panelLocomotive.SuspendLayout();
			this.Цвета.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.checkAkum);
			this.groupBox1.Controls.Add(this.checkRoga);
			this.groupBox1.Controls.Add(this.numericUpDownWeight);
			this.groupBox1.Controls.Add(this.numericUpDownMaxSpeed);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(3, 189);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(307, 127);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Параметры";
			// 
			// checkAkum
			// 
			this.checkAkum.AutoSize = true;
			this.checkAkum.Location = new System.Drawing.Point(208, 63);
			this.checkAkum.Name = "checkAkum";
			this.checkAkum.Size = new System.Drawing.Size(92, 17);
			this.checkAkum.TabIndex = 5;
			this.checkAkum.Text = "Аккумулятор";
			this.checkAkum.UseVisualStyleBackColor = true;
			// 
			// checkRoga
			// 
			this.checkRoga.AutoSize = true;
			this.checkRoga.Location = new System.Drawing.Point(208, 25);
			this.checkRoga.Name = "checkRoga";
			this.checkRoga.Size = new System.Drawing.Size(50, 17);
			this.checkRoga.TabIndex = 6;
			this.checkRoga.Text = "Рога";
			this.checkRoga.UseVisualStyleBackColor = true;
			// 
			// numericUpDownWeight
			// 
			this.numericUpDownWeight.Location = new System.Drawing.Point(72, 101);
			this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownWeight.Name = "numericUpDownWeight";
			this.numericUpDownWeight.Size = new System.Drawing.Size(57, 20);
			this.numericUpDownWeight.TabIndex = 3;
			this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// numericUpDownMaxSpeed
			// 
			this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(72, 50);
			this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
			this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
			this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
			this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(57, 20);
			this.numericUpDownMaxSpeed.TabIndex = 2;
			this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(23, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Вес лодки";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(23, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(87, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Макс. скорость";
			// 
			// pictureBoxLocomotive
			// 
			this.pictureBoxLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxLocomotive.ErrorImage = null;
			this.pictureBoxLocomotive.InitialImage = null;
			this.pictureBoxLocomotive.Location = new System.Drawing.Point(25, 17);
			this.pictureBoxLocomotive.Name = "pictureBoxLocomotive";
			this.pictureBoxLocomotive.Size = new System.Drawing.Size(632, 263);
			this.pictureBoxLocomotive.TabIndex = 1;
			this.pictureBoxLocomotive.TabStop = false;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.labelEletrovoz);
			this.groupBox2.Controls.Add(this.labelLocomotive);
			this.groupBox2.Location = new System.Drawing.Point(84, 69);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(150, 114);
			this.groupBox2.TabIndex = 2;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Тип кузова";
			// 
			// labelEletrovoz
			// 
			this.labelEletrovoz.AllowDrop = true;
			this.labelEletrovoz.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelEletrovoz.Location = new System.Drawing.Point(23, 68);
			this.labelEletrovoz.Name = "labelEletrovoz";
			this.labelEletrovoz.Size = new System.Drawing.Size(106, 31);
			this.labelEletrovoz.TabIndex = 3;
			this.labelEletrovoz.Text = "Электровоз";
			this.labelEletrovoz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelEletrovoz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelElectrovoz_MouseDown);
			// 
			// labelLocomotive
			// 
			this.labelLocomotive.AllowDrop = true;
			this.labelLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelLocomotive.Location = new System.Drawing.Point(23, 22);
			this.labelLocomotive.Name = "labelLocomotive";
			this.labelLocomotive.Size = new System.Drawing.Size(106, 31);
			this.labelLocomotive.TabIndex = 3;
			this.labelLocomotive.Text = "Локомотив";
			this.labelLocomotive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelLocomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLocomotive_MouseDown);
			// 
			// panelLocomotive
			// 
			this.panelLocomotive.AllowDrop = true;
			this.panelLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panelLocomotive.Controls.Add(this.pictureBoxLocomotive);
			this.panelLocomotive.Location = new System.Drawing.Point(338, 16);
			this.panelLocomotive.Name = "panelLocomotive";
			this.panelLocomotive.Size = new System.Drawing.Size(676, 294);
			this.panelLocomotive.TabIndex = 3;
			this.panelLocomotive.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragDrop);
			this.panelLocomotive.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragEnter);
			// 
			// Цвета
			// 
			this.Цвета.Controls.Add(this.panelGrey);
			this.Цвета.Controls.Add(this.panelGreen);
			this.Цвета.Controls.Add(this.panelBlack);
			this.Цвета.Controls.Add(this.panelWhite);
			this.Цвета.Controls.Add(this.panelBlue);
			this.Цвета.Controls.Add(this.panelYellow);
			this.Цвета.Controls.Add(this.panelRed);
			this.Цвета.Controls.Add(this.panelInfo);
			this.Цвета.Controls.Add(this.label4);
			this.Цвета.Controls.Add(this.labelBaseColor);
			this.Цвета.Location = new System.Drawing.Point(1020, 16);
			this.Цвета.Name = "Цвета";
			this.Цвета.Size = new System.Drawing.Size(236, 197);
			this.Цвета.TabIndex = 4;
			this.Цвета.TabStop = false;
			this.Цвета.Text = "Цвета";
			// 
			// panelGrey
			// 
			this.panelGrey.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.panelGrey.Location = new System.Drawing.Point(195, 147);
			this.panelGrey.Name = "panelGrey";
			this.panelGrey.Size = new System.Drawing.Size(41, 44);
			this.panelGrey.TabIndex = 5;
			this.panelGrey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelGreen
			// 
			this.panelGreen.BackColor = System.Drawing.Color.Chartreuse;
			this.panelGreen.Location = new System.Drawing.Point(133, 147);
			this.panelGreen.Name = "panelGreen";
			this.panelGreen.Size = new System.Drawing.Size(41, 44);
			this.panelGreen.TabIndex = 5;
			this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlack
			// 
			this.panelBlack.BackColor = System.Drawing.Color.Black;
			this.panelBlack.Location = new System.Drawing.Point(71, 147);
			this.panelBlack.Name = "panelBlack";
			this.panelBlack.Size = new System.Drawing.Size(41, 44);
			this.panelBlack.TabIndex = 7;
			this.panelBlack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelWhite
			// 
			this.panelWhite.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.panelWhite.Location = new System.Drawing.Point(15, 147);
			this.panelWhite.Name = "panelWhite";
			this.panelWhite.Size = new System.Drawing.Size(41, 44);
			this.panelWhite.TabIndex = 6;
			this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelBlue
			// 
			this.panelBlue.AllowDrop = true;
			this.panelBlue.BackColor = System.Drawing.SystemColors.Highlight;
			this.panelBlue.Location = new System.Drawing.Point(15, 84);
			this.panelBlue.Name = "panelBlue";
			this.panelBlue.Size = new System.Drawing.Size(41, 44);
			this.panelBlue.TabIndex = 5;
			this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelYellow
			// 
			this.panelYellow.BackColor = System.Drawing.Color.Gold;
			this.panelYellow.Location = new System.Drawing.Point(193, 84);
			this.panelYellow.Name = "panelYellow";
			this.panelYellow.Size = new System.Drawing.Size(40, 44);
			this.panelYellow.TabIndex = 3;
			this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelRed
			// 
			this.panelRed.BackColor = System.Drawing.Color.Red;
			this.panelRed.Location = new System.Drawing.Point(133, 84);
			this.panelRed.Name = "panelRed";
			this.panelRed.Size = new System.Drawing.Size(41, 44);
			this.panelRed.TabIndex = 4;
			this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// panelInfo
			// 
			this.panelInfo.BackColor = System.Drawing.SystemColors.Info;
			this.panelInfo.Location = new System.Drawing.Point(71, 84);
			this.panelInfo.Name = "panelInfo";
			this.panelInfo.Size = new System.Drawing.Size(43, 44);
			this.panelInfo.TabIndex = 3;
			this.panelInfo.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.panelInfo.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			this.panelInfo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
			// 
			// label4
			// 
			this.label4.AllowDrop = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(133, 34);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 29);
			this.label4.TabIndex = 1;
			this.label4.Text = "Доп. цвет";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.label4.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
			this.label4.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragEnter);
			// 
			// labelBaseColor
			// 
			this.labelBaseColor.AllowDrop = true;
			this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelBaseColor.Location = new System.Drawing.Point(15, 33);
			this.labelBaseColor.Name = "labelBaseColor";
			this.labelBaseColor.Size = new System.Drawing.Size(99, 30);
			this.labelBaseColor.TabIndex = 0;
			this.labelBaseColor.Text = "Основной цвет";
			this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
			this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1134, 219);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 5;
			this.button1.Text = "Добавить";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// buttonCancel
			// 
			this.buttonCancel.Location = new System.Drawing.Point(1134, 252);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 6;
			this.buttonCancel.Text = "Отмена";
			this.buttonCancel.UseVisualStyleBackColor = true;
			// 
			// FormLocomotiveConfig
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1268, 325);
			this.Controls.Add(this.buttonCancel);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.Цвета);
			this.Controls.Add(this.panelLocomotive);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "FormLocomotiveConfig";
			this.Text = "FormLocomotiveConfig";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocomotive)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.panelLocomotive.ResumeLayout(false);
			this.Цвета.ResumeLayout(false);
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkAkum;
        private System.Windows.Forms.CheckBox checkRoga;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxLocomotive;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelEletrovoz;
        private System.Windows.Forms.Label labelLocomotive;
        private System.Windows.Forms.Panel panelLocomotive;
        private System.Windows.Forms.GroupBox Цвета;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelBaseColor;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonCancel;
    }
}