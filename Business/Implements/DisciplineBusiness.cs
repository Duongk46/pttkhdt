using AutoMapper;
using Business.Interfaces;
using Common.DTO;
using Entities.Entities;
using Repositories.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Implements
{
    public class DisciplineBusiness : IDisciplineBusiness
    {
        private readonly IDisciplineRepository _disciplineRepository;
        private readonly IMapper _mapper;
        public DisciplineBusiness(IDisciplineRepository disciplineRepository, IMapper mapper)
        {
            _disciplineRepository = disciplineRepository;
            _mapper = mapper;
        }
        public void EditDiscipline(DisciplineDTO disciplineDTO)
        {
            var Discipline = new Discipline();
            Discipline = _mapper.Map<DisciplineDTO, Discipline>(disciplineDTO);
            _disciplineRepository.Update(Discipline);
            _disciplineRepository.Save();
        }
        public DisciplineDTO GetDisciplineById(long id)
        {
            var Discipline = _disciplineRepository.SelectById(id);
            var DisciplineDto = _mapper.Map<Discipline, DisciplineDTO>(Discipline);
            return DisciplineDto;
        }
        public void DeleteDiscipline(long id)
        {
            _disciplineRepository.Delete(id);
            _disciplineRepository.Save();
        }
        public void CreateDiscipline(DisciplineDTO disciplineDTO)
        {
            disciplineDTO.CreatedDate = DateTime.Now;
            var discipline = _mapper.Map<DisciplineDTO, Discipline>(disciplineDTO);
            _disciplineRepository.Insert(discipline);
            _disciplineRepository.Save();
        }
        public IEnumerable<DisciplineDTO> SelectByQuantityItem(int page, int pageSize)
        {
            var discipline = _disciplineRepository.SelectByQuantityItem(page, pageSize);
            var disciplineDto = discipline.Select(item => _mapper.Map<Discipline, DisciplineDTO>(item));
            return disciplineDto;
        }
        public long GetTotal()
        {
            return _disciplineRepository.GetTotal();
        }
    }
}
