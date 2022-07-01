using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_TAIKHOAN : ThuVien
    {
        public DataView LoadDSTaiKhoan()
        {
            string sql = "select * from TAIKHOAN";
            return reDataSet(sql).Tables[0].DefaultView;
        }

        public bool ThemTaiKhoan(DTO_TAIKHOAN tk)
        {
            string sql = "Insert into TAIKHOAN Values(N'" + tk.Username + "', N'" + tk.Password + "')";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool XoaTaiKhoan(int id)
        {
            string sql = "Delete From TAIKHOAN Where MaTK=N'" + id + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool SuaTaiKhoan(DTO_TAIKHOAN tk)
        {
            string sql = "Update TAIKHOAN Set Username=N'" + tk.Username + "', Password=N'" + tk.Password + "' Where MaTK =N'" + tk.MaTK + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool TimTaiKhoan(string username, string password)
        {
            string sql = "select * from TAIKHOAN Where Username=N'" + username + "' and Password=N'" + password + "'";
            var check = reDataSet(sql).Tables[0].Rows.Count;
            if (check <= 0)
                return false;
            else
                return true;
        }
    }
}
