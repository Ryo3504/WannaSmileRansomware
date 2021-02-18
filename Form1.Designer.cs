
namespace WannaSmile
{
	partial class WannaSmileForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WannaSmileForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.tKey = new System.Windows.Forms.TextBox();
			this.btnCheck = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnGetKey = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Controls.Add(this.panel4);
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Controls.Add(this.panel2);
			this.panel1.Location = new System.Drawing.Point(2, 1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(495, 223);
			this.panel1.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
			this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox1.Location = new System.Drawing.Point(0, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(207, 217);
			this.pictureBox1.TabIndex = 1;
			this.pictureBox1.TabStop = false;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.tKey);
			this.panel4.Controls.Add(this.btnCheck);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Location = new System.Drawing.Point(213, 181);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(279, 39);
			this.panel4.TabIndex = 0;
			// 
			// tKey
			// 
			this.tKey.Location = new System.Drawing.Point(44, 10);
			this.tKey.Name = "tKey";
			this.tKey.Size = new System.Drawing.Size(141, 21);
			this.tKey.TabIndex = 5;
			// 
			// btnCheck
			// 
			this.btnCheck.Location = new System.Drawing.Point(191, 9);
			this.btnCheck.Name = "btnCheck";
			this.btnCheck.Size = new System.Drawing.Size(75, 23);
			this.btnCheck.TabIndex = 6;
			this.btnCheck.Text = "Send";
			this.btnCheck.UseVisualStyleBackColor = true;
			this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label3.Location = new System.Drawing.Point(10, 13);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 15);
			this.label3.TabIndex = 1;
			this.label3.Text = "Key";
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnSend);
			this.panel3.Controls.Add(this.btnGetKey);
			this.panel3.Controls.Add(this.label2);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Controls.Add(this.textBox2);
			this.panel3.Controls.Add(this.textBox1);
			this.panel3.Location = new System.Drawing.Point(213, 100);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(279, 75);
			this.panel3.TabIndex = 0;
			// 
			// btnSend
			// 
			this.btnSend.Location = new System.Drawing.Point(191, 13);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(75, 23);
			this.btnSend.TabIndex = 2;
			this.btnSend.Text = "Decrypt";
			this.btnSend.UseVisualStyleBackColor = true;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnGetKey
			// 
			this.btnGetKey.Location = new System.Drawing.Point(191, 40);
			this.btnGetKey.Name = "btnGetKey";
			this.btnGetKey.Size = new System.Drawing.Size(75, 23);
			this.btnGetKey.TabIndex = 4;
			this.btnGetKey.Text = "Get Key";
			this.btnGetKey.UseVisualStyleBackColor = true;
			this.btnGetKey.Click += new System.EventHandler(this.btnGetKey_Click);
			this.btnGetKey.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnGetKey_MouseClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(10, 44);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "Seri";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.label1.Location = new System.Drawing.Point(10, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(28, 15);
			this.label1.TabIndex = 1;
			this.label1.Text = "Key";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(44, 14);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(141, 21);
			this.textBox2.TabIndex = 0;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(44, 41);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(141, 21);
			this.textBox1.TabIndex = 1;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.listBox1);
			this.panel2.Location = new System.Drawing.Point(213, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(279, 94);
			this.panel2.TabIndex = 0;
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Items.AddRange(new object[] {
            "Because I neeed a little money to buy a Husky",
            "So I gave you this Ransomware",
            "Note: Input exactly Key and Seri number ",
            "To decryption your data",
            "I don\'t need much money",
            "So send me $1000 or $2000 if you want :))",
            "Or you need to click 1000 times [Get Key]",
            "This is just a joke. Have a nice day,guys!"});
			this.listBox1.Location = new System.Drawing.Point(0, 0);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(276, 94);
			this.listBox1.TabIndex = 0;
			// 
			// WannaSmileForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(498, 226);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.IsMdiContainer = true;
			this.Name = "WannaSmileForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wanna Smile V1.0";
			this.TopMost = true;
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox tKey;
		private System.Windows.Forms.Button btnCheck;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnGetKey;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

