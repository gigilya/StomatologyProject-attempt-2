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
    public class ProcedureRepository : IBaseRepository<ProcedureViewModel>
    {
        public List<ProcedureViewModel> GetList()
        {
            using (var context = new Context())
            {
                var item = context.Procedure.ToList();
                return ProcedureMapper.Map(item);
            }
        }
        public ProcedureViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var items = context.Procedure.FirstOrDefault(x => x.Procedureld == id);
                return ProcedureMapper.Map(items);
            }
        }
        public ProcedureViewModel Update(ProcedureViewModel entry)
        {
            using (var context = new Context())
            {
                int countG = context.Procedure.ToList().Count;

                context.Procedure.AddOrUpdate(ProcedureMapper.Map(entry));

                if (context.Procedure.ToList().Count != countG)
                {
                    Delete(context.Procedure.Last().Procedureld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new ProcedureViewModel();
                }
            }
        }
        public ProcedureViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.Procedure.Remove(context.Procedure.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new ProcedureViewModel();
                }
            }
        }
        public ProcedureViewModel Add(ProcedureViewModel entry)
        {
            using (var context = new Context())
            {
                ProcedureEntity procedureEntity = ProcedureMapper.Map(entry);

                if (context.Procedure.Add(procedureEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new ProcedureViewModel();
                }
            }
        }
    }
}

