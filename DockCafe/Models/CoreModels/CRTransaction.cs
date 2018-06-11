namespace DockCafe.Models.CoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRTransaction
    {
        public int CRTransactionID { get; set; }

        public DateTime CRTransactionDate { get; set; }

        public decimal? CRTransactionAmount { get; set; }
    }
}
