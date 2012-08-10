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

namespace Rock.REST.CMS
{
	/// <summary>
	/// REST WCF service for BlockInstances
	/// </summary>
    [Export(typeof(IService))]
    [ExportMetadata("RouteName", "CMS/BlockInstance")]
	[AspNetCompatibilityRequirements( RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed )]
    public partial class BlockInstanceService : IBlockInstanceService, IService
    {
		/// <summary>
		/// Gets a BlockInstance object
		/// </summary>
		[WebGet( UriTemplate = "{id}" )]
        public Rock.CMS.DTO.BlockInstance Get( string id )
        {
            var currentUser = Rock.CMS.UserService.GetCurrentUser();
            if ( currentUser == null )
                throw new WebFaultException<string>("Must be logged in", System.Net.HttpStatusCode.Forbidden );

            using (Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope())
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.CMS.BlockInstanceService BlockInstanceService = new Rock.CMS.BlockInstanceService();
				Rock.CMS.BlockInstance BlockInstance = BlockInstanceService.Get( int.Parse( id ) );
                if ( BlockInstance.IsAuthorized( "View", currentUser.Person ) )
					return BlockInstance.DataTransferObject;
				else
					throw new WebFaultException<string>( "Not Authorized to View this BlockInstance", System.Net.HttpStatusCode.Forbidden );
            }
        }
		
		/// <summary>
		/// Gets a BlockInstance object
		/// </summary>
		[WebGet( UriTemplate = "{id}/{apiKey}" )]
        public Rock.CMS.DTO.BlockInstance ApiGet( string id, string apiKey )
        {
            using (Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope())
            {
				Rock.CMS.UserService userService = new Rock.CMS.UserService();
                Rock.CMS.User user = userService.Queryable().Where( u => u.ApiKey == apiKey ).FirstOrDefault();

				if (user != null)
				{
					uow.objectContext.Configuration.ProxyCreationEnabled = false;
					Rock.CMS.BlockInstanceService BlockInstanceService = new Rock.CMS.BlockInstanceService();
					Rock.CMS.BlockInstance BlockInstance = BlockInstanceService.Get( int.Parse( id ) );
                    if ( BlockInstance.IsAuthorized( "View", user.Person ) )
						return BlockInstance.DataTransferObject;
					else
						throw new WebFaultException<string>( "Not Authorized to View this BlockInstance", System.Net.HttpStatusCode.Forbidden );
				}
				else
					throw new WebFaultException<string>( "Invalid API Key", System.Net.HttpStatusCode.Forbidden );
            }
        }
		
		/// <summary>
		/// Updates a BlockInstance object
		/// </summary>
		[WebInvoke( Method = "PUT", UriTemplate = "{id}" )]
        public void UpdateBlockInstance( string id, Rock.CMS.DTO.BlockInstance BlockInstance )
        {
            var currentUser = Rock.CMS.UserService.GetCurrentUser();
            if ( currentUser == null )
                throw new WebFaultException<string>("Must be logged in", System.Net.HttpStatusCode.Forbidden );

            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.CMS.BlockInstanceService BlockInstanceService = new Rock.CMS.BlockInstanceService();
				Rock.CMS.BlockInstance existingBlockInstance = BlockInstanceService.Get( int.Parse( id ) );
                if ( existingBlockInstance.IsAuthorized( "Edit", currentUser.Person ) )
				{
					uow.objectContext.Entry(existingBlockInstance).CurrentValues.SetValues(BlockInstance);
					
					if (existingBlockInstance.IsValid)
						BlockInstanceService.Save( existingBlockInstance, currentUser.PersonId );
					else
						throw new WebFaultException<string>( existingBlockInstance.ValidationResults.AsDelimited(", "), System.Net.HttpStatusCode.BadRequest );
				}
				else
					throw new WebFaultException<string>( "Not Authorized to Edit this BlockInstance", System.Net.HttpStatusCode.Forbidden );
            }
        }

		/// <summary>
		/// Updates a BlockInstance object
		/// </summary>
		[WebInvoke( Method = "PUT", UriTemplate = "{id}/{apiKey}" )]
        public void ApiUpdateBlockInstance( string id, string apiKey, Rock.CMS.DTO.BlockInstance BlockInstance )
        {
            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				Rock.CMS.UserService userService = new Rock.CMS.UserService();
                Rock.CMS.User user = userService.Queryable().Where( u => u.ApiKey == apiKey ).FirstOrDefault();

				if (user != null)
				{
					uow.objectContext.Configuration.ProxyCreationEnabled = false;
					Rock.CMS.BlockInstanceService BlockInstanceService = new Rock.CMS.BlockInstanceService();
					Rock.CMS.BlockInstance existingBlockInstance = BlockInstanceService.Get( int.Parse( id ) );
                    if ( existingBlockInstance.IsAuthorized( "Edit", user.Person ) )
					{
						uow.objectContext.Entry(existingBlockInstance).CurrentValues.SetValues(BlockInstance);
					
						if (existingBlockInstance.IsValid)
							BlockInstanceService.Save( existingBlockInstance, user.PersonId );
						else
							throw new WebFaultException<string>( existingBlockInstance.ValidationResults.AsDelimited(", "), System.Net.HttpStatusCode.BadRequest );
					}
					else
						throw new WebFaultException<string>( "Not Authorized to Edit this BlockInstance", System.Net.HttpStatusCode.Forbidden );
				}
				else
					throw new WebFaultException<string>( "Invalid API Key", System.Net.HttpStatusCode.Forbidden );
            }
        }

		/// <summary>
		/// Creates a new BlockInstance object
		/// </summary>
		[WebInvoke( Method = "POST", UriTemplate = "" )]
        public void CreateBlockInstance( Rock.CMS.DTO.BlockInstance BlockInstance )
        {
            var currentUser = Rock.CMS.UserService.GetCurrentUser();
            if ( currentUser == null )
                throw new WebFaultException<string>("Must be logged in", System.Net.HttpStatusCode.Forbidden );

            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.CMS.BlockInstanceService BlockInstanceService = new Rock.CMS.BlockInstanceService();
				Rock.CMS.BlockInstance existingBlockInstance = new Rock.CMS.BlockInstance();
				BlockInstanceService.Add( existingBlockInstance, currentUser.PersonId );
				uow.objectContext.Entry(existingBlockInstance).CurrentValues.SetValues(BlockInstance);

				if (existingBlockInstance.IsValid)
					BlockInstanceService.Save( existingBlockInstance, currentUser.PersonId );
				else
					throw new WebFaultException<string>( existingBlockInstance.ValidationResults.AsDelimited(", "), System.Net.HttpStatusCode.BadRequest );
            }
        }

		/// <summary>
		/// Creates a new BlockInstance object
		/// </summary>
		[WebInvoke( Method = "POST", UriTemplate = "{apiKey}" )]
        public void ApiCreateBlockInstance( string apiKey, Rock.CMS.DTO.BlockInstance BlockInstance )
        {
            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				Rock.CMS.UserService userService = new Rock.CMS.UserService();
                Rock.CMS.User user = userService.Queryable().Where( u => u.ApiKey == apiKey ).FirstOrDefault();

				if (user != null)
				{
					uow.objectContext.Configuration.ProxyCreationEnabled = false;
					Rock.CMS.BlockInstanceService BlockInstanceService = new Rock.CMS.BlockInstanceService();
					Rock.CMS.BlockInstance existingBlockInstance = new Rock.CMS.BlockInstance();
					BlockInstanceService.Add( existingBlockInstance, user.PersonId );
					uow.objectContext.Entry(existingBlockInstance).CurrentValues.SetValues(BlockInstance);

					if (existingBlockInstance.IsValid)
						BlockInstanceService.Save( existingBlockInstance, user.PersonId );
					else
						throw new WebFaultException<string>( existingBlockInstance.ValidationResults.AsDelimited(", "), System.Net.HttpStatusCode.BadRequest );
				}
				else
					throw new WebFaultException<string>( "Invalid API Key", System.Net.HttpStatusCode.Forbidden );
            }
        }

		/// <summary>
		/// Deletes a BlockInstance object
		/// </summary>
		[WebInvoke( Method = "DELETE", UriTemplate = "{id}" )]
        public void DeleteBlockInstance( string id )
        {
            var currentUser = Rock.CMS.UserService.GetCurrentUser();
            if ( currentUser == null )
                throw new WebFaultException<string>("Must be logged in", System.Net.HttpStatusCode.Forbidden );

            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				uow.objectContext.Configuration.ProxyCreationEnabled = false;
				Rock.CMS.BlockInstanceService BlockInstanceService = new Rock.CMS.BlockInstanceService();
				Rock.CMS.BlockInstance BlockInstance = BlockInstanceService.Get( int.Parse( id ) );
                if ( BlockInstance.IsAuthorized( "Edit", currentUser.Person ) )
				{
					BlockInstanceService.Delete( BlockInstance, currentUser.PersonId );
					BlockInstanceService.Save( BlockInstance, currentUser.PersonId );
				}
				else
					throw new WebFaultException<string>( "Not Authorized to Edit this BlockInstance", System.Net.HttpStatusCode.Forbidden );
            }
        }

		/// <summary>
		/// Deletes a BlockInstance object
		/// </summary>
		[WebInvoke( Method = "DELETE", UriTemplate = "{id}/{apiKey}" )]
        public void ApiDeleteBlockInstance( string id, string apiKey )
        {
            using ( Rock.Data.UnitOfWorkScope uow = new Rock.Data.UnitOfWorkScope() )
            {
				Rock.CMS.UserService userService = new Rock.CMS.UserService();
                Rock.CMS.User user = userService.Queryable().Where( u => u.ApiKey == apiKey ).FirstOrDefault();

				if (user != null)
				{
					uow.objectContext.Configuration.ProxyCreationEnabled = false;
					Rock.CMS.BlockInstanceService BlockInstanceService = new Rock.CMS.BlockInstanceService();
					Rock.CMS.BlockInstance BlockInstance = BlockInstanceService.Get( int.Parse( id ) );
                    if ( BlockInstance.IsAuthorized( "Edit", user.Person ) )
					{
						BlockInstanceService.Delete( BlockInstance, user.PersonId );
						BlockInstanceService.Save( BlockInstance, user.PersonId );
					}
					else
						throw new WebFaultException<string>( "Not Authorized to Edit this BlockInstance", System.Net.HttpStatusCode.Forbidden );
				}
				else
					throw new WebFaultException<string>( "Invalid API Key", System.Net.HttpStatusCode.Forbidden );
            }
        }

    }
}
