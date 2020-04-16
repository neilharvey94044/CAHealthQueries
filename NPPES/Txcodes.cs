using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CAHealthQueries.NPPES
{
    [Table("txcodes")]
    public partial class Txcodes
    {
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(80)]
        public string Grouping { get; set; }
        [StringLength(110)]
        public string Classification { get; set; }
        [StringLength(80)]
        public string Specialization { get; set; }
        public string Definition { get; set; }
    }
}
