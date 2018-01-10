
using DataLayer.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegionDAO regDao = new RegionDAO();
            regDao.Create();

        }
    }
}
