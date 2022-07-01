using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_KHOANTHU
    {
        public int MaThu { get; set; }
        public string TenThu { get; set; }
        public int DanhMuc { get; set; }
        public float SoTien { get; set; }
        public string NgayThu { get; set; }

        public DTO_KHOANTHU() { }
    }
}
