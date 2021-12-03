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
    public class CountyRepository : BaseRepository<County>, ICountyRepository
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
        public List<CountyDTO> GetOption(ComboBox cb2)
        {
            return Set().Select(x => new CountyDTO
            {
                Id = x.Id,
                Name = x.Name,
                CityId = x.CityId
            }).Where(x => x.CityId == (int)cb2.SelectedValue).ToList();
        }
        public ComboBox GetCombo(ComboBox cb1, ComboBox cb2)
        {
            cb1.DisplayMember = "Name";
            cb1.ValueMember = "Id";
            cb1.DataSource = GetOption(cb2);
            return cb1;
        }
        /*Set().Select(x => new
            {
                x.Id,
                x.Name,
                x.CityId
            }).Where(x => x.CityId == (int)cb2.SelectedValue).ToList();*/
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
