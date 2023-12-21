using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatologyProject.ViewModels
{
    public class DoctorViewModel
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public string Middlename { get; set; }
        public string Contactinfo { get; set; }
        public virtual UserEntity User { get; set; }
        public virtual SpecializationEntity Specialization { get; set; }
        public List<ProcedureEntity> Procedure { get; set; }
    }
}
