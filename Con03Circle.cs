using System;
using GDF;

public class Con03Circle
{
	double r { set; get; }
	public Con03Circle()
	{
		r = 1.0;
	}
	double Area
	{
		get
		{
			return Math.PI * r * r;
		}
	}
	double Perimeter
	{
		get
		{
			return 2 * Math.PI * r;
		}
	}
	public void getData()
	{
		double _r = 0;
		do
		{
			Console.Clear();
			Console.WriteLine("输入半径: ");
			bool isOk = double.TryParse(Console.ReadLine(), out _r);
			if (!isOk)
			{
				Whatforshow.Show_shurencuowu("这不是合法的数字!");
				continue;
			}
			if (_r <= 0)
			{
				Whatforshow.Show_shurencuowu("半径必须大于0!");
				continue;
			}
			r = _r;
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
