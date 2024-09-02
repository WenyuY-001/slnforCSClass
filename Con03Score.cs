using System;
using GDF;
//中新建类Con03Score，并定义字段、属性和方法.该类能够记录学生的姓名、班级、两门（或更多）课程的成绩，并能录入、修改和显示。
public class Con03Score
{
    public Con03Score()
    {
        TheName = "未命名";
        TheClass = "未命名";
        idNumber = "未命名";
    }
    public Con03Score(string name, string className,string idnumber)
    {
        TheName = name;
        TheClass = className;
        idNumber = idnumber;
    }
    public Con03Score(string name, string className, string idnumber,int score1, int score2)
    {
        TheName = name;
        TheClass = className;
        idNumber = idnumber;
        Score1 = score1;
        Score2 = score2;
    }
    public string TheName { get; set; }
    public string TheClass { get; set; }
    public string idNumber{ get; set; }
    public int Score1 { get; set; }
    public int Score2 { get; set; }
    public int TotalScore { get { return Score1 + Score2; } }
    public void AddScore()
    {
        int _Score1 = 0;
        int _Score2 = 0;
        Console.WriteLine("请输入课程1的分数：");
        _Score1 = setScore();
        Console.WriteLine("请输入课程2的分数：");
        _Score2 = setScore();
        Score1 = _Score1;
        Score2 = _Score2;
        Console.WriteLine("添加成功！\n课程1成绩：{0}\n课程2成绩：{1}", _Score1, _Score2);
        Whatforshow.Show_queren();
    }
    public void ModifyScore()
    {
        int _Score1 = 0;
        int _Score2 = 0;
        Console.WriteLine("请输入课程1的分数：");
        _Score1 = setScore();
        Console.WriteLine("请输入课程2的分数：");
        _Score2 = setScore();
        Score1 = _Score1;
        Score2 = _Score2;
        Console.WriteLine("修改成功！\n课程1成绩：{0}\n课程2成绩：{1}", _Score1, _Score2);
        Whatforshow.Show_queren();
    }
    public int setScore()
    {
        int _Score = 0;
        while (!int.TryParse(Console.ReadLine(), out _Score) || _Score < 0 || _Score > 100)
        {
            Console.WriteLine("请输入正确的分数:");
        }
        return _Score;
    }
    public void ShowScore()
    {
        Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", TheName, TheClass, Score1, Score2, TotalScore);
    }
}
