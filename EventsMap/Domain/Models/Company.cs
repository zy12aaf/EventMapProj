using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Models
{
    public class Company
    {
        #region Referencing properties

        #endregion

        #region Raw properties
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanySize { get; set; }
        public string CompanyTwitterHandle { get; set; }
        public string CompanyWebsite { get; set; }
        public string CompanyFacebookPage { get; set; }
        #endregion

    }
}
