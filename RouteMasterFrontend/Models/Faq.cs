﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.Models;

public partial class Faq
{
    public int Id { get; set; }

    public int FaqcategoryId { get; set; }

    public string Question { get; set; }

    public string Answer { get; set; }

    public int Helpful { get; set; }

    public DateTime CreateDate { get; set; }

    public string Image { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual Faqcategory Faqcategory { get; set; }
}