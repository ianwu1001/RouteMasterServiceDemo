﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterService.Models;

public partial class TravelPlan
{
    public int Id { get; set; }

    public int MemberId { get; set; }

    public int TravelDays { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual Member Member { get; set; }

    public virtual ICollection<Transportation> Transportations { get; set; } = new List<Transportation>();

    public virtual ICollection<ActivityProduct> ActivityProducts { get; set; } = new List<ActivityProduct>();

    public virtual ICollection<Attraction> Attractions { get; set; } = new List<Attraction>();

    public virtual ICollection<ExtraServiceProduct> ExtraServiceProducts { get; set; } = new List<ExtraServiceProduct>();
}