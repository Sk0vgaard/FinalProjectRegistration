using System;
using FinalProjectRegistrationBE;
using FinalProjectRegistrationBLL;
using FinalProjectRegistrationBLL.Interfaces;
using FinalProjectRegistrationDAL;
using Xunit;

namespace FinalProjectRegistrationBLLShould
{
    public class ProjectGroupServiceShould : IBLLTest
    {
        private readonly IProjectGroupService _service;

        private readonly ProjectGroupBO MockProjectGroup = new ProjectGroupBO()
        {
            Id = 4,
            Name = "D4FF"
        };

        public ProjectGroupServiceShould()
        {
            _service = new ProjectGroupService(new DALFacade());
        }

        [Fact]
        public void GetOne()
        {
            var result = _service.Get(2);

            Assert.NotNull(result);
        }

        [Fact]
        public void NotGetOneWithNonExistingId()
        {
            var result = _service.Get(0);

            Assert.Null(result);
        }

        [Fact]
        public void GetAll()
        {
            var result = _service.GetAll();

            Assert.NotEmpty(result);
        }

        [Fact]
        public void CreateOne()
        {
            var result = _service.Create(MockProjectGroup);

            Assert.NotNull(result);
        }

        [Fact]
        public void NotCreateOneWithNull()
        {
            try
            {
                _service.Create(null);

            }
            catch (Exception e)
            {
                Assert.IsType<ArgumentNullException>(e);
            }
        }
    }
}