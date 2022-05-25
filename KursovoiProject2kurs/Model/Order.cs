using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoiProject2kurs.DataModel
{
    public class Order
    {
        public int Id { get; set; } 
        public Good Good { get; set; }
        public int GoodId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }
        public Good good
        {
            get
            {
                return DataWorker.GetGoodById(GoodId);
            }
        }

    }
}
