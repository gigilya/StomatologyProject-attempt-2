using StomatologyProject.Mappers;
using StomatologyProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatologyProject.DataBase
{
    public class AssistantRepository : IBaseRepository<AssistantViewModel>
    {
        public List<AssistantViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Assistant.ToList();
                return AssistantMapper.Map(items);
            }
        }
        public AssistantViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Assistant.FirstOrDefault(x => x.Assistantld == id);
                return AssistantMapper.Map(item);
            }
        }
        public AssistantViewModel Update(AssistantViewModel assistant)
        {
            using (var context = new Context())
            {
                int countG = context.Assistant.ToList().Count;

                context.Assistant.AddOrUpdate(AssistantMapper.Map(assistant));

                if (context.Assistant.ToList().Count != countG)
                {
                    Delete(context.Assistant.Last().Assistantld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new AssistantViewModel();
                }
            }
        }
        public AssistantViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.Assistant.Remove(context.Assistant.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new AssistantViewModel();
                }
            }
        }

        public AssistantViewModel Add(AssistantViewModel assistant)
        {
            using (var context = new Context())
            {
                AssistantEntity assistantEntity = AssistantMapper.Map(assistant);

                if (context.Assistant.Add(assistantEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new AssistantViewModel();
                }
            }
        }
    }
}

