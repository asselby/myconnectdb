using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.DTOs
{
   public class RegionDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RegionDTO(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public RegionDTO()
        {

        }
    }
}
