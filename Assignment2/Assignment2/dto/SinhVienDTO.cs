using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.dto
{
    public class SinhVienDTO
    {
        public int MASV { get; set; }
        public string TEN { get; set; }
        public int NAM { get; set; }
        public string MAKH { get; set; }
        public SinhVienDTO(int mASV, string tEN, int nAM, string mAKH)
        {
            MASV = mASV;
            TEN = tEN;
            NAM = nAM;
            MAKH = mAKH;
        }
    }
}
