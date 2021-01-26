using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class StCr
    {
        public int StId { get; set; }
        public int CrsId { get; set; }
        public int? Grade { get; set; }

        public virtual Student St { get; set; }
    }
}
