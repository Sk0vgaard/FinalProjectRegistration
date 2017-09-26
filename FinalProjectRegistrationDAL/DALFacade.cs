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
                Name = "Mock",
                Email = "Mock",
                Phone = 123
            },
            new StudentBO()
            {
                Name = "Mock 2",
                Email = "Mock",
                Phone = 123
            },
            new StudentBO()
            {
                Name = "Mock 3",
                Email = "Mock",
                Phone = 123
            }
        };
    }
}