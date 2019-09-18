﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PicerijaBarka5.Models
{
    public enum IngredientType
    {
        Dough,
        Meat,
        Cheese,
        Sauce,
        Vegetable
    }
    public enum Roles
    {
        Admin,
        User,
        Owner
    }

    public enum OrderStatus
    {
        InProgress,
        Accepted,
        InDelivery,
        Delivered
    }

}