/* basic definition of a list is that List<T> is a dynamic container.
   it can grow and shrink at runtime.
   T means it can store objects of any type.

   example usage:
   List<int> numbers = new List<int>();
   List<string> names = new List<string>();
   List<Type> name = new List<Type>();
*/

class Program
{
    public static void Main(string[] args)
    {
        List<Player> players = new List<Player>();

        Player player1 = new Player("chill");
        Player player2 = new Player("ma");
        Player player3 = new Player("coding");

        players.Add(player1);
        players.Add(player2);
        players.Add(player3);

        players.ForEach(p => Console.WriteLine(p.Username));
    }
}

class Player
{
    public string Username;

    public Player(string username)
    {
        this.Username = username;
    }

    public override string ToString()
    {
        return Username;
    }
}
