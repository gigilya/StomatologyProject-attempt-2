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
    public class UserRepository : IBaseRepository<UserViewModel>
    {
        public List<UserViewModel> GetList()
        {
            using (var context = new Context())
            {
                var items = context.User.ToList();
                return UserMapper.Map(items);
            }
        }
        public UserViewModel GetById(long id)
        {
            using (var context = new Context())
            {
                var item = context.User.FirstOrDefault(x => x.Userld == id);
                return UserMapper.Map(item);
            }
        }
        public UserViewModel Update(UserViewModel user)
        {
            using (var context = new Context())
            {
                int countG = context.User.ToList().Count;

                context.User.AddOrUpdate(UserMapper.Map(user));

                if (context.User.ToList().Count != countG)
                {
                    Delete(context.User.Last().Userld);
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new UserViewModel();
                }
            }
        }
        public UserViewModel Delete(long id)
        {
            using (var context = new Context())
            {
                if (context.User.Remove(context.User.Find(id)) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new UserViewModel();
                }
            }
        }

        public UserViewModel Add(UserViewModel user)
        {
            using (var context = new Context())
            {
                UserEntity userEntity = UserMapper.Map(user);

                if (context.User.Add(userEntity) == null)
                {
                    return null;
                }
                else
                {
                    context.SaveChanges();
                    return new UserViewModel();
                }
            }
        }
    }
}

