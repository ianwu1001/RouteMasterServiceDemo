﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.Models;

public partial class CommentsAccommodationImage
{
    public int Id { get; set; }

    public int CommentsAccommodationId { get; set; }

    public string Image { get; set; }

    public virtual CommentsAccommodation CommentsAccommodation { get; set; }
}