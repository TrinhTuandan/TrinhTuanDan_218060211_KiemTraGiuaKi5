
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class StudentServices
    {
        public List<SinhVien> GetAll()
        {
            SinhVienContextDB context = new SinhVienContextDB();
            return context.SinhViens.ToList();
        }

        public List<SinhVien> GetAllHasNoMajor()
        {
            SinhVienContextDB context = new SinhVienContextDB();
            return context.SinhViens.Where(p=>p.MaLop == null).ToList();
        }

        public List<SinhVien> GetAllHasNoMajor(int facultyID)
        {
            SinhVienContextDB context = new SinhVienContextDB();
            return context.SinhViens.Where(p => p.NgaySinh == null).ToList();
        }
    }
}
