﻿namespace command.Models
{
    public class Car : Entity
    {
        public string Vendor { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }

        public override string ToString()
        {
            return $"{Vendor}-{Model}-{Year}";
        }
    }
}
