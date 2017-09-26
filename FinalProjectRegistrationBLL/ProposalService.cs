using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalProjectRegistrationBE;
using FinalProjectRegistrationBLL.Interfaces;
using FinalProjectRegistrationDAL;

namespace FinalProjectRegistrationBLL
{
    public class ProposalService : IProposalService
    {
        private readonly IDALFacade _facade;

        public ProposalService(IDALFacade facade)
        {
            _facade = facade;
        }

        public ProposalBO Create(ProposalBO proposal)
        {
            _facade.Proposals.Add(proposal);
            return proposal;
        }

        public ProposalBO Get(int id)
        {
            var proposal = _facade.Proposals.FirstOrDefault(p => p.Id == id);
            return proposal;
        }

        public IList<ProposalBO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
