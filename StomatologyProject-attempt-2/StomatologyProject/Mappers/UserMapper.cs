using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StomatologyProject.ViewModels;

namespace StomatologyProject.Mappers
{
    public class UserMapper
    {
            public static UserViewModel Map(UserEntity entity)
            {
                var viewModel = new UserViewModel
                {
                    Id = entity.Userld,
                    Login = entity.Login,
                    Passworded = entity.Password,
                };
                return viewModel;
            }
            public static List<UserViewModel> Map(List<UserEntity> entities)
            {
                var viewModels = entities.Select(x => Map(x)).ToList();
                return viewModels;
            }
            public static UserEntity Map(UserViewModel entity)
            {
                var viewModel = new UserEntity
                {
                    Userld = entity.Id,
                    Login = entity.Login,
                    Password = entity.Passworded
                };
                return viewModel;
            }
            public static List<UserEntity> Map(List<UserViewModel> entities)
            {
                var viewModels = entities.Select(x => Map(x)).ToList();
                return viewModels;
            }
    }
}
