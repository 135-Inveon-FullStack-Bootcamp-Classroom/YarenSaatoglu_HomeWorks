using FootballApi.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FootballApi.Entities
{
    public class Footballer : Person, IEntity
    {
        public ICollection<Position> Positions { get; set; }

        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
