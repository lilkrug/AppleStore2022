using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoiProject2kurs.DataModel
{
    public class Image
    {
        public int ImageId { get; set; }
        public byte[] Picture { get; set; }
        public string Path { get; set; }
    }
}
