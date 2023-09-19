using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryAPI.Models
{
    public class Item
    {
        [Key]
        [DisplayName("id")]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        [MaxLength(25, ErrorMessage="25 Characters Max")]
        public string Name { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(25)")]
        [MaxLength(25, ErrorMessage = "25 Characters Max")]
        public string? Upc { get; set; }

        [Column(TypeName = "nvarchar(200)")]
        [MaxLength(25, ErrorMessage = "200 Characters Max")]
        public string? Description { get; set; }

        public int CurrentAmount { get; set; }

        [Column(TypeName = "nvarchar(25)")]
        [MaxLength(25, ErrorMessage = "25 Characters Max")]
        public string? Category { get; set; }

        public int? MaxAmount { get; set; }

        public DateTime? DateCreated { get; set; }

        public DateTime? DateModified { get; set; }

        public DateTime? RestockDate { get; set; }

        public int? ModifiedBy { get; set; }

    }
}
