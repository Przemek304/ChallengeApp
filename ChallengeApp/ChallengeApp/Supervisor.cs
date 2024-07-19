
using ChallengeApp;

namespace CHallengeApp
{
    // kierownik podobny do klasy employee ale ma obsłużoną metode addgrade typu string 
    // i nowy zakres  liczb
    public class Supervisor : IEmployee
    {
        List<float> grade = new List<float>();
        public string Name => "Adam";

        public string SureName => "Kamizelch";

        public void AddGrade(int grade)
        {
            float value = grade;
            this.AddGrade(value);
        }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.AddGrade(grade);
            }
            else
            {
                throw new Exception("invalid grade value");
            }
        }

        public void AddGrade(double grade)
        {
            float value = (float)grade;
            this.AddGrade(value);
        }

        public void AddGrade(char grade)
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



        public void AddGrade(string grade)
        {
            switch (grade)
            {
                case "6":
                    AddGrade(95);
                    break;
                case "6+":
                    AddGrade(100);
                    break;
                case "6-":
                    AddGrade(90);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "5+":
                    AddGrade(85);
                    break;
                case "5-":
                    AddGrade(75);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "4+":
                    AddGrade(65);
                    break;
                case "4-":
                    AddGrade(55);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "3+":
                    AddGrade(45);
                    break;
                case "3-":
                    AddGrade(35);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "2-":
                    AddGrade(15);
                    break;
                case "2+":
                    AddGrade(25);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("invalid grade value");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grade)
            {
                statistics.Max = Math.Max(statistics.Max, grade);

                statistics.Min = Math.Min(statistics.Min, grade);

                statistics.Average = statistics.Average + grade;
            }



            statistics.Average /= this.grade.Count;

            switch (statistics.Average)
            {
                case var average when average >= 80:
                    this.AddGrade('A');
                    break;
                case var average when average >= 60:
                    this.AddGrade('B');
                    break;
                case var average when average >= 40:
                    this.AddGrade('C');
                    break;
                case var average when average >= 20:
                    this.AddGrade('D');
                    break;
                default:
                    statistics.Average = 'E';
                    break;
            }
            return statistics;
        }
    }
}