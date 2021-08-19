using System.Drawing;
using System.Windows.Forms;

namespace PrintToText
{
	public class CustomPanel : Panel
	{
		public CustomPanel()
		{
			this.Refresh();
		}

		public int TransparencyKey { get; set; } = 20;
		public Color BackColorTransparent { get; set; } = Color.Black;

		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);

			base.BackColor = Color.FromArgb(TransparencyKey, BackColorTransparent);
		}
	}
}
