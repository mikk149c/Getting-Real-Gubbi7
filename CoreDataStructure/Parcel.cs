namespace CoreDataStructure
{
	internal class Parcel
	{
		private double weight;
		private int height;
		private int width;
		private int length;

		public double Weight { get { return weight; } set { weight = value; } }
		public int Height { get { return height; } set { height = value; } }
		public int Width { get { return width; } set { width = value; } }
		public int Length { get { return length; } set { length = value; } }
	}
}