using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace Fitnezze.DAL
{
    [Table]
    public class ExerciseToMuscle
    {
        [Association]
        public int ExerciseId { get; set; }

        [Association]
        public int MuscleId { get; set; }
    }
}
