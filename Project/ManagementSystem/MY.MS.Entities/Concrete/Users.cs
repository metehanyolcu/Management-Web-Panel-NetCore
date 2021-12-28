using MY.MS.Entities.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MY.MS.Entities.Concrete
{
    //Set Table Name
    [Table("UsersT")]
    public class Users : ITable
    {
        //Set Primary Key
        [Key]
        //Set identity attributes
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        //Required = Not Null
        [Required]
        //Set Column Name
        [Column("Username")]
        //Set nvarchar and max length
        [StringLength(50)]
        //Set minimum length
        [MinLength(2)]
        public string UserName { get; set; }
        [Required]
        [Column("Password")]
        [StringLength(80)]
        [MinLength(6)]
        public string Password { get; set; }
        [Required]
        [Column("Email")]
        [StringLength(150)]
        public string EMail { get; set; }
        [Required]
        [Column("Name")]
        [StringLength(50)]
        [MinLength(2)]
        public string Name { get; set; }
        [Required]
        [Column("Surname")]
        [StringLength(50)]
        [MinLength(2)]
        public string SurName { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
