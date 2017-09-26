using System;
using System.Collections.Generic;
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
            Name = "D4FF",
            StudentIds = new List<int>{2}
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
            Assert.Throws<ArgumentNullException>(() => _service.Create(null));
        }

        [Fact]
        public void HaveStudentsWhenCreated()
        {
            var result = _service.Create(MockProjectGroup).StudentIds;

            Assert.NotEmpty(result);
        }

        [Fact]
        public void NotHaveStudentsThatAlreadyHaveAGroup()
        {
            MockProjectGroup.StudentIds = new List<int>{1, 2};
            Assert.Throws<InvalidOperationException>(() => _service.Create(MockProjectGroup));
        }

    }
}