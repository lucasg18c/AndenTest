using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace AndenTest.Common.Entity
{
    /// <summary>
    /// Base form class
    /// </summary>
    public abstract class Form
    {
        /// <summary>
        /// Unique ID
        /// </summary>
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FormID { get; set; }

        /// <summary>
        /// Name of the form
        /// </summary>
        [MaxLength(50), Required]
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Description of the form
        /// </summary>
        [MaxLength(200), Required]
        public string Description { get; set; } = string.Empty;

        /// <summary>
        /// Date time when created
        /// </summary>
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
