using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovoiProject2kurs.DataModel
{
    public class Good
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Price { get; set; }
        public string Country { get; set; }
        public string Description { get; set; }
        public Image? IPhoneImage { get; set; }
        public int ImageId { get; set; }
        [NotMapped]
        public Image NoteImage
        {
            get
            {
                return DataWorker.GetImageById(ImageId);
            }
        }
    }
}
