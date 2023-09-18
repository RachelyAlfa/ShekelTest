using ENV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Products1
{
    public interface IProductsFillter
    {
        void Run(NumberParameter ppi_ProdID = null);
    }
}
