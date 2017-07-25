using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
	public partial class Cell : Control
	{
		public Cell()
		{
			InitializeComponent();
		}

		protected override void OnPaint(PaintEventArgs pe)
		{
			base.OnPaint(pe);

			Rectangle rectArea = this.ClientRectangle;

			using (SolidBrush BGBrush = new SolidBrush(this.BackColor))
			using (SolidBrush TxtBrush = new SolidBrush(Color.Black))
			using (Graphics formGraphics = pe.Graphics)
			{
				formGraphics.FillRectangle(BGBrush, rectArea);

				using (Font font = new Font(FontFamily.GenericSansSerif, 25))
				{
					SizeF txtLength = formGraphics.MeasureString(Text, font);

					PointF centerPt = new PointF()
					{
						X = (rectArea.Width - txtLength.Width) / 2,
						Y = (rectArea.Height - txtLength.Height) / 2
					};

					formGraphics.DrawString(Text, font, TxtBrush, centerPt);
				}
			}
		}
	}
}
