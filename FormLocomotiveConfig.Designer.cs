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
            this.labelElectrovoz = new System.Windows.Forms.Label();
            this.labelLocomotive = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxAkum = new System.Windows.Forms.CheckBox();
            this.checkBoxRoga = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLocomotive = new System.Windows.Forms.Panel();
            this.pictureBoxLocomotive = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelBaseColor = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.panelLocomotive.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocomotive)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelElectrovoz);
            this.groupBox1.Controls.Add(this.labelLocomotive);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 163);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип кузова";
            // 
            // labelElectrovoz
            // 
            this.labelElectrovoz.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelElectrovoz.Location = new System.Drawing.Point(6, 92);
            this.labelElectrovoz.Name = "labelElectrovoz";
            this.labelElectrovoz.Size = new System.Drawing.Size(187, 65);
            this.labelElectrovoz.TabIndex = 1;
            this.labelElectrovoz.Text = "Электровоз";
            this.labelElectrovoz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelElectrovoz.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelElectrovoz_MouseDown);
            // 
            // labelLocomotive
            // 
            this.labelLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelLocomotive.Location = new System.Drawing.Point(7, 20);
            this.labelLocomotive.Name = "labelLocomotive";
            this.labelLocomotive.Size = new System.Drawing.Size(187, 60);
            this.labelLocomotive.TabIndex = 0;
            this.labelLocomotive.Text = "Обычный";
            this.labelLocomotive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelLocomotive.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragDrop);
            this.labelLocomotive.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragEnter);
            this.labelLocomotive.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelLocomotive_MouseDown);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxAkum);
            this.groupBox2.Controls.Add(this.checkBoxRoga);
            this.groupBox2.Controls.Add(this.numericUpDownWeight);
            this.groupBox2.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 145);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Параметры";
            // 
            // checkBoxAkum
            // 
            this.checkBoxAkum.AutoSize = true;
            this.checkBoxAkum.Location = new System.Drawing.Point(162, 94);
            this.checkBoxAkum.Name = "checkBoxAkum";
            this.checkBoxAkum.Size = new System.Drawing.Size(92, 17);
            this.checkBoxAkum.TabIndex = 7;
            this.checkBoxAkum.Text = "Аккумулятор";
            this.checkBoxAkum.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoga
            // 
            this.checkBoxRoga.AutoSize = true;
            this.checkBoxRoga.Location = new System.Drawing.Point(162, 70);
            this.checkBoxRoga.Name = "checkBoxRoga";
            this.checkBoxRoga.Size = new System.Drawing.Size(50, 17);
            this.checkBoxRoga.TabIndex = 6;
            this.checkBoxRoga.Text = "Рога";
            this.checkBoxRoga.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(7, 98);
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
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(7, 46);
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
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
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
            this.label2.Location = new System.Drawing.Point(4, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вес";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Макс. скорость";
            // 
            // panelLocomotive
            // 
            this.panelLocomotive.AllowDrop = true;
            this.panelLocomotive.Controls.Add(this.pictureBoxLocomotive);
            this.panelLocomotive.Location = new System.Drawing.Point(392, 193);
            this.panelLocomotive.Name = "panelLocomotive";
            this.panelLocomotive.Size = new System.Drawing.Size(595, 292);
            this.panelLocomotive.TabIndex = 2;
            this.panelLocomotive.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragDrop);
            this.panelLocomotive.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragEnter);
            // 
            // pictureBoxLocomotive
            // 
            this.pictureBoxLocomotive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLocomotive.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLocomotive.Name = "pictureBoxLocomotive";
            this.pictureBoxLocomotive.Size = new System.Drawing.Size(589, 286);
            this.pictureBoxLocomotive.TabIndex = 0;
            this.pictureBoxLocomotive.TabStop = false;
            this.pictureBoxLocomotive.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragDrop);
            this.pictureBoxLocomotive.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelLocomotive_DragEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel9);
            this.groupBox3.Controls.Add(this.panel8);
            this.groupBox3.Controls.Add(this.panel7);
            this.groupBox3.Controls.Add(this.panel6);
            this.groupBox3.Controls.Add(this.panel5);
            this.groupBox3.Controls.Add(this.panel4);
            this.groupBox3.Controls.Add(this.panel3);
            this.groupBox3.Controls.Add(this.panel2);
            this.groupBox3.Controls.Add(this.labelDopColor);
            this.groupBox3.Controls.Add(this.labelBaseColor);
            this.groupBox3.Location = new System.Drawing.Point(386, 16);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(282, 160);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Цвета";
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Blue;
            this.panel9.Location = new System.Drawing.Point(219, 116);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(37, 26);
            this.panel9.TabIndex = 9;
            this.panel9.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.White;
            this.panel8.Location = new System.Drawing.Point(219, 80);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(37, 30);
            this.panel8.TabIndex = 8;
            this.panel8.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Lime;
            this.panel7.Location = new System.Drawing.Point(145, 116);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(36, 27);
            this.panel7.TabIndex = 7;
            this.panel7.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Black;
            this.panel6.Location = new System.Drawing.Point(145, 80);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(36, 30);
            this.panel6.TabIndex = 6;
            this.panel6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel5.Location = new System.Drawing.Point(74, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(35, 28);
            this.panel5.TabIndex = 5;
            this.panel5.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel4.Location = new System.Drawing.Point(74, 80);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(35, 30);
            this.panel4.TabIndex = 4;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Location = new System.Drawing.Point(6, 117);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(35, 28);
            this.panel3.TabIndex = 3;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Red;
            this.panel2.Location = new System.Drawing.Point(6, 80);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(35, 30);
            this.panel2.TabIndex = 2;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDopColor.Location = new System.Drawing.Point(145, 17);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(121, 39);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelBaseColor
            // 
            this.labelBaseColor.AllowDrop = true;
            this.labelBaseColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBaseColor.Location = new System.Drawing.Point(6, 17);
            this.labelBaseColor.Name = "labelBaseColor";
            this.labelBaseColor.Size = new System.Drawing.Size(118, 39);
            this.labelBaseColor.TabIndex = 0;
            this.labelBaseColor.Text = "Основной цвет";
            this.labelBaseColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBaseColor.Click += new System.EventHandler(this.labelBaseColor_Click);
            this.labelBaseColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelBaseColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(674, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(674, 70);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // FormLocomotiveConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 497);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panelLocomotive);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormLocomotiveConfig";
            this.Text = "Выбор машины";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.panelLocomotive.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocomotive)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label labelElectrovoz;
		private System.Windows.Forms.Label labelLocomotive;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxAkum;
		private System.Windows.Forms.CheckBox checkBoxRoga;
		private System.Windows.Forms.NumericUpDown numericUpDownWeight;
		private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panelLocomotive;
		private System.Windows.Forms.PictureBox pictureBoxLocomotive;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label labelDopColor;
		private System.Windows.Forms.Label labelBaseColor;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button buttonCancel;
	}
}