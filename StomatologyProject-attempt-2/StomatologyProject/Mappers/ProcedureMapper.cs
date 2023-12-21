using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StomatologyProject.ViewModels;

namespace StomatologyProject.Mappers
{
    public class ProcedureMapper
    {
        public static ProcedureViewModel Map(ProcedureEntity entity)
        {
            var viewModel = new ProcedureViewModel()
            {
                Id = entity.Procedureld,
                Description = entity.Proceduredescription,
                Price = entity.Price,
                Doctor = entity.Doctor,
                Assistant = entity.Assistant,
                Entry = entity.Entry.ToList()
            };
            return viewModel;
        }
        public static List<ProcedureEntity> Map(List<ProcedureViewModel> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
        public static ProcedureEntity Map(ProcedureViewModel entity)
        {
            var procedureEntity = new ProcedureEntity()
            {
                Procedureld = entity.Id,
                Proceduredescription = entity.Description,
                Price = entity.Price,
                Doctor = entity.Doctor,
                Assistant = entity.Assistant,
                Entry = entity.Entry
            };
            return procedureEntity;
        }
        public static List<ProcedureViewModel> Map(List<ProcedureEntity> entities)
        {
            var viewModels = entities.Select(x => Map(x)).ToList();
            return viewModels;
        }
    }
}

