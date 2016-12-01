namespace Domain.Models
{
    public class Arranger
    {
        #region Referencing properties
        public int Id { get; set; }
        #endregion

        #region Raw Properties
        public string ContactName { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        #endregion
    }
}
