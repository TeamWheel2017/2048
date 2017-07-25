namespace _2048
{
	partial class HowTo
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
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("함초롬돋움", 11F);
			this.label1.Location = new System.Drawing.Point(25, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(650, 177);
			this.label1.TabIndex = 0;
			this.label1.Text = "<2048>은 방향키만을 이용해 최대한 큰 수를 만드는 것이 목표인 게임입니다.\r\n방향키를 누루면 전체 타일이 그 방향으로 움직입니다.\r\n만약 같" +
    "은 수를 가진 두 개의 타일이 만나면 더해져 하나로 합쳐집니다.\r\n타일을 움직일 때마다 새로운 2 또는 4 타일이 생깁니다.\r\n더 이상 움직일 " +
    "타일이 없으면 게임 오버입니다.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.button1.Location = new System.Drawing.Point(275, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(150, 50);
			this.button1.TabIndex = 1;
			this.button1.Text = "확인";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// HowTo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 253);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("함초롬돋움", 9F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "HowTo";
			this.Text = "게임 방법";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}