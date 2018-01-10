using DataLayer.DAOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbOne
{
    public class Program
    {
        static void Main(string[] args)
        {
            RegionDAO daos = new RegionDAO();
            daos.Create();
        }
    }
}
