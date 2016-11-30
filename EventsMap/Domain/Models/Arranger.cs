using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Arranger
    {
        #region Referencing properties
        public int Id { get; set; }
        #endregion

        #region Raw Properties
        public string Contact_Name { get; set; }
        public string Contact_Email { get; set; }
        public string Contact_Phone { get; set; }
        #endregion
    }
}
