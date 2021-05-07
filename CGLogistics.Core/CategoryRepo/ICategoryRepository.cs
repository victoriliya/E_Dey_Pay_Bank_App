using CGLogistics.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CGLogistics.Core
{
    public interface ICategoryRepository : ICRUDRepository
    {
        public List<Category> Categories { get; set; }
        public Category GetCategory(int id);
    }

}
