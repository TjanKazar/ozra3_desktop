namespace ozra3_desktop
{
	partial class MainPage
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
			label1 = new Label();
			button1 = new Button();
			button2 = new Button();
			button3 = new Button();
			label2 = new Label();
			button4 = new Button();
			button5 = new Button();
			button6 = new Button();
			fileSystemWatcher1 = new FileSystemWatcher();
			label4 = new Label();
			button7 = new Button();
			pictureBox3 = new PictureBox();
			pictureBox1 = new PictureBox();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom;
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label1.Location = new Point(54, 365);
			label1.Name = "label1";
			label1.Size = new Size(91, 19);
			label1.TabIndex = 0;
			label1.Text = "Tekmovanja";
			// 
			// button1
			// 
			button1.Anchor = AnchorStyles.Bottom;
			button1.BackColor = Color.DeepSkyBlue;
			button1.Font = new Font("Nirmala UI", 10F);
			button1.ForeColor = SystemColors.ActiveCaptionText;
			button1.Location = new Point(192, 352);
			button1.Name = "button1";
			button1.Size = new Size(113, 44);
			button1.TabIndex = 1;
			button1.Text = "Post New";
			button1.UseVisualStyleBackColor = false;
			button1.Click += button1_Click;
			// 
			// button2
			// 
			button2.Anchor = AnchorStyles.Bottom;
			button2.BackColor = Color.GreenYellow;
			button2.Font = new Font("Nirmala UI", 10F);
			button2.ForeColor = SystemColors.ActiveCaptionText;
			button2.Location = new Point(345, 352);
			button2.Name = "button2";
			button2.Size = new Size(160, 44);
			button2.TabIndex = 2;
			button2.Text = "Change Exsisting";
			button2.UseVisualStyleBackColor = false;
			button2.Click += button2_Click;
			// 
			// button3
			// 
			button3.Anchor = AnchorStyles.Bottom;
			button3.BackColor = Color.IndianRed;
			button3.Font = new Font("Nirmala UI", 10F);
			button3.ForeColor = SystemColors.ActiveCaptionText;
			button3.Location = new Point(543, 352);
			button3.Name = "button3";
			button3.Size = new Size(155, 44);
			button3.TabIndex = 3;
			button3.Text = "Delete Exsisting";
			button3.UseVisualStyleBackColor = false;
			button3.Click += button3_Click;
			// 
			// label2
			// 
			label2.Anchor = AnchorStyles.Bottom;
			label2.AutoSize = true;
			label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label2.Location = new Point(54, 443);
			label2.Name = "label2";
			label2.Size = new Size(62, 19);
			label2.TabIndex = 4;
			label2.Text = "Rezulati";
			label2.Click += label2_Click;
			// 
			// button4
			// 
			button4.Anchor = AnchorStyles.Bottom;
			button4.BackColor = Color.IndianRed;
			button4.Font = new Font("Nirmala UI", 10F);
			button4.ForeColor = SystemColors.ActiveCaptionText;
			button4.Location = new Point(543, 430);
			button4.Name = "button4";
			button4.Size = new Size(155, 44);
			button4.TabIndex = 7;
			button4.Text = "Delete Exsisting";
			button4.UseVisualStyleBackColor = false;
			button4.Click += button4_Click;
			// 
			// button5
			// 
			button5.Anchor = AnchorStyles.Bottom;
			button5.BackColor = Color.GreenYellow;
			button5.Font = new Font("Nirmala UI", 10F);
			button5.ForeColor = SystemColors.ActiveCaptionText;
			button5.Location = new Point(345, 430);
			button5.Name = "button5";
			button5.Size = new Size(160, 44);
			button5.TabIndex = 6;
			button5.Text = "Change Exsisting";
			button5.UseVisualStyleBackColor = false;
			button5.Click += button5_Click;
			// 
			// button6
			// 
			button6.Anchor = AnchorStyles.Bottom;
			button6.BackColor = Color.DeepSkyBlue;
			button6.Font = new Font("Nirmala UI", 10F);
			button6.ForeColor = SystemColors.ActiveCaptionText;
			button6.Location = new Point(192, 430);
			button6.Name = "button6";
			button6.Size = new Size(113, 44);
			button6.TabIndex = 5;
			button6.Text = "Post New";
			button6.UseVisualStyleBackColor = false;
			button6.Click += button6_Click_1;
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(-8, 32);
			label4.Name = "label4";
			label4.Size = new Size(797, 15);
			label4.TabIndex = 12;
			label4.Text = "______________________________________________________________________________________________________________________________________________________________";
			// 
			// button7
			// 
			button7.Location = new Point(12, 12);
			button7.Name = "button7";
			button7.Size = new Size(171, 23);
			button7.TabIndex = 13;
			button7.Text = "pregled vseh tekmovanj:";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// pictureBox3
			// 
			pictureBox3.Image = Properties.Resources.smallsloflag;
			pictureBox3.Location = new Point(648, 4);
			pictureBox3.Name = "pictureBox3";
			pictureBox3.Size = new Size(46, 25);
			pictureBox3.TabIndex = 17;
			pictureBox3.TabStop = false;
			pictureBox3.Click += pictureBox3_Click;
			// 
			// pictureBox1
			// 
			pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
			pictureBox1.Location = new Point(700, 4);
			pictureBox1.Name = "pictureBox1";
			pictureBox1.Size = new Size(39, 25);
			pictureBox1.TabIndex = 18;
			pictureBox1.TabStop = false;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(769, 521);
			Controls.Add(pictureBox1);
			Controls.Add(pictureBox3);
			Controls.Add(button7);
			Controls.Add(label4);
			Controls.Add(button4);
			Controls.Add(button5);
			Controls.Add(button6);
			Controls.Add(label2);
			Controls.Add(button3);
			Controls.Add(button2);
			Controls.Add(button1);
			Controls.Add(label1);
			Name = "MainPage";
			Text = "MainPage";
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
			((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Button button1;
		private Button button2;
		private Button button3;
		private Label label2;
		private Button button4;
		private Button button5;
		private Button button6;
		private FileSystemWatcher fileSystemWatcher1;
		private Button button7;
		private Label label4;
		private PictureBox pictureBox1;
		private PictureBox pictureBox3;
	}
}