namespace GDF
{
    public class Con03
    {
        int _theChoice = 0;
        public void Menu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("计算圆和长方形的周长与面积：1");
                Console.WriteLine("学生成绩：2");
                Console.WriteLine("退出：0");
                while (!int.TryParse(Console.ReadLine(), out _theChoice))
                {
                    Whatforshow.Show_shurencuowu("这不是合法的数字!");
                    continue;
                }
                switch (_theChoice)
                {
                    case 0: return;
                    case 1:
                        Console.Clear();
                        PerimeterArea();
                        break;
                    case 2:
                        Console.Clear();
                        StudentScore();
                        break;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (true);
        }
        //用类Con03Circle和Con03Rectangle的实例化成员实现计算圆和长方形的周长与面积
        void PerimeterArea()
        {
            Con03Circle con03Circle = new Con03Circle();
            Con03Rectangle con03Rectangle = new Con03Rectangle();
            do
            {
                Console.Clear();
                Console.WriteLine("计算圆周长与面积：1");
                Console.WriteLine("计算长方形周长与面积：2");
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
                        con03Circle.getData();
                        con03Circle.display();
                        break;
                    case 2:
                        Console.Clear();
                        con03Rectangle.getData();
                        con03Rectangle.display();
                        break;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (true);
        }
        //调用类Con03Score的录入、修改和显示方法。
        void StudentScore()
        {
            List<Con03Score> con03Scores = new List<Con03Score>();
            con03Scores.Add(new Con03Score("张三", "001班", "240159", 90, 80));
            con03Scores.Add(new Con03Score("李四", "001班", "240156", 80, 90));
            con03Scores.Add(new Con03Score("王五", "001班", "240147", 70, 70));
            do
            {
                Console.Clear();
                Console.WriteLine("1.录入学生成绩");
                Console.WriteLine("2.修改学生成绩");
                Console.WriteLine("3.显示学生成绩");
                Console.WriteLine("0.返回上一级");
                Console.WriteLine("请选择：");
                int _theChoice = int.Parse(Console.ReadLine());
                if (_theChoice < 0 || _theChoice > 3)
                {
                    Console.WriteLine("输入错误!");
                    Whatforshow.Show_queren();
                }
                switch (_theChoice)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("录入学生成绩：");
                        Console.WriteLine("录入姓名：");
                        string? name = Console.ReadLine();
                        Console.WriteLine("录入班级：");
                        string? className = Console.ReadLine();
                        Console.WriteLine("录入学号：");
                        string? idNumber = Console.ReadLine();
                        con03Scores.Add(new Con03Score(name, className, idNumber));
                        Console.WriteLine("录入成绩：");
                        con03Scores[con03Scores.Count - 1].AddScore();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("修改学生成绩：");
                        Console.WriteLine("序号\t\t姓名\t\t班级\t\t学号\t\t课程一\t\t课程二\t\t总成绩");
                        for (int i = 0; i < con03Scores.Count; i++)
                        {
                            Console.Write("{0\t\t", i + 1);
                            con03Scores[i].ShowScore();
                        }
                        int _theChoice2;
                        Console.WriteLine("请选择要修改的学生：");
                        while (!int.TryParse(Console.ReadLine(), out _theChoice2) || _theChoice2 < 0 || _theChoice2 > con03Scores.Count)
                        {
                            Console.WriteLine("请输入正确的序号：");
                        }
                        con03Scores[_theChoice2 - 1].ModifyScore();
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("显示学生成绩：");
                        Console.WriteLine("序号\t\t姓名\t\t班级\t\t学号\t\t课程一\t\t课程二\t\t总成绩");
                        for (int i = 0; i < con03Scores.Count; i++)
                        {
                            Console.Write("{0}\t\t", i + 1);
                            con03Scores[i].ShowScore();
                        }
                        Whatforshow.Show_queren();
                        break;
                    case 0:
                        return;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (_theChoice != 0);
            Whatforshow.Show_queren();
        }
    }
}
