using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSSV
{
    class DS
    {
        string ho;
        string ten;
        string lop;
        string maSV;

        public DS(string ho, string ten, string lop, string maSV)
        {
            this.ho = ho;
            this.ten = ten;
            this.lop = lop;
            this.maSV = maSV;
        }

        public void SetHo(string ho)
        {
            this.ho = ho;
        }
        public string GetHo()
        {
            return this.ho;
        }

        public void SetTen(string ten)
        {
            this.ten = ten;
        }

        public string GetTen()
        {
            return this.ten;
        }

        public void SetLop(string lop)
        {
            this.lop = lop;
        }

        public string GetLop()
        {
            return this.lop;
        }
        public void SetMa(string maSV)
        {
            this.maSV = maSV;
        }

        public string GetMa()
        {
            return this.maSV;
        }
    }
}