using MasterDetailCRUDBearerTokenWEbAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MasterDetailCRUDBearerTokenWEbAPI.DTOs
{
    public class OrderRequest
    {
        public Order Order { get; set; }
        public byte[] ImageFile { get; set; }
        public string ImageFileName { get; set; }
    }
}