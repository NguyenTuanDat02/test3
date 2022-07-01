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
    public class BUS_DANHMUC
    {
        DAO_DANHMUC dAO_DANHMUC = new DAO_DANHMUC();

        public DataView LoadDSDanhMuc()
        {
            return dAO_DANHMUC.LoadDSDanhMuc();
        }

        public bool ThemDanhMuc(DTO_DANHMUC dm)
        {
            return dAO_DANHMUC.ThemDanhMuc(dm);
        }

        public bool XoaDanhMuc(int id)
        {
            return dAO_DANHMUC.XoaDanhMuc(id);
        }

        public bool SuaDanhMuc(DTO_DANHMUC dm)
        {
            return dAO_DANHMUC.SuaDanhMuc(dm);
        }
    }
}
