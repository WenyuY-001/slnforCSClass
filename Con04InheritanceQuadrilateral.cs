namespace GDF
{
    class Con04InheritanceQuadrilateral
    {
        protected double _upside = 0;
        protected double _downside = 0;
        protected double _liftside = 0;
        protected double _rightside = 0;
        protected double _height = 0;
        protected double Area
        {
            get
            {
                return (_upside + _downside) * _height / 2;
            }
        }
        protected double Perimeter
        {
            get
            {
                return _upside + _downside + _liftside + _rightside;
            }
        }
    }
    class Con04InhRectangle : Con04InheritanceQuadrilateral
    {
        double Width
        {
            set
            {
                _upside = value;
                _downside = value;
            }
        }
        double Height
        {
            set
            {
                _liftside = value;
                _rightside = value;
                _height = value;
            }
        }
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
            Console.WriteLine($"面积：{Area:F4}周长：{Perimeter:F4}");
            Whatforshow.Show_queren();
        }
    }
    class Con04InhTrapezoid : Con04InheritanceQuadrilateral
    {
        double Liftside { set { _liftside = value; } }
        double Rightside { set { _rightside = value; } }
        double Height { set { _height = value; } }
        double Upside { set { _upside = value; } }
        double Downside { set { _downside = value; } }
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
            Console.WriteLine($"面积：{Area:F4}周长：{Perimeter:F4}");
            Whatforshow.Show_queren();
        }
    }
}