﻿namespace ozra3_desktop
{
	partial class FindTekmovanjePUTForm
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
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			textBox3 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			buttonSubmit = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(322, 111);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			textBox1.TextChanged += textBox1_TextChanged;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(322, 191);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 1;
			textBox2.TextChanged += textBox2_TextChanged;
			// 
			// textBox3
			// 
			textBox3.Location = new Point(322, 265);
			textBox3.Name = "textBox3";
			textBox3.Size = new Size(100, 23);
			textBox3.TabIndex = 2;
			textBox3.TextChanged += textBox3_TextChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(326, 93);
			label1.Name = "label1";
			label1.Size = new Size(96, 15);
			label1.TabIndex = 3;
			label1.Text = "Ime Tekmovanja:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(336, 173);
			label2.Name = "label2";
			label2.Size = new Size(76, 15);
			label2.TabIndex = 4;
			label2.Text = "Leto izvedbe:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(295, 247);
			label3.Name = "label3";
			label3.Size = new Size(176, 15);
			label3.TabIndex = 5;
			label3.Text = "Število prijavljenih tekmovalcev:";
			// 
			// buttonSubmit
			// 
			buttonSubmit.Location = new Point(336, 349);
			buttonSubmit.Name = "buttonSubmit";
			buttonSubmit.Size = new Size(75, 23);
			buttonSubmit.TabIndex = 6;
			buttonSubmit.Text = "Dodaj";
			buttonSubmit.UseVisualStyleBackColor = true;
			buttonSubmit.Click += buttonSubmit_Click_1;
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(buttonSubmit);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox3);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Form3";
			Text = "Form3";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button buttonSubmit;
	}
}