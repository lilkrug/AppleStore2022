using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoiProject2kurs.DataModel
{
    public class GoodComparer
    {
        public int Compare(Good? p1, Good? p2)
        {
            if (p1 is null || p2 is null)
                throw new ArgumentException("Некорректное значение параметра");
            return p1.Price - p2.Price;
        }
    }
}
