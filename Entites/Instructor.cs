using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Entites
{
    internal class Instructor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(40)]
        public string Name { get; set; }
      
        [DataType(DataType.Currency)]
        public string Email { get; set; }
        [Column(TypeName = "varchar")]
        [Required]
        [MaxLength(30)]
        public string Address { get; set; }

    }
}
