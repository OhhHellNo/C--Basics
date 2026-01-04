//// an object in c# is a instance of a class .
/// a  class is used as  a blueprint to create objects. 
///  objects can have fields and methods .
namespace Chill
{
public static void Main(string[] args)
{
    Human human1 = new Human();
    human1.name = "chill";
    human1.age = 19;
    human1.Eat();
    human1.sleep();
}


    class Human
    {

       public  string name;
        int age;
       public  void Eat() 
        {
            Console.WriteLine(name + "is eatiing");
        }

       public void sleep()
        {
            System.Console.WriteLine(name + "'is sleeping");
        }
    }



}
