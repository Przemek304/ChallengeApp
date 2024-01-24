User user1 = new User("Adam", "12345");
User user2 = new User("Monika", "12345");
User user3 = new User("Zuzia", "12345");
User user4 = new User("Damian", "12345");


user1.AddScore(5);

class User
{
    private int score;
  

    public User(string login, string password)
    {
        this.Login = login;
        this.Password = password;
        this.score = 0;
    }
    public string Login { get; private set; }

    public string Password { get; private set; }

    public void AddScore(int socre)
    {

    }
}
