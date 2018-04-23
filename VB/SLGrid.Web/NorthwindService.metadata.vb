Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace SLGrid.Web


	' The MetadataTypeAttribute identifies CustomerOrdersMetadata as the class
	' that carries additional metadata for the CustomerOrders class.
	<MetadataTypeAttribute(GetType(CustomerOrders.CustomerOrdersMetadata))> _
	Partial Public Class CustomerOrders

		' This class allows you to attach custom attributes to properties
		' of the CustomerOrders class.
		'
		' For example, the following marks the Xyz property as a
		' required property and specifies the format for valid values:
		'    [Required]
		'    [RegularExpression("[A-Z][A-Za-z0-9]*")]
		'    [StringLength(32)]
		'    public string Xyz { get; set; }
		Friend NotInheritable Class CustomerOrdersMetadata

			' Metadata classes are not meant to be instantiated.
			Private Sub New()
			End Sub

			Private privateCompanyName As String
			Public Property CompanyName() As String
				Get
					Return privateCompanyName
				End Get
				Set(ByVal value As String)
					privateCompanyName = value
				End Set
			End Property

			Private privateContactName As String
			Public Property ContactName() As String
				Get
					Return privateContactName
				End Get
				Set(ByVal value As String)
					privateContactName = value
				End Set
			End Property

			Private privateOrderDate? As DateTime
			Public Property OrderDate() As DateTime?
				Get
					Return privateOrderDate
				End Get
				Set(ByVal value? As DateTime)
					privateOrderDate = value
				End Set
			End Property

			Private privateOrderID As Integer
			Public Property OrderID() As Integer
				Get
					Return privateOrderID
				End Get
				Set(ByVal value As Integer)
					privateOrderID = value
				End Set
			End Property
		End Class
	End Class
End Namespace
