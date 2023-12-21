using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatologyProject.ViewModels
{
    public class SpecializationViewModel
    {
        public string Name { get; set; }
        public long Wages { get; set; }
        public string Workschedule { get; set; }
        public List<AssistantEntity> Assistant { get; set; }
        public List<DoctorEntity> Doctor { get; set; }
    }
}
