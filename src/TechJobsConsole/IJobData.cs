namespace TechJobsConsole
{
    interface IJobData
    {
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}