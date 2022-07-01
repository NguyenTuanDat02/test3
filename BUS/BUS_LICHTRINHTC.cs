using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class BUS_LICHTRINHTC
    {
        DAO_LICHTRINHTC dAO_LICHTRINHTC = new DAO_LICHTRINHTC();
        public DataView LoadDSLichTrinhTC()
        {
            return dAO_LICHTRINHTC.LoadDSLichTrinhTC();
        }

        public bool ThemLichTrinhTC(DTO_LICHTRINHTC lt)
        {
            return dAO_LICHTRINHTC.ThemLichTrinhTC(lt);
        }

        public bool XoaLichTrinhTC(int id)
        {
            return dAO_LICHTRINHTC.XoaLichTrinhTC(id);
        }

        public bool SuaLichTrinhTC(DTO_LICHTRINHTC lt)
        {
            return dAO_LICHTRINHTC.SuaLichTrinhTC(lt);
        }
    }
}
