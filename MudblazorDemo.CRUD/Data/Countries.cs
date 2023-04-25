using System.ComponentModel.DataAnnotations;

namespace MudblazorDemo.CRUD.Data
{
    public class Countries
    {
        [Key]
        public int CountryId { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
    }
}
