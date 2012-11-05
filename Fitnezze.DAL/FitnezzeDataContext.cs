using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;

namespace Fitnezze.DAL
{
    public class FitnezzeDataContext : DataContext
    {
        private static string _connectionString = "Data Source=isostore:/db.sdf;";

        public FitnezzeDataContext():base(_connectionString)
        { }

        public FitnezzeDataContext(string connectionString):base(connectionString)
        { }

        public Table<Exerсise> Exercises;
        public Table<Muscle> Muscles;
    }
}
