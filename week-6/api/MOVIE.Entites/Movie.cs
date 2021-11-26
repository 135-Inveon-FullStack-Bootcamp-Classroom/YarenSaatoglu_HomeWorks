using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVIE.Entites
{
    public class Movie
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(250)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Year { get; set; }
        [StringLength(150)]
        public string Poster { get; set; }
        public double Rate { get; set; }
        [StringLength(150)]
        public string Trailer { get; set; }
        [StringLength(50)]
        public string Director { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
    }
}
