using System.Threading.Tasks;

namespace MindBehind.InterviewTest.Data
{
    public interface IInterviewTestDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
