using ChallengeApp;

namespace ChallengeApp;

// przejżeć tą klase żeby wiedzieć co i  jak
public abstract class EmployeeBase : IEmployee                   
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);

    public event GradeAddedDelegate GradeAdded;
    public EmployeeBase(string name, string surename)
    {
        this.Name = name;
        this.SureName = surename;
    }                           
    public string Name { get; set; }
    public string SureName { get; set; }

    public abstract void AddGrade(int grade);

    public abstract void AddGrade(float grade);

    public abstract void AddGrade(double grade);

    public abstract void AddGrade(char grade);

    public abstract void AddGrade(string grade);

    public abstract Statistics GetStatistics();

}