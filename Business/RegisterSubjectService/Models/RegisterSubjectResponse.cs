﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.RegisterSubjectService.Models
{
    public class RegisterSubjectResponse
    {
        //public int AvailableSubjectId { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Status { get; set; }
        public string SubjectName { get; set; }
      

    }
    public class RegisterSlotResponse
    {
        public int RegisterSlotId { get; set; }
        public string? Slot { get; set; }
        public bool Status { get; set; }
    }
    public class RegisterSubjectSlotResponse
    {
        public List<RegisterSubjectResponse> registerSubjects { get; set; }
        public List<string> registerSlots { get; set; }   

    }
}
