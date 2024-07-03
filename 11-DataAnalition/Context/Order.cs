using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnalition.Context
{
    internal class Order
    {
        [Key]
        public int OrdeNumber {  get; set; }    
        public string Customer {  get; set; }   
        public DateTime DateCreated { get; set; }   

    }
}
