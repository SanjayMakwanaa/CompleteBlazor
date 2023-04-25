using System.ComponentModel.DataAnnotations;

namespace MudblazorDemo.CRUD.Data
{
    public class States
    {
        [Key]
        public int StateId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int CountryId { get; set; }
    }
}
