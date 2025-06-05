using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRGorman.Demo.SpeedrunData.Models
{
    public class Act
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        [ForeignKey("Game")]
        public int GameId { get; set; }

        public virtual Game Game { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public virtual List<Mission> Missions { get; set; }

        public int Order { get; set; }
    }
}
