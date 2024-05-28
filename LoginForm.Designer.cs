namespace ozra3_desktop
{
	partial class LoginForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			textBox1 = new TextBox();
			textBox2 = new TextBox();
			username_label = new Label();
			pass_label = new Label();
			label1 = new Label();
			Login = new Button();
			SuspendLayout();
			// 
			// textBox1
			// 
			textBox1.Location = new Point(210, 213);
			textBox1.Name = "textBox1";
			textBox1.Size = new Size(100, 23);
			textBox1.TabIndex = 0;
			// 
			// textBox2
			// 
			textBox2.Location = new Point(210, 314);
			textBox2.Name = "textBox2";
			textBox2.Size = new Size(100, 23);
			textBox2.TabIndex = 1;
			// 
			// username_label
			// 
			username_label.AutoSize = true;
			username_label.Location = new Point(227, 195);
			username_label.Name = "username_label";
			username_label.Size = new Size(60, 15);
			username_label.TabIndex = 2;
			username_label.Text = "Username";
			// 
			// pass_label
			// 
			pass_label.AutoSize = true;
			pass_label.Location = new Point(230, 285);
			pass_label.Name = "pass_label";
			pass_label.Size = new Size(57, 15);
			pass_label.TabIndex = 3;
			pass_label.Text = "Password";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Comic Sans MS", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
			label1.Location = new Point(50, 86);
			label1.Name = "label1";
			label1.Size = new Size(430, 50);
			label1.TabIndex = 4;
			label1.Text = "Runner App Admin Login";
			// 
			// Login
			// 
			Login.Location = new Point(210, 365);
			Login.Name = "Login";
			Login.Size = new Size(100, 33);
			Login.TabIndex = 5;
			Login.Text = "Login";
			Login.UseVisualStyleBackColor = true;
			Login.Click += Login_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(545, 479);
			Controls.Add(Login);
			Controls.Add(label1);
			Controls.Add(pass_label);
			Controls.Add(username_label);
			Controls.Add(textBox2);
			Controls.Add(textBox1);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox textBox1;
		private TextBox textBox2;
		private Label username_label;
		private Label pass_label;
		private Label label1;
		private Button Login;
	}
}
