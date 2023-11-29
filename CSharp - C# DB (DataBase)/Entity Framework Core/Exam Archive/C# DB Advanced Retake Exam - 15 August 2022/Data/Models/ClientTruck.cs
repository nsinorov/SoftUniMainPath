﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trucks.Data.Models;

public class ClientTruck
{
    //Client
    [Required]
    public int ClientId { get; set; }

    [ForeignKey(nameof(ClientId))]
    public Client Client { get; set; }

    //Truck
    [Required]
    public int TruckId { get; set; }

    [ForeignKey(nameof(TruckId))]
    public Truck Truck { get; set; }
}