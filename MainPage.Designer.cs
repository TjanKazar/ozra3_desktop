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
			button8 = new Button();
			button9 = new Button();
			((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Bottom;
			label1.AutoSize = true;
			label1.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label1.Location = new Point(54, 365);
			label1.Name = "label1";
			label1.Size = new Size(98, 19);
			label1.TabIndex = 0;
			label1.Tag = "i18n:key6";
			label1.Text = "Competitions";
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
			button1.Tag = "i18n:key2";
			button1.Text = "Post new";
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
			button2.Tag = "i18n:key3";
			button2.Text = "Change exsisting";
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
			button3.Tag = "i18n:key4";
			button3.Text = "Delete exsisting";
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
			label2.Size = new Size(57, 19);
			label2.TabIndex = 4;
			label2.Tag = "i18n:key7";
			label2.Text = "Results";
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
			button4.Tag = "i18n:key4";
			button4.Text = "Delete exsisting";
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
			button5.Tag = "i18n:key3";
			button5.Text = "Change exsisting";
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
			button6.Tag = "i18n:key2";
			button6.Text = "Post new";
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
			button7.Tag = "i18n:key5";
			button7.Text = "view all competitions:";
			button7.UseVisualStyleBackColor = true;
			button7.Click += button7_Click;
			// 
			// button8
			// 
			button8.Location = new Point(580, 6);
			button8.Name = "button8";
			button8.Size = new Size(75, 35);
			button8.TabIndex = 19;
			button8.Text = "SLO";
			button8.UseVisualStyleBackColor = true;
			button8.Click += button8_Click;
			// 
			// button9
			// 
			button9.Location = new Point(671, 6);
			button9.Name = "button9";
			button9.Size = new Size(75, 35);
			button9.TabIndex = 20;
			button9.Text = "ENG";
			button9.UseVisualStyleBackColor = true;
			button9.Click += button9_Click;
			// 
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(769, 521);
			Controls.Add(button9);
			Controls.Add(button8);
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
		private Button button9;
		private Button button8;
	}
}