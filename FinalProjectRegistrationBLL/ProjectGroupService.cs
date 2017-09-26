using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FinalProjectRegistrationBE;
using FinalProjectRegistrationBLL.Interfaces;

[assembly: InternalsVisibleTo("FinalProjectRegistrationBLLShould")]
namespace FinalProjectRegistrationBLL
{
    internal class ProjectGroupService : IProjectGroupService
    {
        public ProjectGroupBO Create(ProjectGroupBO entity)
        {
            throw new System.NotImplementedException();
        }

        public ProjectGroupBO Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<ProjectGroupBO> GetAll()
        {
            throw new System.NotImplementedException();
        }
    }
}