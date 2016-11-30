using System;

namespace Domain
{
    public class PagingInformation
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }

        public int GetTotalPages()
        {
            return (int) Math.Ceiling((decimal) TotalItems/ItemsPerPage);
        }
    }
}