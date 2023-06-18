var studentList = new List<Student>();
for (int i = 1; i <= 5; i++)
{
    System.Console.WriteLine($"Student {i}");
    Student student = new Student();
    student.Name = Console.ReadLine();
    student.Surname = Console.ReadLine();
    student.Grade = Convert.ToInt32(Console.ReadLine());
    for (int j = 0; j < 3; j++)
    {
        student.Score[j] = Convert.ToInt32(Console.ReadLine());
    }
    studentList.Add(student);

}
foreach (var student in studentList)
{
    if (student.GetAverage() >= 85)
    {
        System.Console.WriteLine($"Congratulations {student.Surname} {student.Name} on achieving above average scores ({student.GetAverage()}) in grade {student.Grade}! Keep up the good work!");
    }
    else if (student.GetAverage() < 85 && student.GetAverage() >= 75)
    {
        System.Console.WriteLine($"Congratulations {student.Surname} {student.Name} on achieving an average score of ({student.GetAverage()}) in grade {student.Grade}! Keep working hard for even better results!");
    }
    else if (student.GetAverage() <= 75)
    {
        System.Console.WriteLine($"{student.Surname} {student.Name}, if you're having difficulties with your studies, don't hesitate to seek help. Your current average score is ({student.GetAverage()}) in grade {student.Grade}.");
    }
}