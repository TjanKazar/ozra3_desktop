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
			label3 = new Label();
			fileSystemWatcher1 = new FileSystemWatcher();
			tekmovanje_porocilo = new Button();
			tekmovalec_porocilo = new Button();
			label4 = new Label();
			button7 = new Button();
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
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 238);
			label3.ForeColor = Color.Black;
			label3.Location = new Point(96, 156);
			label3.Name = "label3";
			label3.Size = new Size(77, 21);
			label3.TabIndex = 8;
			label3.Text = "Poročila:";
			// 
			// fileSystemWatcher1
			// 
			fileSystemWatcher1.EnableRaisingEvents = true;
			fileSystemWatcher1.SynchronizingObject = this;
			// 
			// tekmovanje_porocilo
			// 
			tekmovanje_porocilo.BackColor = Color.MediumPurple;
			tekmovanje_porocilo.Font = new Font("Nirmala UI", 10F);
			tekmovanje_porocilo.ForeColor = SystemColors.ButtonHighlight;
			tekmovanje_porocilo.Location = new Point(252, 137);
			tekmovanje_porocilo.Name = "tekmovanje_porocilo";
			tekmovanje_porocilo.Size = new Size(135, 61);
			tekmovanje_porocilo.TabIndex = 10;
			tekmovanje_porocilo.Text = "Tekmovanje";
			tekmovanje_porocilo.UseVisualStyleBackColor = false;
			// 
			// tekmovalec_porocilo
			// 
			tekmovalec_porocilo.BackColor = Color.Salmon;
			tekmovalec_porocilo.Font = new Font("Nirmala UI", 10F);
			tekmovalec_porocilo.ForeColor = SystemColors.ButtonHighlight;
			tekmovalec_porocilo.Location = new Point(453, 137);
			tekmovalec_porocilo.Name = "tekmovalec_porocilo";
			tekmovalec_porocilo.Size = new Size(135, 61);
			tekmovalec_porocilo.TabIndex = 11;
			tekmovalec_porocilo.Text = "Tekmovalec";
			tekmovalec_porocilo.UseVisualStyleBackColor = false;
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
			// MainPage
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(769, 521);
			Controls.Add(button7);
			Controls.Add(label4);
			Controls.Add(tekmovalec_porocilo);
			Controls.Add(tekmovanje_porocilo);
			Controls.Add(label3);
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
		private Label label3;
		private FileSystemWatcher fileSystemWatcher1;
		private Button tekmovanje_porocilo;
		private Button tekmovalec_porocilo;
		private Button button7;
		private Label label4;
	}
}