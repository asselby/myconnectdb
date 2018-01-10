using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public interface Interface <T> where T :class
    {
         void Create();
         string Read(T t);
         void Update(T t);
         void Delete(T t);
    }
}
