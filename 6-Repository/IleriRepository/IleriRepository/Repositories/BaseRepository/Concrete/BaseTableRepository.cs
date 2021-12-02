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
    public class BaseTableRepository : BaseRepository<BaseTable>, IBaseTableRepository
    {
        public ComboBox GetCombo(ComboBox cb)
        {
            throw new NotImplementedException();
        }

        public List<BaseTableDTO> GetOption()
        {
            throw new NotImplementedException();
        }
    }
}
