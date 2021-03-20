using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace primerparcial.Models
{
    public class productID
    {
        [Key]
        public int ProductID { get; set; }
        [Required]
        [Display(Name="Description")]
        [StringLength(30,MinimumLength =3)]
        public string Description { get; set; }
        [Required]
        public float Price { get; set; }
        [DisplayFormat(DataFormatString ="{0/yyy/MM/dd}")]
        public DateTime Lastbuy { get; set; }

    }
}