using MY.MS.Entities.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MY.MS.Entities.Concrete
{
    [Table("Categories")]
    public class Categories : ITable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        [Column("CatName")]
        [Required]
        [StringLength(40)]
        public string CategoryName { get; set; }
       
        public List<Items> Items { get; set; }
    }
}
