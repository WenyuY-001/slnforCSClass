namespace GDF
{
    class Con04PolymorphismQuadrilateral
    {
        protected double upside;
        protected double downside;
        protected double liftside;
        protected double rightside;
        protected double height;
        protected double Area { get { return (upside + downside) * height / 2; } }
        protected double Perimeter { get { return upside + downside + liftside + rightside; } }
        public virtual void Display() { }
        public Con04PolymorphismQuadrilateral()
        {
            upside = 0;
            downside = 0;
            liftside = 0;
            rightside = 0;
            height = 0;
        }
        public Con04PolymorphismQuadrilateral(double _width, double _height)
        {
            upside = _width;
            downside = _width;
            liftside = _height;
            rightside = _height;
            height = _height;
        }
        public Con04PolymorphismQuadrilateral(double upSide, double downSide, double liftSide, double rightSide, double Height)
        {
            upside = upSide;
            downside = downSide;
            liftside = liftSide;
            rightside = rightSide;
            height = Height;
        }
    }
    class Con04PolRectangle : Con04PolymorphismQuadrilateral
    {
        public Con04PolRectangle() : base() { }
        public Con04PolRectangle(double width, double height) : base(width, height) { }
        public override void Display()
        {
            Console.WriteLine($"面积：{Area:F4}周长：{Perimeter:F4}");
            Whatforshow.Show_queren();
        }
    }
    class Con04PolTrapezoid : Con04PolymorphismQuadrilateral
    {
        public Con04PolTrapezoid() : base() { }
        public Con04PolTrapezoid(double upSide, double downSide, double liftSide, double rightSide, double Height) : base(upSide, downSide, liftSide, rightSide, Height)  { }
        public override void Display()
        {
            Console.WriteLine($"面积：{Area:F4}周长：{Perimeter:F4}");
            Whatforshow.Show_queren();
        }
    }
}