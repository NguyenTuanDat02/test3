using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class DAO_DANHMUC : ThuVien
    {
        public DataView LoadDSDanhMuc()
        {
            string sql = "select * from DANHMUC";
            return reDataSet(sql).Tables[0].DefaultView;
        }

        public bool ThemDanhMuc(DTO_DANHMUC dm)
        {
            string sql = "Insert into DANHMUC Values(N'" + dm.TenDM + "')";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool XoaDanhMuc(int id)
        {
            string sql = "Delete From DANHMUC Where MaDM=N'" + id + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }

        public bool SuaDanhMuc(DTO_DANHMUC dm)
        {
            string sql = "Update DANHMUC Set TenDM=N'" + dm.TenDM + "' Where MaDM =N'" + dm.MaDM + "'";
            if (exeSQL(sql) == true)
                return true;
            else
                return false;
        }
    }
}
