using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatologyProject.ViewModels
{
    public class UserViewModel
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Passworded { get; set; }
        public List<DoctorEntity> Doctor { get; set; }
        public List<AssistantEntity> Assistant_ { get; set; }
    }
}
