using System.Collections.Generic;
using FinalProjectRegistrationBE;

namespace FinalProjectRegistrationDAL
{
    public class DALFacade : IDALFacade
    {
        public IList<ProposalBO> Proposals => new List<ProposalBO>()
        {
            new ProposalBO()
            {
                Title = "Mock",
                Objectives = "Mock"
            },
            new ProposalBO()
            {
                Title = "Mock 2",
                Objectives = "Mock"
            },
            new ProposalBO()
            {
                Title = "Mock 3",
                Objectives = "Mock"
            }
        };
        public IList<StudentBO> Students => new List<StudentBO>()
        {
            new StudentBO()
            {
                Id = 1,
                Name = "Mock",
                Email = "Mock",
                Phone = 123
            },
            new StudentBO()
            {
                Id = 2,
                Name = "Mock 2",
                Email = "Mock",
                Phone = 123
            },
            new StudentBO()
            {
                Id = 3,
                Name = "Mock 3",
                Email = "Mock",
                Phone = 123
            },
            new StudentBO
            {
                Id = 4,
                Name = "Mock 4",
                Email = "Mock",
                Phone = 123
            }
        };

        public IList<ProjectGroupBO> ProjectGroups => new List<ProjectGroupBO>()
        {
            new ProjectGroupBO()
            {
                Id = 1,
                Name = "D4FF",
                StudentIds = new List<int>{1}
            },
            new ProjectGroupBO()
            {
                Id = 2,
                Name = "D4FF 2",
                StudentIds = new List<int>{3}

            },
            new ProjectGroupBO()
            {
                Id = 3,
                Name = "D4FF 3",
                StudentIds = new List<int>{4}
            }
        };
    }
}