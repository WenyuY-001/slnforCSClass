namespace GDF;

public class Con02
{
    public void Menu()
    {
        int? _theChoice;
        do
        {
            Console.Clear();
            Console.WriteLine("斐波拉契数列：1");
            Console.WriteLine("字符串的加密：2");
            Console.WriteLine("客车售票系统：3");
            Console.WriteLine("退出：0");
            _theChoice = Convert.ToInt32(Console.ReadLine());
            switch (_theChoice)
            {
                case 0: return;
                case 1:
                    //调用斐波拉契数列函数
                    Console.Clear();
                    Fibonacci();
                    break;
                case 2:
                    //调用字符串加密函数
                    Console.Clear();
                    StringEncrypt();
                    break;
                case 3:
                    //调用客车售票系统函数
                    Console.Clear();
                    Ticket();
                    break;
                default:
                    Console.WriteLine("输入错误!");
                    break;
            }
        } while (true);
    }
    //打印斐波那契数列
    void Fibonacci()
    {
        int a = 0, b = 1, c = 0, i = 0;
        Console.WriteLine("斐波那契数列：");
        Console.WriteLine($"{a}");
        Console.WriteLine($"{b}");
        do
        {
            c = a + b;
            Console.WriteLine($"{c}");
            a = b;
            b = c;
            i++;
        } while (i <= 30);
        Whatforshow.Show_queren();
    }
    //分别输入一个含有字母和数字的字符串和一个 int 范围内的密钥，显示原字符串和加密后的字符串；
    //加密的原理是将一个字符串中的所有字符按同一密钥变成另外一个字符串。如字符串为 a1，密钥为 3 时，应为 d4。注意越界的情况，如有 xZ9，当密钥为 3 时，应为 aC2；
    //加密规则是字母变字母，数字变数字，字符变字符。
    void StringEncrypt()
    {
        string? str = "";
        int key = 0;
        Console.WriteLine("请输入一个含有字母和数字的字符串：");
        str = Console.ReadLine();
        Console.WriteLine("请输入一个 int 范围内的密钥：");
        int.TryParse(Console.ReadLine(), out key);
        Console.WriteLine("加密前：" + str);
        char[] str1 = str.ToCharArray();
        for (int i = 0; i < str1.Length; i++)
        {
            // 如果字符串str1中的字符是字母，则将其转换为对应字母
            if (str1[i] >= 'a' && str1[i] <= 'z')
            {
                str1[i] = (char)(str1[i] + key);
                Console.WriteLine($"加密后：{str1[i]}");
                // 如果转换后的字符大于z，则将其转换为对应字母
                if (str1[i] > 'z')
                {
                    str1[i] = (char)(str1[i] - 'z' + 'a' - 1);
                    Console.WriteLine($"加密后：{str1[i]}");
                }
            }
            // 如果字符串str1中的字符是字母，则将其转换为对应字母
            else if (str1[i] >= 'A' && str1[i] <= 'Z')
            {
                str1[i] = (char)(str1[i] + key);
                // 如果转换后的字符大于Z，则将其转换为对应字母
                if (str1[i] > 'Z')
                {
                    str1[i] = (char)(str1[i] - 'Z' + 'A' - 1);
                }
            }
            // 如果字符串str1中的字符是数字，则将其转换为对应数字
            else if (str1[i] >= '0' && str1[i] <= '9')
            {
                str1[i] = (char)(str1[i] + key);
                // 如果转换后的字符大于9，则将其转换为对应数字
                if (str1[i] > '9')
                {
                    str1[i] = (char)(str1[i] - '9' + '0' - 1);
                }
            }
        }
        string str2 = new string(str1);
        Console.WriteLine("加密后：" + str2);
        Whatforshow.Show_queren();
    }
    //设计一个简单的客车售票系统，使用一个 9*4 的二维数组记录客车的所有座位号，并在每个座位号上都显示“【有票】”,当用户输入一个排号，一个座号，按回车键后，将该座位号显示为“{已售}”。要求如下：
    //不能出现 0 排 0 座；
    //如果输入了非数字的排或座，要提示输入了非法数据。
    //使用 GetLength 方法获取二维数组的行数和列数
    void Ticket()
    {
        do
        {
            int[,] seats = new int[9, 4] {
               { 1, 0, 0, 1 },
               { 0, 1, 0, 0 },
               { 0, 1, 1, 1 },
               { 0, 0, 0, 0 },
               { 1, 1, 1, 0 },
               { 1, 0, 1, 1 },
               { 0, 0, 0, 0 },
               { 1, 0, 1, 0 },
               { 1, 1, 0, 0 }
            };

            bool isOk = false;
            int row = 0;
            int seat = 0;

            Console.WriteLine("请输入排号：");
            isOk = int.TryParse(Console.ReadLine(), out row);
            if (!isOk)
            {
                Whatforshow.Show_shurencuowu();
                continue;
            }
            if (!(row >= 1 && row <= 9))
            {
                Whatforshow.Show_shurencuowu();
                continue;
            }
            Console.WriteLine("请输入座号：");
            isOk = int.TryParse(Console.ReadLine(), out row);
            if (!isOk)
            {
                Whatforshow.Show_shurencuowu();
                continue;
            }
            if (!(seat >= 1 && seat <= 4))
            {
                Whatforshow.Show_shurencuowu();
                continue;
            }

            if (seats[row - 1, seat - 1] == 0)
            {
                Console.WriteLine("该座位有售。\n确认支付？(yes)");
                string confirm = Console.ReadLine();
                if (confirm == "yes") // 假设用户输入"yes"来确认支付
                {
                    seats[row - 1, seat - 1] = 1;
                    Console.WriteLine("购买成功！");
                    Whatforshow.Show_queren();
                }
                else continue;
                return;
            }
            else
            {
                Console.WriteLine("座位已售！");
                Whatforshow.Show_queren();
            }
            Whatforshow.Show_queren();
        } while (true);
    }
}