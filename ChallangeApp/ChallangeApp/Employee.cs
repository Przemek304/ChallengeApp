


namespace ChallangeApp
{

    public class Employee
    {


        private List<int> score = new List<int>();
        public Employee(string name, string surename, int age)
        {
            this.Name = name;
            this.SureName = surename;
            this.Age = age;
        }
        public string Name { get; private set; }

        public string SureName { get; private set; }

        public int Age { get; private set; }

        public string Score { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }
        public void AddScore(int newScore)
        {
            this.score.Add(newScore);
        }



    }

}

