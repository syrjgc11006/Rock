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
using System;
using System.Collections.Generic;
using System.Linq;

using Rock.Data;

namespace Rock.Core
{
	/// <summary>
	/// Attribute Value POCO Service class
	/// </summary>
    public partial class AttributeValueService : Service<Rock.Core.AttributeValue>
    {
		/// <summary>
		/// Gets Attribute Values by Attribute Id
		/// </summary>
		/// <param name="attributeId">Attribute Id.</param>
		/// <returns>An enumerable list of AttributeValue objects.</returns>
	    public IEnumerable<Rock.Core.AttributeValue> GetByAttributeId( int attributeId )
        {
            return Repository.Find( t => t.AttributeId == attributeId );
        }
		
		/// <summary>
		/// Gets Attribute Values by Attribute Id And Entity Id
		/// </summary>
		/// <param name="attributeId">Attribute Id.</param>
		/// <param name="entityId">Entity Id.</param>
		/// <returns>An enumerable list of AttributeValue objects.</returns>
	    public IEnumerable<Rock.Core.AttributeValue> GetByAttributeIdAndEntityId( int attributeId, int? entityId )
        {
            return Repository.Find( t => t.AttributeId == attributeId && ( t.EntityId == entityId || ( entityId == null && t.EntityId == null ) ) );
        }
		
		/// <summary>
		/// Gets Attribute Values by Entity Id
		/// </summary>
		/// <param name="entityId">Entity Id.</param>
		/// <returns>An enumerable list of AttributeValue objects.</returns>
	    public IEnumerable<Rock.Core.AttributeValue> GetByEntityId( int? entityId )
        {
            return Repository.Find( t => ( t.EntityId == entityId || ( entityId == null && t.EntityId == null ) ) );
        }

        /// <summary>
        /// Gets the by attribute id and entity id.
        /// </summary>
        /// <param name="attributeId">The attribute id.</param>
        /// <param name="entityId">The entity id.</param>
        /// <returns></returns>
        public IEnumerable<Rock.Core.AttributeValue> GetByAttributeIdAndEntityId( int attributeId, int entityId )
        {
            return Repository.AsQueryable().
                Where( v => v.AttributeId == attributeId && v.EntityId == entityId ).
                OrderBy( v => v.Order );
        }

    }
}
