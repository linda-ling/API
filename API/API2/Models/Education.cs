﻿using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API2.Models
{
    [Table("TB_M_Education")]
    public class Education
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public string GPA { get; set; }


        [ForeignKey("University")]
        public int University_Id { get; set; }


        [JsonIgnore]
        public virtual ICollection<Profiling> Profiling { get; set; }

        [JsonIgnore]
        public virtual University University { get; set; }

    }
}
