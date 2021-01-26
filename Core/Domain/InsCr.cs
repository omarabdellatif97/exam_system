using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess
{
    public partial class InsCr
    {
        public int InsId { get; set; }
        public int CrsId { get; set; }

        public virtual Course Crs { get; set; }
        public virtual Instructor Ins { get; set; }
    }
}
