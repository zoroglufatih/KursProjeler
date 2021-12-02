using IleriRepository.Concrete;
using IleriRepository.DTO;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class EducationRepository : BaseRepository<Education>, IEducationRepository
    {
        public ComboBox GetCombo(ComboBox cb)
        {
            cb.DataSource = GetOption();
            cb.DisplayMember = "Name";
            cb.ValueMember = "Id";
            return cb;
        }

        public List<BaseTableDTO> GetOption()
        {
            return Set().Select(x => new BaseTableDTO
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
        public List<BaseTableDTO> SummaryList()
        {
            return Set().Select(x => new BaseTableDTO
            {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }
    }
}
