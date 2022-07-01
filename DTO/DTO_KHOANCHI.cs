using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHOANCHI
    {
        public int MaChi { get; set; }
        public string TenChi { get; set; }
        public int DanhMuc { get; set; }
        public float SoTien { get; set; }
        public string NgayChi { get; set; }

        public DTO_KHOANCHI() { }
    }
}
