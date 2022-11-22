using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intership.Entity
{
    [Table("Cameras")]
    public class Camera
    {
        [Key]
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string Model { get; set; }
    }
}
