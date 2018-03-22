using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreUsingAngularAndEF.Data.Domain
{
    public class Blog: BaseEntity
    {
        public string Title { get; set; }
        public string BlogText { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        public Blog()
        {
            Comments = new HashSet<Comment>();
        }
    }
}
