

using System.Runtime.InteropServices;

namespace ChallengeApp
{
   
    public class User
    {
        private List<int> score = new List<int>();
        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;

        }


        public string Login { get; set; }
        public string Password { get; set; }

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
}
