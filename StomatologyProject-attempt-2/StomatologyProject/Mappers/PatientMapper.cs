using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using StomatologyProject.ViewModels;

namespace StomatologyProject.Mappers
{
    public class PatientMapper
    {
        public static PatientViewModel Map(PatientEntity entity)
        {
            var viewModel = new PatientViewModel
            {
                Id = entity.Patientld,
                Name = entity.Name,
                Lastname = entity.Lastname,
                Middlename = entity.Middlename,
                Gender = entity.Gender == "М" ? "мужской" : "женский",
                Birthday = entity.Birthday,
                Address = entity.Address,
                Contactinfo = entity.Contactinfo,
                Userld = entity.Userld,
                User = entity.User,
            };
            return viewModel;
        }

        public static List<PatientViewModel> Map(List<PatientEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
        public static PatientEntity Map(PatientViewModel entity)
        {
            var patientEntity = new PatientEntity
            {
                Patientld = entity.Id,
                Lastname = Regex.IsMatch(entity.Lastname, @"^[а-яА-я]+$") == true ? entity.Lastname.Trim() : throw new Exception("Name"),
                Name = Regex.IsMatch(entity.Name, @"^[а-яА-я]+$") == true ? entity.Name.Trim() : throw new Exception("Name"),
                Middlename = Regex.IsMatch(entity.Middlename, @"^[а-яА-я]+$") == true ? entity.Middlename.Trim() : throw new Exception("Name"),
                Gender = entity.Gender == "мужской" ? "м" : entity.Gender == "женский" ? "ж" : throw new Exception("Gender"),
                Birthday = entity.Birthday,
                Address = entity.Address,
                Contactinfo = Regex.IsMatch(entity.Contactinfo, @"[7,8]{1}\s?[\(]{0,1}9[0-9]{2}[\)]{0,1}\s?\d{3}[-]{0,1}\d{2}[-]{0,1}\d{2}") == true ? entity.Contactinfo : throw new Exception("Contactinfo"),
                Userld = entity.Userld,
                User = entity.User,
            };
            return patientEntity;
        }

        public static List<PatientEntity> Map(List<PatientViewModel> entities)
        {
            var patientEntitys = entities.Select(x => Map(x)).ToList();
            return patientEntitys;
        }

    }
}

