using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using FinalProjectRegistrationBE;
using FinalProjectRegistrationBLL.Interfaces;
using FinalProjectRegistrationDAL;

[assembly: InternalsVisibleTo("FinalProjectRegistrationBLLShould")]
namespace FinalProjectRegistrationBLL
{
    internal class ProjectGroupService : IProjectGroupService
    {
        private IDALFacade _facade;
        public ProjectGroupService(IDALFacade facade)
        {
            _facade = facade;
        }
        public ProjectGroupBO Create(ProjectGroupBO proposal)
        {
            if (proposal == null) throw new ArgumentNullException("Argument is null");
            _facade.ProjectGroups.Add(proposal);
            return proposal;
        }

        public ProjectGroupBO Get(int id)
        {
            return _facade.ProjectGroups.FirstOrDefault(p => p.Id == id);
        }

        public IList<ProjectGroupBO> GetAll()
        {
            return _facade.ProjectGroups;
        }
    }
}