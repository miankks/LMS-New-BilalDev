﻿using Foolproof;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LexiconLMS.Models
{
    public class Module
    {
        public int ModuleID { get; set; }
        [Display(Name = "Modul")]
        public string Name { get; set; }
        [Display(Name = "Beskrivning")]
        public string Description { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Startdatum")]
        [LessThanOrEqualTo("EndDate", ErrorMessage = "Startdatum kan inte vara efter sludatum")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}")]
        [Display(Name = "Slutdatum")]
        [GreaterThanOrEqualTo("StartDate", ErrorMessage = "Slutdatum kan inte vara före startdatum.")]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }

        // Navigation property
        [Display(Name = "Kurs")]
        public virtual Course Course { get; set; }
        [Display(Name = "Kurs")]
        public int? CourseId { get; set; }

        public virtual ICollection<Activity> Activities { get; set; }

    }

}