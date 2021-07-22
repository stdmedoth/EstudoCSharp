using System;

namespace classes_examples{
  public class Person {
    public Person(){
      Name = "MeuNome";
    }

    public Person(string name){
      Name = name;
    }

    public string Name { get; }

    public override string ToString(){
      return Name;
    }
  }

  public class TestPerson{
    public static void Main(){
      var person1 = new Person();

      var person2 = new Person("João");

      Console.WriteLine(person1);
      Console.WriteLine(person2);
    }
  }
}
