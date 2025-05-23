﻿namespace PROG7311_POE_ST10150702.Models
{
    public class Farmer
    {
        public int FarmerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Region { get; set; }
        public bool AcceptedPOPPIA { get; set; }

        // This will link to the Identity User
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}