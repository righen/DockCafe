namespace DockCafe.Models.CoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ReceiptDetail
    {
        public int ReceiptDetailID { get; set; }

        public int ReceiptID { get; set; }

        public int OrderID { get; set; }

        public decimal? ReceiptDetailAmount { get; set; }

        public virtual Receipt Receipt { get; set; }
    }
}
