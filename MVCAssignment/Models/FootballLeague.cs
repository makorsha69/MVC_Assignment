using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MVCAssignment.Models
{
    public class FootballLeague
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MatchId { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string TeamName1 { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string TeamName2 { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string Status { get; set; }

        [Column(TypeName = "varchar(50)")]
        [Required(ErrorMessage = "The addressname cannot be empty.")]
        public string WinningTeam { get; set; }

        public int Points { get; set; }
    }
}
