namespace GDF
{
    public class Con04
    {
        public void Menu()
        {
            int _theChoice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("继承实现计算长方形和梯形的周长与面积：1");
                Console.WriteLine("多态实现计算长方形和梯形的周长与面积：2");
                Console.WriteLine("接口实现计算长方形和梯形的周长与面积：3");
                Console.WriteLine("退出：0");
                while (!int.TryParse(Console.ReadLine(), out _theChoice))
                {
                    Whatforshow.Show_shurencuowu("这不是合法的数字!请重新输入：");
                }
                switch (_theChoice)
                {
                    case 0: return;
                    case 1:
                        Console.Clear();
                        InhPerAre();
                        break;
                    case 2:
                        Console.Clear();
                        PolPerAre();
                        break;
                    case 3:
                        Console.Clear();
                        IntPerAre();
                        break;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (true);
        }
        void InhPerAre()
        {
            int _theChoice = 0;
            Con04InhRectangle con04 = new Con04InhRectangle();
            Con04InhTrapezoid con041 = new Con04InhTrapezoid();
            do
            {
                Console.Clear();
                Console.WriteLine("计算长方形的周长与面积：1");
                Console.WriteLine("计算梯形的周长与面积：2");
                Console.WriteLine("退出：0");
                while (!int.TryParse(Console.ReadLine(), out _theChoice))
                {
                    Whatforshow.Show_shurencuowu("这不是合法的数字!");
                }
                switch (_theChoice)
                {
                    case 0: return;
                    case 1:
                        Console.Clear();
                        con04.SetData();
                        con04.Display();
                        break;
                    case 2:
                        Console.Clear();
                        con041.SetData();
                        con041.Display();
                        break;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (true);
        }
        void PolPerAre()
        {
            int _theChoice = 0;


            do
            {
                Console.Clear();
                Console.WriteLine("计算长方形的周长与面积：1");
                Console.WriteLine("计算梯形的周长与面积：2");
                Console.WriteLine("退出：0");
                while (!int.TryParse(Console.ReadLine(), out _theChoice))
                {
                    Whatforshow.Show_shurencuowu("这不是合法的数字!");
                }
                switch (_theChoice)
                {
                    case 0: return;
                    case 1:
                        Console.Clear();
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
                        Con04PolRectangle con04 = new Con04PolRectangle(width, height);
                        Whatforshow.Show_shurencuowu("输入完成。");
                        con04.Display();
                        break;
                    case 2:
                        Console.Clear();
                        double upside = 0;
                        double downside = 0;
                        double liftside = 0;
                        double rightside = 0;

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
                        Con04PolTrapezoid con041 = new Con04PolTrapezoid(upside, downside, liftside, rightside, height);
                        Whatforshow.Show_shurencuowu("输入完成。");
                        con041.Display();
                        break;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (true);
        }
        void IntPerAre()
        {
            int _theChoice = 0;
            Con04IntRectangle con04 = new Con04IntRectangle();
            Con04IntTrapezoid con041 = new Con04IntTrapezoid();
            Con04InterfaceQuadrilateral Icon04 = con04;
            Con04InterfaceQuadrilateral Icon041 = con041;
            do
            {
                Console.Clear();
                Console.WriteLine("计算长方形的周长与面积：1");
                Console.WriteLine("计算梯形的周长与面积：2");
                Console.WriteLine("退出：0");
                while (!int.TryParse(Console.ReadLine(), out _theChoice))
                {
                    Whatforshow.Show_shurencuowu("这不是合法的数字!");
                }
                switch (_theChoice)
                {
                    case 0: return;
                    case 1:
                        Console.Clear();
                        Icon04.SetData();
                        Icon04.Display();
                        break;
                    case 2:
                        Console.Clear();
                        Icon041.SetData();
                        Icon041.Display();
                        break;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (true);
        }
    }
}