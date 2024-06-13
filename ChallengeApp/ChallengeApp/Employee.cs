namespace ChallengeApp
{

    public class Employee
    {
        private List<float> grades = new List<float>();
        public Employee(string name, string surename)
        {
            this.Name = name;
            this.Surename = surename;
        }
        public string Name { get; set; }

        public string Surename { get; set; }

        public void AddGrades(float grade)
        {
            this.grades.Add(grade);
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average = statistics.Average + grade;
            }

            statistics.Average = statistics.Average / this.grades.Count;

            return statistics;

        }

    }
}