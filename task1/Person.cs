public class Person
{
    public string Name;
    public string Surname;
    public int Age;
    public string Adress;
    public string GetFullName()
    {
        return $"{Name} {Surname}";
    }
    public string GetYearOfBirth()
    {
        return $"{2023 - Age}";
    }

}