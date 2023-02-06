using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Price<T> : ICloneable, IComparable
    {
        private int _priceRub;
        public T Id { get; set; }
        public string Name { get; set; }

        public int PriceRub
        {
            get { return _priceRub; }
            set
            {
                if (value >= 0)
                    _priceRub = value;
            }
        }

        public Price(T id, string name, int priceRub)
        {
            Id = id;
            Name = name;
            PriceRub = priceRub;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Price<T>)
            {
                var price = obj as Price<T>;
                return string.Compare(Id.ToString(), price.Id.ToString());
            }
            else
            {
                throw new Exception("Что-то пошло не так :(");
            }
        }

        public object Clone()
        {
            return new Price<T>(Id, Name, PriceRub);
        }
    }
}
