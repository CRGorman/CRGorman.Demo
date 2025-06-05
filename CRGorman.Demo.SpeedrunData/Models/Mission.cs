using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRGorman.Demo.SpeedrunData.Models
{
    public class Mission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [ForeignKey("Act")]
        public int ActId { get; set; }

        public virtual Act Act { get; set; }

        public string FileName { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;
        
        public string Description { get; set; } = string.Empty;

        public string Loadout { get; set; } = string.Empty;

        public string Guide { get; set; } = string.Empty;

        /// <summary>
        /// The performance script to talk with.
        /// </summary>
        public string Script { get; set; } = string.Empty;

        public int Order { get; set; }
    }
}
