namespace GDF
{
    class Whatforshow
    {
        public static void Show_queren()
        {
            Console.Write("输入任意继续......");
            Console.ReadKey();
        }
        public static void Show_shurencuowu()
        {
            Console.WriteLine("输入了非法数据！");
            Console.Write("输入任意继续......");
            Console.ReadKey();
        }
        public static void Show_shurencuowu(string str)
        {
            Console.WriteLine(str);
            Console.Write("输入任意继续......");
            Console.ReadKey();
        }
        public static void Show_zhongxinshuru()
        {
            Console.WriteLine("输入错误！");
            Console.Write("重新输入:");
        }
    }
}