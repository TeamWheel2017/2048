namespace _2048
{
	partial class ProgramInfo
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("함초롬돋움", 20F, System.Drawing.FontStyle.Bold);
			this.label1.Location = new System.Drawing.Point(0, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(338, 63);
			this.label1.TabIndex = 0;
			this.label1.Text = "<2048>";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("함초롬돋움", 12F);
			this.label2.Location = new System.Drawing.Point(0, 109);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(338, 63);
			this.label2.TabIndex = 0;
			this.label2.Text = "Team Wheel";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("함초롬돋움", 9F);
			this.label4.Location = new System.Drawing.Point(0, 189);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(338, 32);
			this.label4.TabIndex = 0;
			this.label4.Text = "제작시작 : 2017.07.21.";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("함초롬돋움", 9F);
			this.label5.Location = new System.Drawing.Point(0, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(338, 32);
			this.label5.TabIndex = 0;
			this.label5.Text = "제작종료 : 2017.07.26.";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("함초롬돋움", 9F);
			this.label6.Location = new System.Drawing.Point(0, 68);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(338, 32);
			this.label6.TabIndex = 0;
			this.label6.Text = "V.1.0";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// linkLabel1
			// 
			this.linkLabel1.Font = new System.Drawing.Font("함초롬돋움", 9F);
			this.linkLabel1.Location = new System.Drawing.Point(0, 275);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(338, 25);
			this.linkLabel1.TabIndex = 1;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://github.com/TeamWheel2017/";
			this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("함초롬돋움", 9F);
			this.button1.Location = new System.Drawing.Point(109, 325);
			this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(120, 42);
			this.button1.TabIndex = 2;
			this.button1.Text = "확인";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// ProgramInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(338, 380);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.linkLabel1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("함초롬돋움", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ProgramInfo";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "확인";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.Button button1;
	}
}