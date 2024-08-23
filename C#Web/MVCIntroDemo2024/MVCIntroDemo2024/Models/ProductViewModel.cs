namespace MVCIntroDemo2024.Models
{
    /// <summary>
    /// Product Model
    /// </summary>
    public class ProductViewModel
    {
        /// <summary>
        /// Product identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product price with VAT
        /// </summary>
        public int Price { get; set; }

    }
}
