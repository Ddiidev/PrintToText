using System.Drawing;

namespace PrintToText
{
	public class RectangleScreen
	{
		private Point Location { get; set; }
		private Size Dimension { get; set; }
		private Point EndLocation { get; set; }

		#region LOCATION
		public int X
		{
			get => Location.X;
			set => Location = new Point(value, Location.Y);
		}
		public int Y
		{
			get => Location.Y;
			set => Location = new Point(Location.X, value);
		}
		#endregion

		#region END_LOCATION

		public int EndX
		{
			get => EndLocation.X;
			set => EndLocation = new Point(value, EndLocation.Y);
		}
		public int EndY
		{
			get => EndLocation.Y;
			set => EndLocation = new Point(EndLocation.X, value);
		}

		#endregion

		#region DIMMENSION
		public int Width
		{
			get => Dimension.Width;
			set => Dimension = new Size(value, Dimension.Height);
		}
		public int Height
		{
			get => Dimension.Height;
			set => Dimension = new Size(Dimension.Width, value);
		}
		#endregion

	}
}