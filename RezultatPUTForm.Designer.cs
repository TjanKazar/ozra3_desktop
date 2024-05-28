namespace ozra3_desktop
{
	partial class RezultatPUTForm
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
			label1 = new Label();
			label2 = new Label();
			label4 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(335, 160);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(335, 231);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 1;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(365, 142);
			label1.Name = "label1";
			label1.Size = new Size(30, 15);
			label1.TabIndex = 3;
			label1.Text = "Ime:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(365, 213);
			label2.Name = "label2";
			label2.Size = new Size(27, 15);
			label2.TabIndex = 4;
			label2.Text = "Bib:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 20F);
			label4.Location = new Point(203, 69);
			label4.Name = "label4";
			label4.Size = new Size(384, 37);
			label4.TabIndex = 6;
			label4.Text = "Najdi Rezultat za Spreminjanje:";
			// 
			// button1
			// 
			button1.Location = new Point(335, 361);
			button1.Name = "button1";
			button1.Size = new Size(100, 42);
			button1.TabIndex = 7;
			button1.Text = "Išči";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// RezultatPUTForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "RezultatPUTForm";
			Text = "RezultatPUTForm";
			Load += RezultatPUTForm_Load;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Label label1;
		private Label label2;
		private Label label4;
		private Button button1;
	}
}