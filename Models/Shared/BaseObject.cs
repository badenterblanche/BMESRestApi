using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BMESRestApi.Models.Shared
{
    public class BaseObject
    {
        public DateTimeOffset CreateDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
