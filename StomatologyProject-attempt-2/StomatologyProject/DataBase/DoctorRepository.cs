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
    public class DoctorRepository : IBaseRepository<DoctorViewModel>
    {
        public List<DoctorViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Doctor.ToList();
                return DoctorMapper.Map(items);
            }
        }
        public DoctorViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Doctor.FirstOrDefault(x => x.Doctorld == id);
                return DoctorMapper.Map(item);
            }
        }
        public DoctorViewModel Update(DoctorViewModel doctor)
        {
            using (var context = new Context())
            {
                int countG = context.Doctor.ToList().Count;

                context.Doctor.AddOrUpdate(DoctorMapper.Map(doctor));

                if (context.Doctor.ToList().Count != countG)
                {
                    Delete(context.Doctor.Last().Doctorld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new DoctorViewModel();
                }
            }
        }
        public DoctorViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.Doctor.Remove(context.Doctor.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new DoctorViewModel();
                }
            }
        }

        public DoctorViewModel Add(DoctorViewModel doctor)
        {
            using (var context = new Context())
            {
                DoctorEntity doctorEntity = DoctorMapper.Map(doctor);

                if (context.Doctor.Add(doctorEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new DoctorViewModel();
                }
            }
        }
    }
}

