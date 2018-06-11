namespace DockCafe.Models.CoreModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Receipt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Receipt()
        {
            ReceiptDetails = new HashSet<ReceiptDetail>();
        }

        public int ReceiptID { get; set; }

        public int ReceiptCustomerID { get; set; }

        public DateTime ReceiptDate { get; set; }

        public int ReceiptPaymentTypeID { get; set; }

        public decimal ReceiptAmount { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual PaymentType PaymentType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}
