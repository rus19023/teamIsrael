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

        [Display(Name = "Conducting")]
        public int MemberID { get; set; }

        [Required]
        [Display(Name = "Opening Hymn")]
        public string OpeningHymn { get; set; }

        [Required]
        [Display(Name = "Sacrament Hymn")]
        public string SacramentHymn { get; set; }

        [Required]
        [Display(Name = "Closing Hymn")]
        public string ClosingHymn { get; set; }

        [Display(Name = "Intermediate Number")]
        public string? IntermediateNumber { get; set; }

        public ICollection<Participant> Participants { get; set; }

        [Display(Name = "Conducting Leader")]
        public Member Member { get; set; }

    }
}
