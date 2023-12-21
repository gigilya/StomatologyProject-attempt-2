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
    public class SpecializationRepository : IBaseRepository<SpecializationViewModel>
    {
        public List<SpecializationViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Specialization.ToList();
                return SpecializationMapper.Map(items);
            }
        }
        public SpecializationViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Specialization.FirstOrDefault(x => x.Specializationld == id);
                return SpecializationMapper.Map(item);
            }
        }
        public SpecializationViewModel Update(SpecializationViewModel entry)
        {
            using (var context = new Context())
            {
                int countG = context.Specialization.ToList().Count;

                context.Specialization.AddOrUpdate(SpecializationMapper.Map(entry));

                if (context.Specialization.ToList().Count != countG)
                {
                    Delete(context.Specialization.Last().Specializationld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new SpecializationViewModel();
                }
            }
        }
        public SpecializationViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.Specialization.Remove(context.Specialization.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new SpecializationViewModel();
                }
            }
        }
        public SpecializationViewModel Add(SpecializationViewModel entry)
        {
            using (var context = new Context())
            {
                SpecializationEntity specialisationEntity = SpecializationMapper.Map(entry);

                if (context.Specialization.Add(specialisationEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new SpecializationViewModel();
                }
            }
        }
    }
}

