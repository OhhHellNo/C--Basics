class Overloading
{


    public static void Main(string[] args)
    {
        Multiply(5, 2);
        Multiply(5, 5, 3);



    }
    static int Multiply(int a, int b)
    {

        return a * b;
    }
    static int Multiply(int a, int b, int c)
    {

        return a * b * c;
    }

}