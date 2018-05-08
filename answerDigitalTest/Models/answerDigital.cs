using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace answerDigitalTest.Models
{
    public class answerDigital
    {
        public int personId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool IsAuthorised { get; set; }
        public int ColourId { get; set; }
        public string ColourName { get; set; }
    }
}