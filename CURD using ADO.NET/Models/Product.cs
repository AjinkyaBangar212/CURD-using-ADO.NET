using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CURD_using_ADO.NET.Models
{
    //poco classes

    [Table("Product")]
    public class Product
    {

        //Write this on Head of Id So it apply on Id

        [Key]
        [ScaffoldColumn(false)]

        public int Id { get; set; }



        //Write this on Head of Product So it apply on Product


        [Required(ErrorMessage = "Product Name Feild Reqiured")]
        [DataType(DataType.Text)]
        [Display(Name = "Product Name")]
        public string Name { get; set; }



        //Write this on Head of Price So it apply on Price

        [Required(ErrorMessage = "Price Is Required")]
        [Display(Name = "Product Price")]
        [Range(minimum:1,maximum:50000)]
        public double Price { get; set; }
    }
}
