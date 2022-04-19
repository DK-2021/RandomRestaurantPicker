using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyDataModels
{
    public class Restaurant
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [Range(1, 4)]
        public int Price { get; set; }
        [Required]
        public int CuisineId { get; set; }
        [Required]
        public int ConvenienceId { get; set; }

        public virtual Cuisine? Cuisine { get; set; }
        public virtual Convenience? Convenience { get; set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }

    public enum Price
    {
        low = 1,
        medium = 2,
        high = 3,
        unknown = 4
    }
}
