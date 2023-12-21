using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StomatologyProject.ViewModels;

namespace StomatologyProject.Mappers
{
    public class SpecializationMapper
    {
        public static SpecializationViewModel Map(SpecializationEntity entity)
        {
            var viewModel = new SpecializationViewModel
            {
                Name = entity.Name,
                Wages = entity.Wages,
                Workschedule = entity.Workschedule,
            };
            return viewModel;
        }
        public static List<SpecializationViewModel> Map(List<SpecializationEntity> entities)
        {
            var viewModel = entities.Select(x => Map(x)).ToList();
            return viewModel;
        }
        public static SpecializationEntity Map(SpecializationViewModel entity)
        {
            var specializationEntity = new SpecializationEntity
            {
                Name = entity.Name,
                Wages = entity.Wages,
                Workschedule = entity.Workschedule,
            };
            return specializationEntity;
        }
        public static List<SpecializationEntity> Map(List<SpecializationViewModel> entities)
        {
            var specializationEntity = entities.Select(x => Map(x)).ToList();
            return specializationEntity;
        }
    }
}

