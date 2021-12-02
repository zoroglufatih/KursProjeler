using IleriRepository.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Abstract
{
    public interface IEmpRepository
    {
        void IncreaseSalarybyPercent(decimal rate);
        List<HumanDTO> SummaryList();
    }
}
