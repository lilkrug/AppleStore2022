using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoiProject2kurs.DataModel
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public List<Order> Orders { get; set; }
        public List<Support> Supports { get; set; }
    }
}
