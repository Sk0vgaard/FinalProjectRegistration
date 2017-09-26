using System;
using FinalProjectRegistrationBLL;
using FinalProjectRegistrationDAL;
using Xunit;

namespace FinalProjectRegistrationBLLShould
{
    public class ProposalServiceShould : IBLLTest
    {
        public ProposalServiceShould()
        {
            _service = new ProposalService(new DALFacade());
        }

        private readonly ProposalService _service;

        [Fact]
        public void CreateOne()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetOne()
        {
            Assert.NotNull(_service.Get(0));
        }

        [Fact]
        public void NotCreateOneWithNull()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void NotGetOneWithNonExistingId()
        {
            throw new NotImplementedException();
        }
    }
}