//------------------------------------------------------------------------------
// <auto-generated>
//    This code is auto-generated by a T4 template. This class can be only customized modifying the corresponding partial class.
//    All other changes to this file will cause incorrect behavior and will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using AutoEcMvc.Enums;

namespace AutoEcMvc.Models
{
    public partial class OfficeAssignment
    {
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }
        [Key]
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
    }
}
