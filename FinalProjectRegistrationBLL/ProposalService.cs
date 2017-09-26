using System;
using System.Collections.Generic;
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

        public ProposalBO Create(ProposalBO entity)
        {
            throw new NotImplementedException();
        }

        public ProposalBO Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<ProposalBO> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
