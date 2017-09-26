using System.Collections;
using System.Collections.Generic;
using FinalProjectRegistrationBE;

namespace FinalProjectRegistrationDAL
{
    public interface IDALFacade
    {
        IList<ProposalBO> Proposals { get; }
        IList<StudentBO> Students { get; }
        IList<ProjectGroupBO> ProjectGroups { get; }
    }
}