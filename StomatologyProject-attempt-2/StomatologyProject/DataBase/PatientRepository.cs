using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StomatologyProject.Mappers;
using StomatologyProject.ViewModels;

namespace StomatologyProject.DataBase
{
    public class PatientRepository : IBaseRepository<PatientViewModel>
    {
        public List<PatientViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Patient.ToList();
                return PatientMapper.Map(items);
            }
        }
        public PatientViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Patient.FirstOrDefault(x => x.Patientld == id);
                return PatientMapper.Map(item);
            }
        }
        public PatientViewModel Update(PatientViewModel entry)
        {
            using (var context = new Context())
            {
                int countG = context.Patient.ToList().Count;

                context.Patient.AddOrUpdate(PatientMapper.Map(entry));

                if (context.Patient.ToList().Count != countG)
                {
                    Delete(context.Patient.Last().Patientld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new PatientViewModel();
                }
            }
        }
        public PatientViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.Patient.Remove(context.Patient.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new PatientViewModel();
                }
            }
        }
        public PatientViewModel Add(PatientViewModel entry)
        {
            using (var context = new Context())
            {
                PatientEntity patientEntity = PatientMapper.Map(entry);

                if (context.Patient.Add(patientEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new PatientViewModel();
                }
            }
        }
    }
}

