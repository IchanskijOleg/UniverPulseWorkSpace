using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ConsoleApp12
{
    public class CarDataContext : DataContext
    {
        public CarDataContext(string connectionString)
            : base(connectionString)
        {
        }
        //public Table<Car> Users { get { return this.GetTable<Car>(); } }

        [Function(Name = "p_GetCarPriceRange")]
        [return: Parameter(DbType = "money")]
        public int GetCarPriceRange([Parameter(Name = "name", DbType = "NVarChar(50)")] string name,
                                    [Parameter(Name = "minPrice", DbType = "money")] ref double minPrice,
                                    [Parameter(Name = "maxPrice", DbType = "money")] ref double maxPrice)                                     
        {
            IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, minPrice, maxPrice);
            minPrice = ((double)(result.GetParameterValue(1)));
            maxPrice = ((double)(result.GetParameterValue(2)));
            return ((int)(result.ReturnValue));
        }
    }
}