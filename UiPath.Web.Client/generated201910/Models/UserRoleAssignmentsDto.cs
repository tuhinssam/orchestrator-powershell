// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client201910.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class UserRoleAssignmentsDto
    {
        /// <summary>
        /// Initializes a new instance of the UserRoleAssignmentsDto class.
        /// </summary>
        public UserRoleAssignmentsDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the UserRoleAssignmentsDto class.
        /// </summary>
        public UserRoleAssignmentsDto(IList<RoleUsersDto> tenantRoles = default(IList<RoleUsersDto>), IList<FolderAssignmentsDto> pageItems = default(IList<FolderAssignmentsDto>), int? count = default(int?), long? id = default(long?))
        {
            TenantRoles = tenantRoles;
            PageItems = pageItems;
            Count = count;
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "TenantRoles")]
        public IList<RoleUsersDto> TenantRoles { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "PageItems")]
        public IList<FolderAssignmentsDto> PageItems { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Count")]
        public int? Count { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; set; }

    }
}