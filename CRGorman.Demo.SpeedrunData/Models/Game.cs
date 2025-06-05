using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace CRGorman.Demo.SpeedrunData.Models
{
    public class Game
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Description { get; set; } = string.Empty;

        [Required]
        public string Guide { get; set; } = string.Empty;

        /// <summary>
        /// The performance script to talk with.
        /// </summary>
        public string Script { get; set; } = string.Empty;

        [AllowNull]
        public virtual List<Act> Acts { get; set; }

        public int Order { get; set; }
    }
}
