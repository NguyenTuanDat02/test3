using System;
using System.Collections.Generic;
using System.Text;
using System.Security.Cryptography;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ThuVien
    {
        String strconn = "Data Source=.\\SQLEXPRESS;Database=QuanLyChiTieu;Integrated Security=true";
        public DataSet reDataSet(String sql)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlDataAdapter aDapter = new SqlDataAdapter(sql, conn);
            DataSet dset = new DataSet();
            aDapter.Fill(dset);
            return dset;
        }
        public bool exeSQL(String sql)
        {
            SqlConnection conn = new SqlConnection(strconn);
            SqlCommand comm = new SqlCommand(sql, conn);
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                comm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
                conn.Dispose();
            }
        }
    }
}
