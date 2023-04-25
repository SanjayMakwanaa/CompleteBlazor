using System.ComponentModel.DataAnnotations;

namespace MudblazorDemo.CRUD.Data
{
     public class Cities
    {
        [Key]
        public int CitiesId { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int StateId { get; set; }
    }
}
