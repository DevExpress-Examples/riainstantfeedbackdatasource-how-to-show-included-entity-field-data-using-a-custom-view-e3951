Imports Microsoft.VisualBasic
	Imports System
	Imports System.Collections.Generic
	Imports System.ComponentModel
	Imports System.ComponentModel.DataAnnotations
	Imports System.Data
	Imports System.Linq
	Imports System.ServiceModel.DomainServices.EntityFramework
	Imports System.ServiceModel.DomainServices.Hosting
	Imports System.ServiceModel.DomainServices.Server
Namespace SLGrid.Web


	' Implements application logic using the NORTHWNDEntities context.
	' TODO: Add your application logic to these methods or in additional methods.
	' TODO: Wire up authentication (Windows/ASP.NET Forms) and uncomment the following to disable anonymous access
	' Also consider adding roles to restrict access as appropriate.
	' [RequiresAuthentication]
	<EnableClientAccess()> _
	Public Class NorthwindService
		Inherits LinqToEntitiesDomainService(Of NORTHWNDEntities)

		' TODO:
		' Consider constraining the results of your query method.  If you need additional input you can
		' add parameters to this method or create additional query methods with different names.
		' To support paging you will need to add ordering to the 'CustomerOrders' query.
		Public Function GetCustomerOrders() As IQueryable(Of CustomerOrders)
			Return Me.ObjectContext.CustomerOrders
		End Function
	End Class
End Namespace


