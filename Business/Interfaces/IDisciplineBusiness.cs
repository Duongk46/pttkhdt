using Common.DTO;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IDisciplineBusiness
    {
        void EditDiscipline(DisciplineDTO disciplineDTO);
        DisciplineDTO GetDisciplineById(long id);
        void DeleteDiscipline(long id);
        void CreateDiscipline(DisciplineDTO disciplineDTO);
        IEnumerable<DisciplineDTO> SelectByQuantityItem(int page, int pageSize);
        long GetTotal();

    }
}
