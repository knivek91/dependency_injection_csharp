using System;
using Interfaces;

namespace Models
{
    public class CurrentDateTime : ICurrentDateTime
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }
    }
}
