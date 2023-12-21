using StomatologyProject.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StomatologyProject.Mappers
{
    public class AssistantMapper
    {
        public static AssistantViewModel Map(AssistantEntity entity)
        {
            var viewModel = new AssistantViewModel
            {
                Id = entity.Assistantld,
                Name = entity.Name,
                Lastname = entity.Lastname,
                Middlename = entity.Middlename,
                Contactinfo = entity.Contactinfo,
                Specialization = entity.Specialization,
            };
            return viewModel;
        }
        public static List<AssistantViewModel> Map(List<AssistantEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;

        }
        public static AssistantEntity Map(AssistantViewModel entity)
        {
            var assistantEntity = new AssistantEntity
            {
                Assistantld = entity.Id,
                Name = Regex.IsMatch(entity.Name, @"^[а-яА-я]+$") == true ? entity.Name.Trim() : throw new Exception("Name"),
                Middlename = Regex.IsMatch(entity.Middlename, @"^[а-яА-я]+$") == true ? entity.Middlename.Trim() : throw new Exception("Name"),
                Contactinfo = Regex.IsMatch(entity.Contactinfo, @"[7,8]{1}\s?[\(]{0,1}9[0-9]{2}[\)]{0,1}\s?\d{3}[-]{0,1}\d{2}[-]{0,1}\d{2}") == true ? entity.Contactinfo : throw new Exception("Contactinfo"),
                Specialization = entity.Specialization,
            };
            return assistantEntity;
        }
        public static List<AssistantEntity> Map(List<AssistantViewModel> entities)
        {
            var assistantEntity = entities.Select(x => Map(x)).ToList();
            return assistantEntity;
        }
    }
}

