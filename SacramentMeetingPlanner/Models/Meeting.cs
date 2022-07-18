using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SacramentMeetingPlanner.Models
{
    public class Meeting
    {

        public int ID { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Meeting Date")]
        public DateTime MeetingDate { get; set; }

        [Required]
        public int MemberID { get; set; }

        [Required]
        public string OpeningHymn { get; set; }

        [Required]
        public string SacramentHymn { get; set; }

        [Required]
        public string ClosingHymn { get; set; }

        public string? IntermediateNumber { get; set; }

        public ICollection<Participant> Participants { get; set; }

        public Member Member { get; set; }

    }
}
