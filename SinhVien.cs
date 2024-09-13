using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanBaoTrung_Buoi3
{
    internal class SinhVien
    {
        public int mssv;
        public int hoten;
        public int ns;
        public int sdt;
        public int gt;

        public void setMssv(int msv)
        {
            this.mssv = msv;
        }
        public int getMssv()
        {
            return this.mssv;
        }
        public void setHoten(int hoten)
        {
            this.hoten = hoten;
        }
        public int getHoten()
        {
            return this.hoten;
        }
        public void setNs(int ns)
        {
            this.ns = ns;
        }
        public int getNs()
        {
            return this.ns;
        }
        public void setSdt(int sdt)
        {
            this.sdt = sdt;
        }
        public int getSdt()
        {
            return this.sdt;
        }
        public void setGt(int gt)
        {
            this.gt = gt;
        }
        public int getGt()
        {
            return this.gt;
        }
    }
}
