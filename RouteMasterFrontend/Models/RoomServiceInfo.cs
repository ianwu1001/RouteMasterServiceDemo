﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.Models;

public partial class RoomServiceInfo
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? ServiceInfoCategoryId { get; set; }

    public virtual ServiceInfoCategory ServiceInfoCategory { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();
}