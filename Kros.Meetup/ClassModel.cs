using System;
using System.Collections.Generic;
using System.Text;

namespace Kros.Meetup
{
    internal class ClassModel
    {
        public string Namespace { get; set; }

        public string Name { get; set; }

        public string Modifier { get; set; }

        public string[] Properties { get; set; }
    }
}
