﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using EF Core template.
// Code is generated on: 1/4/2021 10:36:18 PM
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Linq.Expressions;

namespace com.pizzaworld.Orders
{
    public partial class Order {

        public Order()
        {
            this.itemsType = new itemsType();
            this.Pizzas = new List<Pizza>();
            this.Stores1 = new List<Stores>();
            OnCreated();
        }

        public virtual string Name { get; set; }

        public virtual System.Net.NetworkInformation.PhysicalAddress Address { get; set; }

        public virtual string payment { get; set; }

        public virtual System.Net.NetworkInformation.PhysicalAddress Stores { get; set; }

        public virtual itemsType itemsType { get; set; }

        public virtual DateTime ordertime { get; set; }

        public virtual IList<Pizza> Pizzas { get; set; }

        public virtual IList<Stores> Stores1 { get; set; }

        #region Extensibility Method Definitions

        partial void OnCreated();

        public override bool Equals(object obj)
        {
          Order toCompare = obj as Order;
          if (toCompare == null)
          {
            return false;
          }

          if (!Object.Equals(this.Name, toCompare.Name))
            return false;
          if (!Object.Equals(this.ordertime, toCompare.ordertime))
            return false;

          return true;
        }

        public override int GetHashCode()
        {
          int hashCode = 13;
          hashCode = (hashCode * 7) + Name.GetHashCode();
          hashCode = (hashCode * 7) + ordertime.GetHashCode();
          return hashCode;
        }

        #endregion
    }

}
