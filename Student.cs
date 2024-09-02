namespace GDF
{
    internal class Student
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public char GradeLevel { get; set; }
        public Student()
        {
            Id = 0;
            Name = string.Empty;
            ClassName = string.Empty;
            Gender = string.Empty;
            Age = 0;
            GradeLevel = 'E';
        }
        public Student(uint id,string name, string className,string gender,int age,char gradeLevel)
        {
            Id = id;
            Name = name;
            ClassName = className;
            Gender = gender;
            Age = age;
            GradeLevel = gradeLevel;
        }


    }
}
