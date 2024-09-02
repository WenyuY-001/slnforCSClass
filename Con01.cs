namespace GDF;

public class Con01
{
    int _theChoice = 0;

    public void Menu()
    {
        do
        {
            Console.Clear();
            Console.WriteLine("圆的计算：1");
            Console.WriteLine("根据利润求奖金：2");
            Console.WriteLine("输入年份输出生肖：3");
            Console.WriteLine("退出：0");
            bool isOk = int.TryParse(Console.ReadLine(), out _theChoice);
            if (!isOk)
            {
                Whatforshow.Show_shurencuowu("这不是合法的数字!");
                continue;
            }
            switch (_theChoice)
            {
                case 0: return;
                case 1:
                    Console.Clear();
                    Circle();
                    break;
                case 2:
                    Console.Clear();
                    Bonus();
                    break;
                case 3:
                    Console.Clear();
                    ShengXiao();
                    break;
                default:
				    if(_theChoice < 0)
					{
						Whatforshow.Show_shurencuowu("输入为负数!");
					}
                    else
                    {
                        Whatforshow.Show_shurencuowu("这不是合法的选项!");
                    }
                    break;
            }
        } while (true);
    }

    void Circle()
    {
        int _theChoiceCircle = 0;
        double r = 0, h = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("求圆：1\n求圆球：2\n求圆柱：3\n退出：0");
            bool isOk = int.TryParse(Console.ReadLine(), out _theChoiceCircle);
            if (!isOk)
            {
                Whatforshow.Show_shurencuowu("这不是合法的数字!");
                continue;
            }
            switch (_theChoiceCircle)
            {
                case 0:
                    return;
                case 1:
                    Console.WriteLine("输入半径：");
                    r = Convert.ToDouble(Console.ReadLine());
                    string theCircumference = string.Format("{0:N4}", Math.PI * r * 2);
                    string theCirclearea = string.Format("{0:N4}", Math.PI * Math.Pow(r, 2));
                    Console.WriteLine($"圆周长为：{theCircumference}\n圆面积为：{theCirclearea}");
                    break;
                case 2:
                    Console.WriteLine("输入半径：");
                    r = Convert.ToDouble(Console.ReadLine());
                    string theSpheresurfacearea = string.Format("{0:N4}", Math.PI * Math.Pow(r, 2) * 4);
                    string theSpherevolume = string.Format("{0:N4}", Math.PI * Math.Pow(r, 3));
                    Console.WriteLine($"圆球表面积为：{theSpheresurfacearea}\n圆球体积为：{theSpherevolume}");
                    break;
                case 3:
                    Console.WriteLine("输入半径：");
                    r = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("输入高：");
                    h = Convert.ToDouble(Console.ReadLine());
                    string theCylindersurfacearea =
                        string.Format("{0:N4}", (Math.PI * Math.Pow(r, 2)) + (2 * r * Math.PI * h));
                    string theCylindervolume = string.Format("{0:N4}", Math.PI * Math.Pow(r, 2) * h);
                    Console.WriteLine($"圆柱表面积为：{theCylindersurfacearea}\n圆柱体积为：{theCylindervolume}");
                    break;
                default:
                    Whatforshow.Show_shurencuowu("这不是合法的选项!");
                    break;
            }
            Console.Write("输入任意继续......");
            Console.ReadLine();
        } while (true);
    }

    void Bonus()
    {
        double theProfit = 0, theBonus = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("输入当月利润：");
            bool isOk = double.TryParse(Console.ReadLine(), out theProfit);
            if (!isOk)
            {
                Whatforshow.Show_shurencuowu("这不是合法的数字!");
                continue;
            }
            if (theProfit <= 0)
            {
                Whatforshow.Show_shurencuowu("你是死人吗？");
                continue;
            }
            else if (theProfit <= 100000)
            {
                theBonus = (theProfit * 0.1);
            }
            else if (theProfit <= 200000)
            {
                theBonus = (theProfit * 0.075);
            }
            else if (theProfit <= 400000)
            {
                theBonus = (theProfit * 0.05);
            }
            else if (theProfit <= 600000)
            {
                theBonus = (theProfit * 0.03);
            }
            else if (theProfit <= 1000000)
            {
                theBonus = (theProfit * 0.015);
            }
            else
            {
                theBonus = (theProfit * 0.01);
            }
            string theTrueBonus = string.Format("{0:N2}", theBonus);
            Console.WriteLine($"应发放奖金数为：{theTrueBonus}");
            Whatforshow.Show_queren();
            break;
        } while (true);
    }

    void ShengXiao()
    {
        string[] shengXiaoArr = {"猴", "鸡", "狗" , "猪", "鼠", "牛", "虎", "兔", "龙", "蛇", "马", "羊" };
        int theYear = 1923;
        do
        {
            Console.Clear();
            Console.WriteLine("输入年份：(范围为1923-2123年)");
            bool isOk = int.TryParse(Console.ReadLine(), out theYear);
            if (!isOk)
            {
                Whatforshow.Show_shurencuowu("这不是合法的整数!");
                continue;
            }
            if (theYear >= 1923 && theYear <= 2123)
            {
                int index = theYear % 12;
                Console.WriteLine($"生肖为：{shengXiaoArr[index]}");
                Whatforshow.Show_queren();
                break;
            }
            else
            {
                Whatforshow.Show_shurencuowu("年份超出范围");
            }
        } while (true);
    }
}
