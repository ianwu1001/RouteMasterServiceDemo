﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.Models;

public partial class ReportReason
{
    public int Id { get; set; }

    public string Reason { get; set; }

    public virtual ICollection<ReportedAttractionComment> ReportedAttractionComments { get; set; } = new List<ReportedAttractionComment>();
}