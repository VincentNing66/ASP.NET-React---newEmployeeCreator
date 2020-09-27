using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace new_employee_creator.Models
{
    public class ECandidate
    {
        [Key]
        public int Id { get; set; }

        public string fname { get; set; }

        public string lname { get; set; }

        public string address { get; set; }
        public string mAddress { get; set; }
        public string email { get; set; }
        public int phone { get; set; }
        public string cs { get; set; }
        public string esd { get; set; }
        public string et { get; set; }
        public string pt { get; set; }
        public string eName { get; set; }
        public string eRelationship { get; set; }
        public int ePhone { get; set; }
        public string Signature { get; set; }
    }
}
