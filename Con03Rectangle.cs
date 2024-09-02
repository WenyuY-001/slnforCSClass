using System;
using GDF;

public class Con03Rectangle
{
	double width { set; get; }
	double height { set; get; }
	public Con03Rectangle()
	{
		width = 0;
		height = 0;
	}
	public double Area
	{
		get
		{
			return width * height;
		}
	}
	public double Perimeter
	{
		get
		{
			return 2 * (width + height);
		}
	}
	public void getData()
	{
		double _width = 0;
		double _height = 0;
		do
		{
			Console.Clear();
			Console.WriteLine("输入宽度: ");
			bool isOk1 = double.TryParse(Console.ReadLine(), out _width);
			Console.WriteLine("输入高度: ");
			bool isOk2 = double.TryParse(Console.ReadLine(), out _height);
			if (!isOk1 || !isOk2)
			{
				Whatforshow.Show_shurencuowu("这不是合法的数字!");
				continue;
			}
			width = _width;
			height = _height;
			break;
		} while (true);
	}
	public void display()
	{
		Console.WriteLine("面积: {0}", Area);
		Console.WriteLine("周长: {0}", Perimeter);
		Whatforshow.Show_queren();
	}
}
