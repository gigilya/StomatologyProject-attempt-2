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
    public class EntryRepository : IBaseRepository<EntryViewModel>
    {
        public List<EntryViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.Entry.ToList();
                return EntryMapper.Map(items);
            }
        }
        public EntryViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.Entry.FirstOrDefault(x => x.Entryld == id);
                return EntryMapper.Map(item);
            }
        }
        public EntryViewModel Update(EntryViewModel entry)
        {
            using (var context = new Context())
            {
                int countG = context.Entry.ToList().Count;

                context.Entry.AddOrUpdate(EntryMapper.Map(entry));

                if (context.Entry.ToList().Count != countG)
                {
                    Delete(context.Entry.Last().Entryld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new EntryViewModel();
                }
            }
        }
        public EntryViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.Entry.Remove(context.Entry.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new EntryViewModel();
                }
            }
        }
        public EntryViewModel Add(EntryViewModel entry)
        {
            using (var context = new Context())
            {
                EntryEntity entryEntity = EntryMapper.Map(entry);

                if (context.Entry.Add(entryEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new EntryViewModel();
                }
            }
        }
    }
}

