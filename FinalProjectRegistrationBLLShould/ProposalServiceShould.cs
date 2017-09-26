using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FinalProjectRegistrationBLL;
using FinalProjectRegistrationDAL;
using Xunit;

namespace FinalProjectRegistrationBLLShould
{
    class ProposalServiceShould : IBLLTest
    {
        private readonly DALFacade _facade = new DALFacade();
        private readonly ProposalService _service = new ProposalService();

        [Fact]
        public void GetOne()
        {
            Assert.NotNull(_service.Get(0));
        }

        [Fact]
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void CreateOne()
        {
            throw new NotImplementedException();
        }
        [Fact]
        public void NotCreateOne()
        {
            throw new NotImplementedException();
        }
    }
}
