using System;

namespace CreateStruct

{
  class program
  {
    struct Person
    {
      public string firstName;
      public string lastName;
      public int age;

      public Person(string _firstName, string _lastName, int _age)
      {
        firstName = _firstName;
        lastName = _lastName; age = _age;
      }
      public override string ToString()
      {
        return firstName + " " + lastName + ", age " + age;
      }

    }


    static void Main (string[]args)
    {

      Person p = new Person("Billy", "Herrington", 48);
      Console.WriteLine(p);
    }
  }
}
