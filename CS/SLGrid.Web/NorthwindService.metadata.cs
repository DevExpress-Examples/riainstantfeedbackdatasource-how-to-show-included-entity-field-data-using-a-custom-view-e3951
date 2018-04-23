
namespace SLGrid.Web {
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.ServiceModel.DomainServices.Hosting;
    using System.ServiceModel.DomainServices.Server;


    // The MetadataTypeAttribute identifies CustomerOrdersMetadata as the class
    // that carries additional metadata for the CustomerOrders class.
    [MetadataTypeAttribute(typeof(CustomerOrders.CustomerOrdersMetadata))]
    public partial class CustomerOrders {

        // This class allows you to attach custom attributes to properties
        // of the CustomerOrders class.
        //
        // For example, the following marks the Xyz property as a
        // required property and specifies the format for valid values:
        //    [Required]
        //    [RegularExpression("[A-Z][A-Za-z0-9]*")]
        //    [StringLength(32)]
        //    public string Xyz { get; set; }
        internal sealed class CustomerOrdersMetadata {

            // Metadata classes are not meant to be instantiated.
            private CustomerOrdersMetadata() {
            }

            public string CompanyName { get; set; }

            public string ContactName { get; set; }

            public Nullable<DateTime> OrderDate { get; set; }

            public int OrderID { get; set; }
        }
    }
}
