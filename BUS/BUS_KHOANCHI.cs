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
    public class BUS_KHOANCHI
    {
        DAO_KHOANCHI dAO_KHOANCHI = new DAO_KHOANCHI();

        public DataView LoadDSKhoanChi()
        {
            return dAO_KHOANCHI.LoadDSKhoanChi();
        }

        public bool ThemKhoanChi(DTO_KHOANCHI kc)
        {
            return dAO_KHOANCHI.ThemKhoanChi(kc);
        }

        public bool XoaKhoanChi(int id)
        {
            return dAO_KHOANCHI.XoaKhoanChi(id);
        }

        public bool SuaKhoanChi(DTO_KHOANCHI kc)
        {
            return dAO_KHOANCHI.SuaKhoanChi(kc);
        }
    }
}
