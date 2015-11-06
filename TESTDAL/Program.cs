using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace TESTDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            NhanVienDAL nvdal = new NhanVienDAL();
            DataTable table = nvdal.getListNhanVien();
        }
    }
}
