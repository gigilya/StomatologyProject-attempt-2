using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StomatologyProject.ViewModels;

namespace StomatologyProject.Mappers
{
    public class DoctorMapper
    {
        public static DoctorViewModel Map(DoctorEntity entity)
        {
            var viewModel = new DoctorViewModel
            {
                Id = entity.Doctorld,
                User = entity.User,
                Name = entity.Name,
                Lastname = entity.Lastname,
                Middlename = entity.Middlename,
                Contactinfo = entity.Contactinfo,
                Specialization = entity.Specialization,
            };
            return viewModel;
        }
        public static List<DoctorViewModel> Map(List<DoctorEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
        public static DoctorEntity Map(DoctorViewModel entity)
        {
            var doctorEntity = new DoctorEntity
            {
                Doctorld = entity.Id,
                User = entity.User,
                Lastname = Regex.IsMatch(entity.Lastname, @"^[а-яА-я]+$") == true ? entity.Lastname.Trim() : throw new Exception("Name"),
                Name = Regex.IsMatch(entity.Name, @"^[а-яА-я]+$") == true ? entity.Name.Trim() : throw new Exception("Name"),
                Middlename = Regex.IsMatch(entity.Middlename, @"^[а-яА-я]+$") == true ? entity.Middlename.Trim() : throw new Exception("Name"),
                Contactinfo = Regex.IsMatch(entity.Contactinfo, @"[7,8]{1}\s?[\(]{0,1}9[0-9]{2}[\)]{0,1}\s?\d{3}[-]{0,1}\d{2}[-]{0,1}\d{2}") == true ? entity.Contactinfo : throw new Exception("Contactinfo"),
                Specialization = entity.Specialization,
            };
            return doctorEntity;
        }
        public static List<DoctorEntity> Map(List<DoctorViewModel> entities)
        {
            var doctorEntity = entities.Select(x => Map(x)).ToList();
            return doctorEntity;
        }
    }
}

