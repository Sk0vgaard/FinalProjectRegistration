using FinalProjectRegistrationBLL;
using FinalProjectRegistrationBLL.Interfaces;
using FinalProjectRegistrationDAL;
using Xunit;

namespace FinalProjectRegistrationBLLShould
{
    public class ProjectGroupServiceShould : IBLLTest
    {
        private readonly IDALFacade _facade = new DALFacade();
        private readonly IProjectGroupService _service;

        public ProjectGroupServiceShould()
        {
            _service = new ProjectGroupService();
        }

        [Fact]
        public void GetOne()
        {
            Assert.NotNull(_service.Get(0));
        }
        [Fact]
        public void GetAll()
        {
            throw new System.NotImplementedException();
        }
        [Fact]
        public void CreateOne()
        {
            throw new System.NotImplementedException();
        }
        [Fact]
        public void NotCreateOne()
        {
            throw new System.NotImplementedException();
        }
    }
}