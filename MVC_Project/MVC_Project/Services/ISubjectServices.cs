using MVC_Project.Models;

namespace MVC_Project.Services
{
    public interface ISubjectServices
    {
        public IEnumerable<Subject> GetAllSubjects();
        public void DeleteASubject(int id);
    }
}
