﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using StoreApi.Data;

namespace StoreApi.Model
{
    public class StockModel
    {
       
        public int StockId { get; set; }



      

        public int Product_id { get; set; }
      

        public int CreateUserId { get; set; }

        public int UpdateUserId { get; set; }

        public int Quantity { get; set; }


        public Boolean Status { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

    }
}
