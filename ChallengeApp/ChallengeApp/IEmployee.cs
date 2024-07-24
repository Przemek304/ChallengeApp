

using ChallengeApp;

namespace ChallengeApp
{
    // interfejs ( lista  tego co ma znajdować się w innych klasach)
    public interface IEmployee
    {
        string Name { get;   }
        string SureName { get; }
        void AddGrade(int grade);
        void AddGrade(float grade);
        void AddGrade(double grade);
        void AddGrade(char grade);
        void AddGrade(string grade);
        Statistics GetStatistics();
    }
}
