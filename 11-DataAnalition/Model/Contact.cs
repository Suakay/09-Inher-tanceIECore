using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_DataAnalition.Model
{
    internal class Contact:Book
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [NotMapped]
        public string FullName { get; set; }
        public string Email { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime LastAccessed { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Creted { get; set; }
        public AuditLog AuditLog { get; set; }


    }
}
