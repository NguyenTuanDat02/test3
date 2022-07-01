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
    public class BUS_TAIKHOAN
    {
        DAO_TAIKHOAN dAO_TAIKHOAN = new DAO_TAIKHOAN();

        public DataView LoadDSTaiKhoan()
        {
            return dAO_TAIKHOAN.LoadDSTaiKhoan();
        }

        public bool ThemTaiKhoan(DTO_TAIKHOAN tk)
        {
            return dAO_TAIKHOAN.ThemTaiKhoan(tk);
        }

        public bool XoaTaiKhoan(int id)
        {
            return dAO_TAIKHOAN.XoaTaiKhoan(id);
        }

        public bool SuaTaiKhoan(DTO_TAIKHOAN tk)
        {
            return dAO_TAIKHOAN.SuaTaiKhoan(tk);
        }

        public bool TimTaiKhoan(string username, string password)
        {
            return dAO_TAIKHOAN.TimTaiKhoan(username, password);
        }
    }
}
