using MY.MS.Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MY.MS.Entities.Concrete
{
    [Table("Items")]
    public class Items : ITable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemID { get; set; }
        [Required]
        [StringLength(50)]
        [MinLength(2)]
        public string ItemName { get; set; }
        [Required]
        [Column("Stock")]
        public int ItemStock { get; set; }
        [ForeignKey("Categories")]
        [Required]
        
        public int CategoryID { get; set; }
        [Column("Categories")]
        public List<Categories> Categories { get; set; }


    }
}
