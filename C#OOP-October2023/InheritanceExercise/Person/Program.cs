


namespace Person;

public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Name { get; set; }
    public virtual int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value > 0)
            {
                age = value;
            }
        }
    }

        public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }

}


public class Child : Person
{
    public Child(string name, int age)
        :base(name, age)
    { 
    }

    public override int Age { get => base.Age; set{
            if (value <= 15) 
            {
                base.Age = value;
            }
           }
    }



}