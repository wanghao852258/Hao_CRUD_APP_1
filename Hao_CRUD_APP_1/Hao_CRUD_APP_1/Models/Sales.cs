﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hao_CRUD_APP_1.Models
{
    public class Sales
    {
        public string CustomerName { get; set; }
        public string ProductName { get; set; }
        public DateTime? ProductSold { get; set; }
        public int ProductId { get; set; }
    }
}