using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum Distance
    {
        [Display(Name = "5")]
        Five=5,
        [Display(Name = "10")]
        Ten = 10,
        [Display(Name = "15")]
        Fifteen = 15,
        [Display(Name = "20")]
        Twenty = 20,
        [Display(Name = "25")]
        TwentyFive = 25
    }
}
