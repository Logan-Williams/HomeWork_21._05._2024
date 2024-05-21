class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>() // лист делал сам 
        {   new Student(1, "Alex", 19, 3.55, "Computer Science"),
            new Student(2, "Oli", 18, 3.7, "Psychology"),
            new Student(3, "Max", 21, 3.65, "Psychology"),
            new Student(4, "Mike", 17, 3.6, "Computer Science"), // если два студента с идинаковым баллом,    
            new Student(5, "Sam", 18, 3.9, "Psychology")        // то он выведет толко первого в методе Findmax
        };
          void ListComputerScienceStudents() // Логику я делал с помощью GPT и Метанита
        {
            
            foreach (var student in students)
            {
                if (student.Major == "Computer Science")
                {
                    Console.WriteLine($"Студент учащийся по професии - Компьютерные технологии  : Имя: {student.Name}, Возраст: {student.Age}, Средний балл: {student.GPA}");
                }
            }
        }
        void Findmax() // Логику я делал с помощью GPT и Метанита
        {
            Student max = students[0];
            foreach (var student in students)
            {
                if (student.GPA > max.GPA)
                {
                    max = student;
                }
            }

            Console.WriteLine($"Лучший студент: Name: {max.Name}, Age: {max.Age}, GPA: {max.GPA}, Major: {max.Major}");
        }

        
        Findmax();
        ListComputerScienceStudents();
    }
    
}



class Student // тут тоже сам
{

    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public double GPA { get; set; }
    public string Major { get; set; }

    public Student(int id, string name, int age, double gpa, string major )
    {
        Id = id;
        Name = name;
        Age = age;
        Major = major;
        GPA = gpa;
    }
}

