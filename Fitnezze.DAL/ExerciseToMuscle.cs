using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;

namespace Fitnezze.DAL
{
    [Table]
    public class ExerciseToMuscle
    {
        private EntitySet<Exerсise> _exerciseId;

        [Association(Storage="_exerciseId", OtherKey="Id", ThisKey="ExerciseId")]
        public EntitySet<Exerсise> ExerciseId 
        {
            get { return _exerciseId; }
            set { _exerciseId.Assign(value); } 
        }

        private EntitySet<Muscle> _muscleId;

        [Association(Storage="_muscleId", OtherKey="Id", ThisKey="MuscleId")]
        public EntitySet<Muscle> MuscleId
        {
            get { return _muscleId; }
            set { _muscleId.Assign(value); } 
        }

    }
}
