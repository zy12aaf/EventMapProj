using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EventTimestamps
    {
        #region Referencing properties

        public int Id { get; set; }
        public Event Event { get; set; }

        #endregion

        #region

        public DateTime CreatedDateTime { get; set; }
        public DateTime LastUpdatedDateTime { get; set; }
        
        #endregion
    }
}
