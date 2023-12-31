﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.Models;

public partial class ActivityProduct
{
    public int Id { get; set; }

    public int ActivityId { get; set; }

    public DateTime Date { get; set; }

    public TimeSpan StartTime { get; set; }

    public TimeSpan EndTime { get; set; }

    public int Price { get; set; }

    public int Quantity { get; set; }

    public virtual Activity Activity { get; set; }

    public virtual ICollection<CartActivitiesDetail> CartActivitiesDetails { get; set; } = new List<CartActivitiesDetail>();

    public virtual ICollection<OrderActivitiesDetail> OrderActivitiesDetails { get; set; } = new List<OrderActivitiesDetail>();

    public virtual ICollection<TravelPlan> TravelPlans { get; set; } = new List<TravelPlan>();
}