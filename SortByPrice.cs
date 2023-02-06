using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class SortByPrice<T> : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Price<T> && y is Price<T>)
            {
                var price1 = x as Price<T>;
                var price2 = y as Price<T>;

                if (price1?.PriceRub > price2?.PriceRub)
                    return 1;
                if (price1?.PriceRub < price2?.PriceRub)
                    return -1;
                return 0;
            }
            else
            {
                throw new Exception("Блин как так");
            }

        }
    }
}
