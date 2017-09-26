using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectRegistrationBE
{
    public class ProjectGroupBO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> StudentIds { get; set; }
    }
}
