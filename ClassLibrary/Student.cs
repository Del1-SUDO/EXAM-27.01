namespace ClassLibrary;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }

    public Student (string name, int age, string group){
        this.Name = name;
        this.Age = age;
        this.Group = group;
    }
}
