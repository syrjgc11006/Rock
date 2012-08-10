//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the T4\Model.tt template.
//
//     Changes to this file will be lost when the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
//
// THIS WORK IS LICENSED UNDER A CREATIVE COMMONS ATTRIBUTION-NONCOMMERCIAL-
// SHAREALIKE 3.0 UNPORTED LICENSE:
// http://creativecommons.org/licenses/by-nc-sa/3.0/
//
using System.ComponentModel.Composition;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

namespace Rock.REST.Core
{
	/// <summary>
	/// REST WCF service for DefinedTypes
	/// </summary>
    [Export(typeof(IService))]
    [ExportMetadata("RouteName", "Core/DefinedType")]
	[AspNetCompatibilityRequirements( RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed )]
    public partial class DefinedTypeService : IDefinedTypeService, IService
    {
		/// <summary>
		/// Gets a DefinedType object
		/// </summary>
		[WebGet( UriTemplate = "{id}" )]
        public Rock.Core.DTO.DefinedType Get( string id )
        {
            var currentUser = Rock.CMS.UserService.GetCurrentUser();
            if ( currentUser == null )
                throw new WebFaultException<string>("Must be logged in", System.Net.HttpStatusCode.Forbidden );

            using (Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope())
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.Core.DefinedTypeService DefinedTypeService = new Rock.Core.DefinedTypeService();
				Rock.Core.DefinedType DefinedType = DefinedTypeService.Get( int.Parse( id ) );
				if ( DefinedType.IsAuthorized( "View", currentUser.Person ) )
					return DefinedType.DataTransferObject;
				else
					throw new WebFaultException<string>( "Not Authorized to View this DefinedType", System.Net.HttpStatusCode.Forbidden );
            }
        }
		
		/// <summary>
		/// Gets a DefinedType object
		/// </summary>
		[WebGet( UriTemplate = "{id}/{apiKey}" )]
        public Rock.Core.DTO.DefinedType ApiGet( string id, string apiKey )
        {
            using (Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope())
            {
				Rock.CMS.UserService userService = new Rock.CMS.UserService();
                Rock.CMS.User user = userService.Queryable().Where( u => u.ApiKey == apiKey ).FirstOrDefault();

				if (user != null)
				{
					uow.objectContext.Configuration.ProxyCreationEnabled = false;
					Rock.Core.DefinedTypeService DefinedTypeService = new Rock.Core.DefinedTypeService();
					Rock.Core.DefinedType DefinedType = DefinedTypeService.Get( int.Parse( id ) );
					if ( DefinedType.IsAuthorized( "View", user.Person ) )
						return DefinedType.DataTransferObject;
					else
						throw new WebFaultException<string>( "Not Authorized to View this DefinedType", System.Net.HttpStatusCode.Forbidden );
				}
				else
					throw new WebFaultException<string>( "Invalid API Key", System.Net.HttpStatusCode.Forbidden );
            }
        }
		
		/// <summary>
		/// Updates a DefinedType object
		/// </summary>
		[WebInvoke( Method = "PUT", UriTemplate = "{id}" )]
        public void UpdateDefinedType( string id, Rock.Core.DTO.DefinedType DefinedType )
        {
            var currentUser = Rock.CMS.UserService.GetCurrentUser();
            if ( currentUser == null )
                throw new WebFaultException<string>("Must be logged in", System.Net.HttpStatusCode.Forbidden );

            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.Core.DefinedTypeService DefinedTypeService = new Rock.Core.DefinedTypeService();
				Rock.Core.DefinedType existingDefinedType = DefinedTypeService.Get( int.Parse( id ) );
				if ( existingDefinedType.IsAuthorized( "Edit", currentUser.Person ) )
				{
					uow.objectContext.Entry(existingDefinedType).CurrentValues.SetValues(DefinedType);
					
					if (existingDefinedType.IsValid)
						DefinedTypeService.Save( existingDefinedType, currentUser.PersonId );
					else
						throw new WebFaultException<string>( existingDefinedType.ValidationResults.AsDelimited(", "), System.Net.HttpStatusCode.BadRequest );
				}
				else
					throw new WebFaultException<string>( "Not Authorized to Edit this DefinedType", System.Net.HttpStatusCode.Forbidden );
            }
        }

		/// <summary>
		/// Updates a DefinedType object
		/// </summary>
		[WebInvoke( Method = "PUT", UriTemplate = "{id}/{apiKey}" )]
        public void ApiUpdateDefinedType( string id, string apiKey, Rock.Core.DTO.DefinedType DefinedType )
        {
            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				Rock.CMS.UserService userService = new Rock.CMS.UserService();
                Rock.CMS.User user = userService.Queryable().Where( u => u.ApiKey == apiKey ).FirstOrDefault();

				if (user != null)
				{
					uow.objectContext.Configuration.ProxyCreationEnabled = false;
					Rock.Core.DefinedTypeService DefinedTypeService = new Rock.Core.DefinedTypeService();
					Rock.Core.DefinedType existingDefinedType = DefinedTypeService.Get( int.Parse( id ) );
					if ( existingDefinedType.IsAuthorized( "Edit", user.Person ) )
					{
						uow.objectContext.Entry(existingDefinedType).CurrentValues.SetValues(DefinedType);
					
						if (existingDefinedType.IsValid)
							DefinedTypeService.Save( existingDefinedType, user.PersonId );
						else
							throw new WebFaultException<string>( existingDefinedType.ValidationResults.AsDelimited(", "), System.Net.HttpStatusCode.BadRequest );
					}
					else
						throw new WebFaultException<string>( "Not Authorized to Edit this DefinedType", System.Net.HttpStatusCode.Forbidden );
				}
				else
					throw new WebFaultException<string>( "Invalid API Key", System.Net.HttpStatusCode.Forbidden );
            }
        }

		/// <summary>
		/// Creates a new DefinedType object
		/// </summary>
		[WebInvoke( Method = "POST", UriTemplate = "" )]
        public void CreateDefinedType( Rock.Core.DTO.DefinedType DefinedType )
        {
            var currentUser = Rock.CMS.UserService.GetCurrentUser();
            if ( currentUser == null )
                throw new WebFaultException<string>("Must be logged in", System.Net.HttpStatusCode.Forbidden );

            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.Core.DefinedTypeService DefinedTypeService = new Rock.Core.DefinedTypeService();
				Rock.Core.DefinedType existingDefinedType = new Rock.Core.DefinedType();
				DefinedTypeService.Add( existingDefinedType, currentUser.PersonId );
				uow.objectContext.Entry(existingDefinedType).CurrentValues.SetValues(DefinedType);

				if (existingDefinedType.IsValid)
					DefinedTypeService.Save( existingDefinedType, currentUser.PersonId );
				else
					throw new WebFaultException<string>( existingDefinedType.ValidationResults.AsDelimited(", "), System.Net.HttpStatusCode.BadRequest );
            }
        }

		/// <summary>
		/// Creates a new DefinedType object
		/// </summary>
		[WebInvoke( Method = "POST", UriTemplate = "{apiKey}" )]
        public void ApiCreateDefinedType( string apiKey, Rock.Core.DTO.DefinedType DefinedType )
        {
            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				Rock.CMS.UserService userService = new Rock.CMS.UserService();
                Rock.CMS.User user = userService.Queryable().Where( u => u.ApiKey == apiKey ).FirstOrDefault();

				if (user != null)
				{
					uow.objectContext.Configuration.ProxyCreationEnabled = false;
					Rock.Core.DefinedTypeService DefinedTypeService = new Rock.Core.DefinedTypeService();
					Rock.Core.DefinedType existingDefinedType = new Rock.Core.DefinedType();
					DefinedTypeService.Add( existingDefinedType, user.PersonId );
					uow.objectContext.Entry(existingDefinedType).CurrentValues.SetValues(DefinedType);

					if (existingDefinedType.IsValid)
						DefinedTypeService.Save( existingDefinedType, user.PersonId );
					else
						throw new WebFaultException<string>( existingDefinedType.ValidationResults.AsDelimited(", "), System.Net.HttpStatusCode.BadRequest );
				}
				else
					throw new WebFaultException<string>( "Invalid API Key", System.Net.HttpStatusCode.Forbidden );
            }
        }

		/// <summary>
		/// Deletes a DefinedType object
		/// </summary>
		[WebInvoke( Method = "DELETE", UriTemplate = "{id}" )]
        public void DeleteDefinedType( string id )
        {
            var currentUser = Rock.CMS.UserService.GetCurrentUser();
            if ( currentUser == null )
                throw new WebFaultException<string>("Must be logged in", System.Net.HttpStatusCode.Forbidden );

            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.Core.DefinedTypeService DefinedTypeService = new Rock.Core.DefinedTypeService();
				Rock.Core.DefinedType DefinedType = DefinedTypeService.Get( int.Parse( id ) );
				if ( DefinedType.IsAuthorized( "Edit", currentUser.Person ) )
				{
					DefinedTypeService.Delete( DefinedType, currentUser.PersonId );
					DefinedTypeService.Save( DefinedType, currentUser.PersonId );
				}
				else
					throw new WebFaultException<string>( "Not Authorized to Edit this DefinedType", System.Net.HttpStatusCode.Forbidden );
            }
        }

		/// <summary>
		/// Deletes a DefinedType object
		/// </summary>
		[WebInvoke( Method = "DELETE", UriTemplate = "{id}/{apiKey}" )]
        public void ApiDeleteDefinedType( string id, string apiKey )
        {
            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				Rock.CMS.UserService userService = new Rock.CMS.UserService();
                Rock.CMS.User user = userService.Queryable().Where( u => u.ApiKey == apiKey ).FirstOrDefault();

				if (user != null)
				{
					uow.objectContext.Configuration.ProxyCreationEnabled = false;
					Rock.Core.DefinedTypeService DefinedTypeService = new Rock.Core.DefinedTypeService();
					Rock.Core.DefinedType DefinedType = DefinedTypeService.Get( int.Parse( id ) );
					if ( DefinedType.IsAuthorized( "Edit", user.Person ) )
					{
						DefinedTypeService.Delete( DefinedType, user.PersonId );
						DefinedTypeService.Save( DefinedType, user.PersonId );
					}
					else
						throw new WebFaultException<string>( "Not Authorized to Edit this DefinedType", System.Net.HttpStatusCode.Forbidden );
				}
				else
					throw new WebFaultException<string>( "Invalid API Key", System.Net.HttpStatusCode.Forbidden );
            }
        }

    }
}
