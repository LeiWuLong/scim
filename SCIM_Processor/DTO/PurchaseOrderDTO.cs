﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SCIM_Processor.Models;


namespace SCIM_Processor.DTO
{
    public class PurchaseOrderDTO
    {
        [Key]
        public int PurchaseOrderId { get; set; }

        public string PurchaseOrderCode { get; set; }

        public decimal TotalSellingPrice { get; set; }

        public DateTime PODate { get; set; }

        public string CustomerName { get; set; }

        public bool IsDeleted { get; set; }

       
    }
}
