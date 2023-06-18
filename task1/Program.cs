// var personList = new List<Person>();
// for (int i=1; i<=3; i++){
//     var person=new Person();
//     person.Name=System.Console.ReadLine();
//     person.Surname=System.Console.ReadLine();
//     person.Age=Convert.ToInt32(Console.ReadLine());
//     person.Adress=System.Console.ReadLine();
//     personList.Add(person);
// }
// foreach (var person in personList)
// {
//  System.Console.WriteLine("My name is " + person.GetFullName()+'.');
//  System.Console.WriteLine("Mu birth Year is " + person.GetYearOfBirth()+'.');    
// }

Person person1 = new Person();
person1.Name = "Sadriddin";
person1.Surname = "Nurov";
person1.Age = 23;
person1.Adress = "Sherozi street 22";

Person person2 = new Person();
person2.Name = "Qosimov";
person2.Surname = "Sherali";
person2.Age = 25;
person2.Adress = "Hofiz street 3";

Person person3 = new Person();
person3.Name = "Umed";
person3.Surname = "Jamolov";
person3.Age = 32;
person3.Adress = "Sa'di street 30";

System.Console.WriteLine("My name is " + person1.GetFullName() + '.');
System.Console.WriteLine("My Year of birth " + person1.GetYearOfBirth() + '.');

System.Console.WriteLine("My name is " + person2.GetFullName() + '.');
System.Console.WriteLine("My Year of birth " + person2.GetYearOfBirth() + '.');

System.Console.WriteLine("My name is " + person3.GetFullName() + '.');
System.Console.WriteLine("My Year of birth " + person3.GetYearOfBirth() + '.');
