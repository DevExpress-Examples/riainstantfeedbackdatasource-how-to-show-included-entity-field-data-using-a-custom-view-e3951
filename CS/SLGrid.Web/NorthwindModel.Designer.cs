﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Data.EntityClient;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Runtime.Serialization;

[assembly: EdmSchemaAttribute()]

namespace SLGrid.Web
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class NORTHWNDEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new NORTHWNDEntities object using the connection string found in the 'NORTHWNDEntities' section of the application configuration file.
        /// </summary>
        public NORTHWNDEntities() : base("name=NORTHWNDEntities", "NORTHWNDEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NORTHWNDEntities object.
        /// </summary>
        public NORTHWNDEntities(string connectionString) : base(connectionString, "NORTHWNDEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new NORTHWNDEntities object.
        /// </summary>
        public NORTHWNDEntities(EntityConnection connection) : base(connection, "NORTHWNDEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<CustomerOrders> CustomerOrders
        {
            get
            {
                if ((_CustomerOrders == null))
                {
                    _CustomerOrders = base.CreateObjectSet<CustomerOrders>("CustomerOrders");
                }
                return _CustomerOrders;
            }
        }
        private ObjectSet<CustomerOrders> _CustomerOrders;

        #endregion
        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the CustomerOrders EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddToCustomerOrders(CustomerOrders customerOrders)
        {
            base.AddObject("CustomerOrders", customerOrders);
        }

        #endregion
    }
    

    #endregion
    
    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="NORTHWNDModel", Name="CustomerOrders")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class CustomerOrders : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new CustomerOrders object.
        /// </summary>
        /// <param name="orderID">Initial value of the OrderID property.</param>
        /// <param name="companyName">Initial value of the CompanyName property.</param>
        public static CustomerOrders CreateCustomerOrders(global::System.Int32 orderID, global::System.String companyName)
        {
            CustomerOrders customerOrders = new CustomerOrders();
            customerOrders.OrderID = orderID;
            customerOrders.CompanyName = companyName;
            return customerOrders;
        }

        #endregion
        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 OrderID
        {
            get
            {
                return _OrderID;
            }
            set
            {
                if (_OrderID != value)
                {
                    OnOrderIDChanging(value);
                    ReportPropertyChanging("OrderID");
                    _OrderID = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("OrderID");
                    OnOrderIDChanged();
                }
            }
        }
        private global::System.Int32 _OrderID;
        partial void OnOrderIDChanging(global::System.Int32 value);
        partial void OnOrderIDChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String CompanyName
        {
            get
            {
                return _CompanyName;
            }
            set
            {
                if (_CompanyName != value)
                {
                    OnCompanyNameChanging(value);
                    ReportPropertyChanging("CompanyName");
                    _CompanyName = StructuralObject.SetValidValue(value, false);
                    ReportPropertyChanged("CompanyName");
                    OnCompanyNameChanged();
                }
            }
        }
        private global::System.String _CompanyName;
        partial void OnCompanyNameChanging(global::System.String value);
        partial void OnCompanyNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String ContactName
        {
            get
            {
                return _ContactName;
            }
            set
            {
                OnContactNameChanging(value);
                ReportPropertyChanging("ContactName");
                _ContactName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("ContactName");
                OnContactNameChanged();
            }
        }
        private global::System.String _ContactName;
        partial void OnContactNameChanging(global::System.String value);
        partial void OnContactNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.DateTime> OrderDate
        {
            get
            {
                return _OrderDate;
            }
            set
            {
                OnOrderDateChanging(value);
                ReportPropertyChanging("OrderDate");
                _OrderDate = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("OrderDate");
                OnOrderDateChanged();
            }
        }
        private Nullable<global::System.DateTime> _OrderDate;
        partial void OnOrderDateChanging(Nullable<global::System.DateTime> value);
        partial void OnOrderDateChanged();

        #endregion
    
    }

    #endregion
    
}
