using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyNLayerProject.API.DTOs
{
    public class ProductDto
    {
        public int Id { set; get; }
        [Required(ErrorMessage ="{0} needed area")]
        public string Name { get; set; }
        [Range(1,int.MaxValue,ErrorMessage ="{0} area need to be better than 1.")]
        public int Stock { get; set; }
        [Range(1, double.MaxValue,ErrorMessage = "{0} area need to be better than 1.")]
        public decimal Price { get; set; }

        public int CategoryId { get; set; }
    }
}
