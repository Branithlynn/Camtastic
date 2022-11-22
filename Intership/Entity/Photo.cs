using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intership.Entity
{
    [Table("Photos")]
    public class Photo
    {
        [Key]
        public int Id { get; set; }
        public string PhotoURL { get; set; }
        public int Rating { get; set; }
        public int? CameraId { get; set; }
        [ForeignKey("CameraId")]
        public virtual Camera camera { get; set; }
    }
}
