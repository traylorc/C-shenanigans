using System;
using System.Collections.Generic;
using System.Text;

namespace classtutorial
{
    class major
    {
        private static int NextId { get; set; } = 1;

        public int Id { get; private set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public major(string description)
        {
            this.Id = NextId;
            NextId++;
            this.Description = description;
        }
    }
}
