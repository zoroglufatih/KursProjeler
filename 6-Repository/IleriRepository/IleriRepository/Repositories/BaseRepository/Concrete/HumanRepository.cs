using IleriRepository.Concrete;
using IleriRepository.Repositories.BaseRepository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IleriRepository.Repositories.BaseRepository.Concrete
{
    public class HumanRepository : BaseRepository<BaseHuman>, IHumanRepository
    {
        BaseHuman bh = new BaseHuman();
        public List<string> GetAddress()
        {
            return bh.GetAddress();
        }

        public int GetAge()
        {
            return bh.GetAge();
        }

        public string GetTitle()
        {
            return bh.GetTitle();
        }
    }
}
