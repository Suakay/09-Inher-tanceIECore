using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnalition.Model
{
    internal class Book
    {
        public int BOOKID { get; set; }
        [Required]
        [MaxLength(150)]
        [Column("Description", Order = 2, TypeName =["NVARCHAR(100)"])



    }
}
