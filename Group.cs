namespace _31ISKurbatov
{
    public class Group
    {
        public string Name { get; private set; }

        public string College { get; private set; }

        public List<Student> Students { get; private set; }

        public Group(string name, string college, List<Student> students)
        {
            Name = name;
            College = college;
            Students = students;
        }

        public void ShowAll()
        {
            foreach (var student in Students)
            {
                Console.WriteLine($"Имя студента: {student.Name}\nКолледж: {College}");
            }
        }
    }

    public class Student : IComparable<Student>
    {
        public string Name { get; private set; }

        public double Ocenka { get; private set; }

        public Student(string name, double ocenka)
        {
            Name = name;
            Ocenka = ocenka;
        }

        public int CompareTo(Student? other)
        {
            if (other == null)
                throw new NullReferenceException($"{other} cannot be a null");
            return this.Ocenka.CompareTo(other.Ocenka);
        }

        public void Show()
        {
            Console.WriteLine($"Имя студента: {Name}\nОценка студента: {Ocenka}");
        }
    }
}