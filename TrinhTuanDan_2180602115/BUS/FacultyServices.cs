
using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class FacultyServices
    {
        public List<Lop> GetAll()
        {
            SinhVienContextDB context = new SinhVienContextDB();
            return context.Lops.ToList();
        }
    }
}
