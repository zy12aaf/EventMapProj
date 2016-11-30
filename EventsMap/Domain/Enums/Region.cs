using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public enum Region
    {
        [Display(Name = "East-Midlands")]   
        EastMidlands = 0,
        [Display(Name = "East of England")]
        EastofEngland = 1,
        England = 2,
        London = 3,
        [Display(Name = "North East")]
        NorthEast = 4,
        [Display(Name = "North West")]
        NorthWest = 5,
        [Display(Name = "South East")]
        SouthEast = 6,
        [Display(Name = "South West")]
        SouthWest = 7,
        [Display(Name = "West Midlands")]
        WestMidlands = 8,
        [Display(Name = "Yorkshire and the Humber")]
        YorkshireandtheHumber = 9
    }


}
