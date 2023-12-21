using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatologyProject.ViewModels
{
    public class PatientViewModel
    {
        public long Id { get; set; }
        public long Userld { get; set; }
        public string Lastname { get; set; }
        public string Name { get; set; }
        public string Middlename { get; set; }
        public string Gender { get; set; }
        public string Birthday { get; set; }
        public string Address { get; set; }
        public string Contactinfo { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
