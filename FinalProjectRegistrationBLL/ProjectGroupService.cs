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
        public ProjectGroupBO Create(ProjectGroupBO projectGroup)
        {
            if (projectGroup == null) throw new ArgumentNullException("Argument is null.");

            foreach (var group in _facade.ProjectGroups)
            {
                if(group.StudentIds.Intersect(projectGroup.StudentIds).Any()) throw new InvalidOperationException("One or more students already have a group.");
            }

            _facade.ProjectGroups.Add(projectGroup);
            return projectGroup;
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