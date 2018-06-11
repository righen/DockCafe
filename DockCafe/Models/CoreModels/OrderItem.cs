namespace DockCafe.Models.CoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class OrderItem
    {
        public int OrderItemID { get; set; }

        public int OrderItemOrderID { get; set; }

        public int OrderItemItemID { get; set; }

        public int ItemQuantity { get; set; }

        public int ItemPrice { get; set; }

        public virtual Item Item { get; set; }

        public virtual Order Order { get; set; }
    }
}
