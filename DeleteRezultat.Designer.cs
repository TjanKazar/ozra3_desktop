namespace ozra3_desktop
{
	partial class DeleteRezultat
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
			bib = new TextBox();
			name = new TextBox();
			button1 = new Button();
			SuspendLayout();
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(369, 172);
			label2.Name = "label2";
			label2.Size = new Size(27, 15);
			label2.TabIndex = 15;
			label2.Text = "Bib:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(369, 91);
			label1.Name = "label1";
			label1.Size = new Size(30, 15);
			label1.TabIndex = 14;
			label1.Text = "Ime:";
			// 
			// bib
			// 
			bib.Location = new Point(333, 190);
			bib.Name = "bib";
			bib.Size = new Size(100, 23);
			bib.TabIndex = 13;
			// 
			// name
			// 
			name.Location = new Point(333, 109);
			name.Name = "name";
			name.Size = new Size(100, 23);
			name.TabIndex = 12;
			// 
			// button1
			// 
			button1.Location = new Point(344, 311);
			button1.Name = "button1";
			button1.Size = new Size(75, 41);
			button1.TabIndex = 11;
			button1.Text = "Izbriši rezultat";
			button1.UseVisualStyleBackColor = true;
			button1.Click += button1_Click;
			// 
			// DeleteRezultat
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(bib);
			Controls.Add(name);
			Controls.Add(button1);
			Name = "DeleteRezultat";
			Text = "DeleteRezultat";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label2;
		private Label label1;
		private TextBox bib;
		private TextBox name;
		private Button button1;
	}
}