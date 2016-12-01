using System;

namespace Domain.HelperModel
{
    public class PagingInformation
    {
        private const int DefaultItemsPerPage = 10;
        private const int DefaultCurrentPage = 1;

        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        private int _currentPage;
        public bool LoadAll { get; set; }

        public int CurrentPage
        {
            get { return _currentPage; }
            set { _currentPage = value - 1; }
        }


        public PagingInformation(int totalItems, bool loadAll = true, int itemsPerPage = 10, int currentPage = 1) {
            LoadAll = loadAll;
            TotalItems = totalItems;
            ItemsPerPage = itemsPerPage;
            CurrentPage = currentPage;
        }

        public PagingInformation() : this(0) {

        }

        public int GetTotalPages() {
            return (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
        }
    }
}