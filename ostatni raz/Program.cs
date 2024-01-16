User user1 = new User("Ada","1975");
User user2 = new User("Monika","1975");
User user3 = new User("Zuza","1975");
User user4 = new User("Damian","1975");

user1.AddScore(5);
user1.AddScore(2);
int result = user1.Result;
Console.WriteLine(result);
string name = User.GameName;
Console.WriteLine(name);
class User
{

    public static string GameName = "Diablo";
    private List<int> score = new List<int>();

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;

    }
    public string Login { get; private set; }
    public string Password { get; private set; }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int number) 
    {
        this.score.Add(number);

    }
    

}

