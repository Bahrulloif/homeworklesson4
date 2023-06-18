public class Student
{
    public string? Name;
    public string? Surname;
    public int Grade;
    public int[]? Score=new int[3];

    public double GetAverage()
    {
        double sum = 0;
        foreach (var num in Score)
        {
            sum += num;
        }
        return sum/3;
    }
}