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
    public class BUS_KHOANTHU
    {
        DAO_KHOANTHU dAO_KHOANTHU = new DAO_KHOANTHU();

        public DataView LoadDSKhoanThu()
        {
            return dAO_KHOANTHU.LoadDSKhoanThu();
        }

        public bool ThemKhoanThu(DTO_KHOANTHU kt)
        {
            return dAO_KHOANTHU.ThemKhoanThu(kt);
        }

        public bool XoaKhoanThu(int id)
        {
            return dAO_KHOANTHU.XoaKhoanThu(id);
        }

        public bool SuaKhoanThu(DTO_KHOANTHU kt)
        {
            return dAO_KHOANTHU.SuaKhoanThu(kt);
        }
    }
}
