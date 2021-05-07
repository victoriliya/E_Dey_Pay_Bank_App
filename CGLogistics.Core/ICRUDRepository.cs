using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    public interface ICRUDRepository
    {
        public bool Add<T>(T model);
        public bool Update<T>(T model);
        public bool Delete(int id);
    }
}
