﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterService.Models;

public partial class Faqcategory
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Faq> Faqs { get; set; } = new List<Faq>();
}