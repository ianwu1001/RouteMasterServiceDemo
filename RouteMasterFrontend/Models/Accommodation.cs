﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace RouteMasterFrontend.Models;

public partial class Accommodation
{
    public int Id { get; set; }

    public int AcommodationCategoryId { get; set; }

    public int PartnerId { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public double? Grade { get; set; }

    public int RegionId { get; set; }

    public int TownId { get; set; }

    public string Address { get; set; }

    public double? PositionX { get; set; }

    public double? PositionY { get; set; }

    public string Website { get; set; }

    public string IndustryEmail { get; set; }

    public string PhoneNumber { get; set; }

    public int? ParkingSpace { get; set; }

    public TimeSpan? CheckIn { get; set; }

    public TimeSpan? CheckOut { get; set; }

    public bool? Status { get; set; }

    public string Image { get; set; }

    public DateTime CreateDate { get; set; }

    public virtual ICollection<AccommodationImage> AccommodationImages { get; set; } = new List<AccommodationImage>();

    public virtual AcommodationCategory AcommodationCategory { get; set; }

    public virtual ICollection<CommentsAccommodation> CommentsAccommodations { get; set; } = new List<CommentsAccommodation>();

    public virtual ICollection<OrderAccommodationDetail> OrderAccommodationDetails { get; set; } = new List<OrderAccommodationDetail>();

    public virtual Partner Partner { get; set; }

    public virtual Region Region { get; set; }

    public virtual ICollection<Room> Rooms { get; set; } = new List<Room>();

    public virtual Town Town { get; set; }

    public virtual ICollection<AccommodationServiceInfo> AccommodationServiceInfos { get; set; } = new List<AccommodationServiceInfo>();
}