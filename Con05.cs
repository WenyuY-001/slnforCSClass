namespace GDF
{
    public class Con05
    {
        public void Menu()
        {
            int _theChoice = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("用 Dictionary 实现根据年龄计算出生年份：1");
                Console.WriteLine("LINQ：2");
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
                        BornYear();
                        break;
                    case 2:
                        Console.Clear();
                        List<Student> students = new List<Student>();
                        students.Add(new Student(2006052117, "宇文曜", "Computer", "男", 21, 'B'));
                        students.Add(new Student(2206052118, "宇文轻羽", "Chinese", "女", 19, 'A'));
                        students.Add(new Student(1906005112, "莫傅", "Computer", "男", 22, 'C'));
                        students.Add(new Student(2106003106, "杨弧月", "Chinese", "女", 21, 'A'));
                        int[] ints = { 32, 45, 67, 45, 13, 64, 12, 41, 54, 23, 2, 6, 78 };
                        Where(students);
                        Whatforshow.Show_shurencuowu("Where方法完成，下一个是Group方法。");
                        Console.WriteLine();
                        Group(students);
                        Whatforshow.Show_shurencuowu("Group方法完成，下一个是WhereMethod方法。");
                        Console.WriteLine();
                        WhereMethod(ints);
                        Whatforshow.Show_shurencuowu("WhereMethod方法完成，所有方法已完成。");
                        break;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (true);
        }
        void BornYear()
        {
            Dictionary<string, int> Users = new Dictionary<string, int>();
            Users.Add("张三", 12);
            Users.Add("李四", 20);
            Users.Add("王五", 30);
            Users.Add("钱进", 54);
            Users.Add("侯蜕", 76);

            int _theChoice = 0;
            string? _name;
            int _years;
            int recentYear = 2023;
            do
            {
                Console.Clear();
                Console.WriteLine("输入姓名和年龄增加用户：1");
                Console.WriteLine("根据姓名删除用户：2");
                Console.WriteLine("根据姓名修改年龄：3");
                Console.WriteLine("根据姓名计算出生年份：4");
                Console.WriteLine("退出：0");
                while (!int.TryParse(Console.ReadLine(), out _theChoice))
                {
                    Whatforshow.Show_shurencuowu("这不是合法的数字!请重新输入：");
                }
                switch (_theChoice)
                {
                    case 0: return;
                    case 1:
                        string? x;
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("输入姓名:");
                            _name = Console.ReadLine();
                            Console.WriteLine("输入年龄:");
                            while (!int.TryParse(Console.ReadLine(), out _years))
                            {
                                Whatforshow.Show_shurencuowu("这不是合法的数字!请重新输入：");
                            }
                            Console.WriteLine("姓名：{0}，年龄：{1}，确认？（y/n）", _name, _years);
                            x = Console.ReadLine();
                            if (x.ToLower() == "n") { continue; }
                            while (x.ToLower() != "y")
                            {
                                Whatforshow.Show_zhongxinshuru();
                                x = Console.ReadLine();
                            }
                            Users.Add(_name, _years);
                            Console.WriteLine("添加成功!");
                            break;
                        } while (true);
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("输入姓名:");
                        _name = Console.ReadLine();
                        if (Users.ContainsKey(_name))
                        {
                            Console.Write("查找到用户:");
                            Console.WriteLine("姓名:{0}\t\t年龄:{1}\t\t", _name, Users[_name]);
                            Console.Write("确认删除？（y/n）");
                            x = Console.ReadLine();
                            if (x.ToLower() == "n") { continue; }
                            while (x.ToLower() != "y")
                            {
                                Whatforshow.Show_zhongxinshuru();
                                x = Console.ReadLine();
                            }
                            Users.Remove(_name);
                            Console.WriteLine("删除成功。");
                            Whatforshow.Show_queren();
                        }
                        else
                        {
                            Console.WriteLine("未查找到用户。");
                            Whatforshow.Show_queren();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("输入姓名:");
                        _name = Console.ReadLine();
                        if (Users.ContainsKey(_name))
                        {
                            Console.WriteLine("查找到用户:");
                            Console.WriteLine("姓名:{0}\t\t年龄:{1}\t\t", _name, Users[_name]);
                            Whatforshow.Show_queren();
                        }
                        else
                        {
                            Console.WriteLine("未查找到用户");
                            Whatforshow.Show_queren();
                            break;
                        }
                        Console.WriteLine("输入更改年龄:");
                        while (!int.TryParse(Console.ReadLine(), out _years))
                        {
                            Whatforshow.Show_shurencuowu("这不是合法的数字!请重新输入：");
                        }
                        Console.WriteLine("更改后:");
                        Console.WriteLine("姓名：{0}\t\t年龄：{1}\t\t", _name, Users[_name]);
                        Whatforshow.Show_queren();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("输入姓名:");
                        _name = Console.ReadLine();
                        if (Users.ContainsKey(_name))
                        {
                            Console.Write("查找到用户:");
                            Console.WriteLine("姓名:{0}\t\t年龄:{1}\t\t", _name, Users[_name]);
                            Console.WriteLine("计算中......");
                            int liveYear = recentYear - Users[_name];
                            Console.WriteLine("出生年份为{0}", liveYear);
                            Whatforshow.Show_queren();
                        }
                        else
                        {
                            Console.WriteLine("未查找到用户。");
                            Whatforshow.Show_queren();
                        }
                        break;
                    default:
                        Console.WriteLine("输入错误!");
                        Whatforshow.Show_queren();
                        break;
                }
            } while (true);
        }
        void Where(List<Student> student)
        {
            var q = from some in student
                    where some.Gender == "男" && some.GradeLevel == 'B'
                    select some;
            foreach (var item in q)
            {
                Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t", item.Id, item.Name, item.ClassName, item.Gender, item.Age, item.GradeLevel);
            }
        }
        void Group(List<Student> student)
        {
            var q = from some in student
                    group some by some.ClassName;
            foreach (var i in q)
            {
                foreach (var item in i)
                {
                    Console.WriteLine("{0}\t{1}\t\t{2}\t{3}\t{4}\t{5}\t", item.Id, item.Name, item.ClassName, item.Gender, item.Age, item.GradeLevel);
                }
            }
        }
        void WhereMethod(int[] ints)
        {
            Console.WriteLine("数组中的元素：");
            foreach (int i in ints)
            {
                Console.Write("{0}", i);
            }
            Console.WriteLine();
            var q1 = ints.Where(num => num <= 20 || num >= 50);
            var q2 = ints.Where(num => num % 5 == 2).ToArray();
            Console.WriteLine("数组中小于 20 或大于 50 的元素：");
            foreach (var i in q1)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
            Console.WriteLine("数组中对 5 取余等于 2 的元素：");
            foreach (var i in q2)
            {
                Console.Write("{0}\t", i);
            }
            Console.WriteLine();
        }
    }
}