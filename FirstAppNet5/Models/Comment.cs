using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppNet5.Models
{
    public class Comment : Entity<Guid>
    {
        public string Text { get; set; }
        public DateTime CreateAt { get; set; }
        //public Guid UserId { get; set; }
        //public string UserName { get; set; }

        public User User { get; set; } // aggregation
        /*
        public string EllapsedTime
        {
            get
            {
                if(CreatedAt - DateTime.UtcNow < 60) 7+"min"
            }
        }
        */
    }
}
