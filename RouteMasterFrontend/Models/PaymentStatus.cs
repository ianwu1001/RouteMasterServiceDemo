﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.Models;

public partial class PaymentStatus
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}