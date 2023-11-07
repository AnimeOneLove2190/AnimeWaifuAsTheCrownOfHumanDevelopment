using System;
using System.Collections.Generic;
using System.Text;

namespace Test01
{
    public class UniversalClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }
        public List<int> GenreIds { get; set; }
    }
}
