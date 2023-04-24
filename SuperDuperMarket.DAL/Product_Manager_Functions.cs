using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperDuperMarket.DAL
{
    partial class Product_Manager
    {
        public List<Product> SortProducts(ByAttribute attribute)
        {
            switch (attribute)
            {
                case ByAttribute.Name:
                    return GetAll().OrderBy(a => a.Name).ToList();
                case ByAttribute.Priority:
                    return GetAll().OrderByDescending(a => a.Priority).ToList();
            }
            return null;
        }

        public List<Product> SearchByName(string value)
        {
            var result = from a in GetAll() where a.Name.ToUpper().Contains(value.ToUpper()) select a;
            return result.ToList();
        }
    }
}
