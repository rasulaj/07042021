using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace assa.Data.Entities
{
    public class Category:BaseEntity
    {
        [StringLength(maximumLength:50)]
        public string Name { get; set; }
        [Range(minimum:1,maximum:int.MaxValue)]

        public int Order { get; set; }
        public int Id { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime ModifiedAt { get; set; }

        public bool IsDeleted { get; set; }
    }
}
