// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class ODataValueIEnumerableUserDto
    {
        /// <summary>
        /// Initializes a new instance of the ODataValueIEnumerableUserDto
        /// class.
        /// </summary>
        public ODataValueIEnumerableUserDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ODataValueIEnumerableUserDto
        /// class.
        /// </summary>
        public ODataValueIEnumerableUserDto(string odatacontext = default(string), IList<UserDto> value = default(IList<UserDto>))
        {
            Odatacontext = odatacontext;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "@odata.context")]
        public string Odatacontext { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<UserDto> Value { get; set; }

    }
}
