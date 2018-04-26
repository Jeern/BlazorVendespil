using System;

namespace SampleModel
{
    public class User
    {
        public string Name { get; set; } = "Tom";
        public bool IsAdmin { get; set; } = true;
        public int Age { get; set; } = 33;
        public DateTime Birthday { get; set; } = DateTime.Today;
        public decimal Salary { get; set; }
        public bool Turned { get; set; }
        public string FrontClass => !Turned ? "front card cardfront" : "frontturned card cardback";
        public string BackClass => !Turned ? "back card cardback" : "backturned card cardfront";
    }
}
