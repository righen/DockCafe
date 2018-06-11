namespace DockCafe.Models.CoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CRTransactionType
    {
        public int CRTransactionTypeID { get; set; }

        public int CRTransactionID { get; set; }

        public int PaymentID { get; set; }

        public decimal CRTransactionAmount { get; set; }
    }
}
