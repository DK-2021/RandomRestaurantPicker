using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDataModels
{
    public class Convenience
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        public virtual List<Restaurant> Restaurants { get; set; } = new List<Restaurant>();

        public override string ToString()
        {
            return Type;
        }



        
    }

    //public enum ConvenienceType
    //{
    //    [Display(Name = "Sit Down")]
    //    SitDown = 1,
    //    [Display(Name = "Take Out")]
    //    TakeOut = 2,
    //    [Display(Name = "Fast Food")]
    //    FastFood = 3,
    //    [Display(Name = "Unassigned")]
    //    Unassigned = 4
    //}


}
