namespace ozra3_desktop
{
	partial class DELETETekmovanje
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
			label2 = new Label();
			label1 = new Label();
			textBox2 = new TextBox();
			textBox1 = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(332, 168);
			label2.Name = "label2";
			label2.Size = new Size(76, 15);
			label2.TabIndex = 10;
			label2.Text = "Leto izvedbe:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(325, 87);
			label1.Name = "label1";
			label1.Size = new Size(96, 15);
			label1.TabIndex = 9;
			label1.Text = "Ime Tekmovanja:";
			// 
			// textBox2
			// 
			textBox2.Location = new Point(321, 186);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 8;
			// 
			// textBox1
			// 
			textBox1.Location = new Point(321, 105);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 7;
			// 
			// button1
			// 
			button1.Location = new Point(332, 335);
			button1.Name = "button1";
			button1.Size = new Size(75, 23);
			button1.TabIndex = 6;
			button1.Text = "Najdi";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// FindTekmovanjeDELETEForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Controls.Add(button1);
			Name = "FindTekmovanjeDELETEForm";
			Text = "FindTekmovanjeDELETEForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private Label label1;
		private TextBox textBox2;
		private TextBox textBox1;
		private Button button1;
	}
}