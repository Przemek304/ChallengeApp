
using ChallengeApp;

namespace ChalleneApp
{
    // przejżeć tą klase żeby wiedzieć po co ona jest , o co w niej chodzi
    public class EmployeeInMemory : EmployeeBase
    {
        public delegate void GradeAddedDelegate(object sender , EventArgs args);

        public event GradeAddedDelegate GradeAdded;

        List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surename)
            : base(name, surename)
        {
            
        }
        
   
        public override void AddGrade(int grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

              if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }

        }


        public override void AddGrade(double grade)
        {
            var value = (float)grade;
            this.AddGrade(value);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }

        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out var value))
            {
                this.AddGrade(value);
            }
            else
            {
                throw new Exception("Invalid grade value");
            }

        }

        public override Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }
            statistics.Average /= grades.Count;


            switch (statistics.Average)
            {
                case var average when average >= 80:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    statistics.AverageLetter = 'D';
                    break;
                default:
                    statistics.AverageLetter = 'E';
                    break;

            }
           
            return statistics;

           
        }
    }
}