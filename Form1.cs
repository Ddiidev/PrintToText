using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace PrintToText
{
	public partial class frm : Form
	{
		static RectangleScreen RecScreen = new RectangleScreen();
		public static bool MousePrecioned { get; private set; }

		public static int HeightPX = Screen.PrimaryScreen.Bounds.Width;
		public static int WidthPX = Screen.PrimaryScreen.Bounds.Width;
		public static Bitmap Bmp_screen;
		public Language Lang { get; set; } = new Language(Language.Langs.english);
		public struct Language
		{
			public string language { get; private set; }
			public Language(Langs lng)
			{
				language = lng is Langs.portugues ? "por" : "eng";
			}

			public enum Langs
			{
				portugues = 'p',
				english = 'e'
			}
		}

		public frm()
		{
			printScreen();
			InitializeComponent();
		}

		public async Task ExecuteRead()
		{
			var BmpLocal = CropBitmap();
			var text = ImageToText(BmpLocal);

			if (text.Length > 0)
				try
				{
					Clipboard.SetText(text);
				}
				catch
				{
					try
					{
						Clipboard.SetText(text);
					}
					catch { }
				}

			Close();
		}
		public Bitmap CropBitmap()
		{
			if (RecScreen.Width < 30 & RecScreen.Height < 30)
				Close();

			var g = Graphics.FromImage(Bmp_screen);

			g.CopyFromScreen(
				RecScreen.X, RecScreen.Y,
				RecScreen.EndX, RecScreen.EndY,
				new Size(RecScreen.Width, RecScreen.Height)
			);

			var bitmap = Bmp_screen.Clone(new Rectangle(
				new Point(RecScreen.X, RecScreen.Y),
				new Size(RecScreen.Width, RecScreen.Height)
			), System.Drawing.Imaging.PixelFormat.Format32bppArgb);

			return bitmap;
		}
		public string ImageToText(Bitmap ImageScreen)
		{
			if (ImageScreen.Width < 30 && ImageScreen.Height < 30)
				Close();

			var text = "";
			try
			{
				var ocr = new TesseractEngine(@"./tessdata", Lang.language);

				text = ocr.Process(ImageScreen).GetText();
			} catch (TesseractException e)
			{
				MessageBox.Show($"{e.Data.Keys}|{e.Data.Values} {e.Message}");
			}

			return text;
		}
		private void pic_MouseUp(object sender, MouseEventArgs e)
		{
			Hide();
			RecScreen.EndX = e.X - 1;
			RecScreen.EndY = e.Y - 1;
			ExecuteRead();
			MousePrecioned = false;
		}
		private void Pic_MouseMove(object sender, MouseEventArgs e)
		{
			if (MousePrecioned)
			{
				Bitmap BmpLocal = new Bitmap(pic.Width, pic.Height);

				RecScreen.Height = e.Y - (RecScreen.Y);
				RecScreen.Width = e.X - (RecScreen.X);

				var LocationRec = new Point(RecScreen.X, RecScreen.Y);
				var SizeRec = new Size(RecScreen.Width, RecScreen.Height);

				using (var Graph = Graphics.FromImage(BmpLocal))
				{
					var Pencil = new Pen(Color.Red, 2);
					var Rec = new Rectangle(LocationRec, SizeRec);
					Pencil.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

					Graph.DrawRectangle(Pencil, Rec);
				}

				pic.Image = BmpLocal;
			}
		}
		private void pic_MouseDown(object sender, MouseEventArgs e)
		{
			customPanel1.TransparencyKey = 100;
			customPanel1.Visible = false;
			t.Stop();

			MousePrecioned = true;
			RecScreen.X = e.X - 1;
			RecScreen.Y = e.Y - 1;

		}
		public async Task printScreen()
		{
			await Task.Run(() =>
			{
				Bmp_screen = new Bitmap(WidthPX, HeightPX);
				var g = Graphics.FromImage(Bmp_screen);

				g.CopyFromScreen(Point.Empty, Point.Empty, Screen.PrimaryScreen.Bounds.Size);

				BackgroundImage = Bmp_screen;
				pic.Image = Bmp_screen;
			});
		}
		private void frm_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 27)
				Close();
			else if (e.KeyChar == 'e')
			{
				Lang = new Language(Language.Langs.english);
				customPanel1.Visible = true;
				t.Start();
			}
			else if (e.KeyChar == 'p')
			{
				Lang = new Language(Language.Langs.portugues);
				customPanel1.Visible = true;
				t.Start();
			}
			lb.Text = Lang.language;
		}
		private void t_Tick(object sender, EventArgs e)
		{
			t.Stop();
			Task.Delay(500);
			customPanel1.Visible = false;
		}
	}
}
