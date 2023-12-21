using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StomatologyProject.ViewModels;

namespace StomatologyProject.Mappers
{
    public class EntryMapper
    {
        public static EntryViewModel Map(EntryEntity entity)
        {
            var entryViewModel = new EntryViewModel
            {
                Patient = entity.Patient,
                Procedure = entity.Procedure,
                Datereceipt = entity.Datereceipt,
                Statusreceipt = entity.Statusreceipt,

            };
            return entryViewModel;
        }
        public static List<EntryViewModel> Map(List<EntryEntity> entities)
        {
            var viewModel = entities.Select(x => Map(x)).ToList();
            return viewModel;
        }
        public static EntryEntity Map(EntryViewModel entity)
        {
            var entryEntity = new EntryEntity
            {
                Patient = entity.Patient,
                Procedure = entity.Procedure,
                Datereceipt = entity.Datereceipt,
                Statusreceipt = entity.Statusreceipt,

            };
            return entryEntity;
        }
        public static List<EntryEntity> Map(List<EntryViewModel> entities)
        {
            var entryEntity = entities.Select(x => Map(x)).ToList();
            return entryEntity;
        }
    }
}

