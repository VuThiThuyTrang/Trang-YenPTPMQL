
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PTPMQL.Models
{
    [Table("NhaCungCaps")]
    public class NhaCungCap
    {
        [Key]
        public string MaNCC { get; set; }
        public string TenNCC { get; set; }
        public string Address { get; set; }
    }
}