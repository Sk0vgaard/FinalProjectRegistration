using System;
using FinalProjectRegistrationBE;
using FinalProjectRegistrationBLL;
using FinalProjectRegistrationDAL;
using Xunit;

namespace FinalProjectRegistrationBLLShould
{
    public class ProposalServiceShould : IBLLTest
    {
        private readonly ProposalService _service;

        public ProposalServiceShould()
        {
            _service = new ProposalService(new DALFacade());
        }

        [Fact]
        public void CreateOne()
        {
            var result =_service.Create(
                new ProposalBO
                {
                    Id = 4,
                    Objectives = "Mock4",
                    Title = "Mock4"
                }
            );
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAll()
        {
            throw new NotImplementedException();
        }

        [Fact]
        public void GetOne()
        {
            Assert.NotNull(_service.Get(1));
        }

        [Fact]
        public void NotCreateOneWithNull()
        {
            Assert.Throws<ArgumentNullException>(() => _service.Create(null));
        }

        [Fact]
        public void NotGetOneWithNonExistingId()
        {
            Assert.Null(_service.Get(0));
        }
    }
}