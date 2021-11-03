namespace WindowsFormsLocomotive
{
	partial class FormParking
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
			this.pictureBoxParking = new System.Windows.Forms.PictureBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.buttonTakeLocomotive = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
			this.buttonAddParking = new System.Windows.Forms.Button();
			this.listBoxParkings = new System.Windows.Forms.ListBox();
			this.buttonDelParking = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// pictureBoxParking
			// 
			this.pictureBoxParking.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.pictureBoxParking.Location = new System.Drawing.Point(0, 1);
			this.pictureBoxParking.Name = "pictureBoxParking";
			this.pictureBoxParking.Size = new System.Drawing.Size(1011, 605);
			this.pictureBoxParking.TabIndex = 0;
			this.pictureBoxParking.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.buttonTakeLocomotive);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.maskedTextBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(1018, 499);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(147, 107);
			this.groupBox1.TabIndex = 3;
			this.groupBox1.TabStop = false;
			// 
			// buttonTakeLocomotive
			// 
			this.buttonTakeLocomotive.Location = new System.Drawing.Point(7, 78);
			this.buttonTakeLocomotive.Name = "buttonTakeLocomotive";
			this.buttonTakeLocomotive.Size = new System.Drawing.Size(75, 23);
			this.buttonTakeLocomotive.TabIndex = 3;
			this.buttonTakeLocomotive.Text = "Забрать";
			this.buttonTakeLocomotive.UseVisualStyleBackColor = true;
			this.buttonTakeLocomotive.Click += new System.EventHandler(this.buttonTakeLocomotive_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(7, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(42, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Место:";
			// 
			// maskedTextBox
			// 
			this.maskedTextBox.Location = new System.Drawing.Point(57, 45);
			this.maskedTextBox.Name = "maskedTextBox";
			this.maskedTextBox.Size = new System.Drawing.Size(41, 20);
			this.maskedTextBox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Забрать машину";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(1040, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(60, 13);
			this.label3.TabIndex = 4;
			this.label3.Text = "Парковки:";
			// 
			// textBoxNewLevelName
			// 
			this.textBoxNewLevelName.Location = new System.Drawing.Point(1017, 36);
			this.textBoxNewLevelName.Name = "textBoxNewLevelName";
			this.textBoxNewLevelName.Size = new System.Drawing.Size(156, 20);
			this.textBoxNewLevelName.TabIndex = 5;
			// 
			// buttonAddParking
			// 
			this.buttonAddParking.Location = new System.Drawing.Point(1017, 63);
			this.buttonAddParking.Name = "buttonAddParking";
			this.buttonAddParking.Size = new System.Drawing.Size(136, 23);
			this.buttonAddParking.TabIndex = 6;
			this.buttonAddParking.Text = "Добавить парковку";
			this.buttonAddParking.UseVisualStyleBackColor = true;
			this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
			// 
			// listBoxParkings
			// 
			this.listBoxParkings.FormattingEnabled = true;
			this.listBoxParkings.Location = new System.Drawing.Point(1017, 105);
			this.listBoxParkings.Name = "listBoxParkings";
			this.listBoxParkings.Size = new System.Drawing.Size(120, 95);
			this.listBoxParkings.TabIndex = 7;
			this.listBoxParkings.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
			// 
			// buttonDelParking
			// 
			this.buttonDelParking.Location = new System.Drawing.Point(1017, 207);
			this.buttonDelParking.Name = "buttonDelParking";
			this.buttonDelParking.Size = new System.Drawing.Size(136, 23);
			this.buttonDelParking.TabIndex = 8;
			this.buttonDelParking.Text = "Удалить парковку";
			this.buttonDelParking.UseVisualStyleBackColor = true;
			this.buttonDelParking.Click += new System.EventHandler(this.buttonDelParking_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(1025, 405);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(128, 74);
			this.button1.TabIndex = 9;
			this.button1.Text = "Добавить локомотив";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.buttonSetLocomotive_Click);
			// 
			// FormParking
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1177, 607);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.buttonDelParking);
			this.Controls.Add(this.listBoxParkings);
			this.Controls.Add(this.buttonAddParking);
			this.Controls.Add(this.textBoxNewLevelName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.pictureBoxParking);
			this.Name = "FormParking";
			this.Text = "Парковка";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxParking;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button buttonTakeLocomotive;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.MaskedTextBox maskedTextBox;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonDelParking;
		private System.Windows.Forms.Button button1;
	}
}