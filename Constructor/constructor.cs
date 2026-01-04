//special type of  method in class
// same name as the class name 
//can be used to assign arguements to fields when creating an object .



//// an object in c# is a instance of a class .
/// a  class is used as  a blueprint to create objects. 
///  objects can have fields and methods .
namespace Chill
{
    public static void Main(string[] args)
    {
        Human human1 = new Human("Rick", 21);

        human1.Eat();
        human1.sleep();
    }


    class Human
    {
        public Human(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public string name;
        int age;

        public void Eat()
        {
            Console.WriteLine(name + "is eatiing");
        }

        public void sleep()
        {
            System.Console.WriteLine(name + "'is sleeping");
        }
    }



}
