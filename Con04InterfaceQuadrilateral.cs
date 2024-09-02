namespace GDF
{
    interface Con04InterfaceQuadrilateral
    {
        void SetData();
        void Display();
    }
    class Con04IntRectangle : Con04InterfaceQuadrilateral
    {
        double Width { get; set; }
        double Height { get; set; }
        public double Area { get { return Width * Height; } }
        public double Permeter { get { return 2 * (Width + Height); } }
        public void SetData()
        {
            double width = 0;
            double height = 0;
            Console.Write("输入矩形的长：");
            while (!double.TryParse(Console.ReadLine(), out width))
            {
                Console.Write("输入错误，重新输入矩形的长：");
            }
            Console.Write("输入矩形的宽：");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("输入错误，重新输入矩形的宽：");
            }
            Width = width;
            Height = height;
            Whatforshow.Show_shurencuowu("输入完成。");
        }
        public void Display()
        {
            Console.WriteLine($"矩形的面积为：{Area:F4}矩形的周长为：{Permeter:F4}");
            Whatforshow.Show_queren();
        }
    }
    class Con04IntTrapezoid : Con04InterfaceQuadrilateral
    {
        double Liftside { set; get; }
        double Rightside { set; get; }
        double Height { set; get; }
        double Upside { set; get; }
        double Downside { set; get; }
        public double Area { get { return (Upside + Downside) * Height / 2; } }
        public double Permeter { get { return Upside + Downside + Liftside + Rightside; } }
        public void SetData()
        {
            double upside = 0;
            double downside = 0;
            double liftside = 0;
            double rightside = 0;
            double height = 0;
            Console.Write("输入梯形的上底的长：");
            while (!double.TryParse(Console.ReadLine(), out upside))
            {
                Console.Write("输入错误，重新输入梯形的上底的长：");
            }
            Console.Write("输入梯形的下底的长：");
            while (!double.TryParse(Console.ReadLine(), out downside))
            {
                Console.Write("输入错误，重新输入梯形的上底的长：");
            }
            Console.Write("输入梯形的左腰的长：");
            while (!double.TryParse(Console.ReadLine(), out liftside))
            {
                Console.Write("输入错误，重新输入梯形的上底的长：");
            }
            Console.Write("输入梯形的右腰的长：");
            while (!double.TryParse(Console.ReadLine(), out rightside))
            {
                Console.Write("输入错误，重新输入梯形的上底的长：");
            }
            Console.Write("输入梯形的高：");
            while (!double.TryParse(Console.ReadLine(), out height))
            {
                Console.Write("输入错误，重新输入梯形的上底的长：");
            }
            Upside = upside;
            Downside = downside;
            Liftside = liftside;
            Rightside = rightside;
            Height = height;
            Whatforshow.Show_shurencuowu("输入完成。");
        }
        public void Display()
        {
            Console.WriteLine($"梯形的面积为：{Area:F4}梯形的周长为：{Permeter:F4}");
            Whatforshow.Show_queren();
        }
    }
}