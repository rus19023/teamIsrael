using System;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Participant
    {
        [Required]
        public int MeetingID { get; set; }

        [Required]
        [Display(Name = "Participant")]
        public int MemberID { get; set; }

        public bool IsPraying { get; set; }

        public int Order { get; set; }

        public string? Topic { get; set; }

        public Meeting Meeting { get; set; }

        public Member Member { get; set; }

    }
}
