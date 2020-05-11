// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class WebhookJobDto
    {
        /// <summary>
        /// Initializes a new instance of the WebhookJobDto class.
        /// </summary>
        public WebhookJobDto()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WebhookJobDto class.
        /// </summary>
        /// <param name="key">The unique job identifier.</param>
        /// <param name="startTime">The date and time when the job execution
        /// started or null if the job hasn't started yet.</param>
        /// <param name="endTime">The date and time when the job execution
        /// ended or null if the job hasn't ended yet.</param>
        /// <param name="state">The state in which the job is. Possible values
        /// include: 'Pending', 'Running', 'Stopping', 'Terminating',
        /// 'Faulted', 'Successful', 'Stopped', 'Suspended', 'Resumed'</param>
        /// <param name="source">The Source name of the job.</param>
        /// <param name="sourceType">The Source type of the job. Possible
        /// values include: 'Manual', 'Schedule', 'Agent', 'Queue'</param>
        /// <param name="batchExecutionKey">The unique identifier grouping
        /// multiple jobs. It is usually generated when the job is created by a
        /// schedule.</param>
        /// <param name="info">Additional information about the current
        /// job.</param>
        /// <param name="startingScheduleId">The Id of the schedule that
        /// started the job, or null if the job was started by the
        /// user.</param>
        /// <param name="releaseName">The name of the release associated with
        /// the current name.</param>
        /// <param name="type">The type of the job, Attended if started via the
        /// robot, Unattended otherwise. Possible values include: 'Unattended',
        /// 'Attended'</param>
        /// <param name="hostMachineName">The name of the machine where the
        /// Robot run the job.</param>
        /// <param name="robot">The robot associated with the current
        /// job.</param>
        /// <param name="release">The release associated with the current
        /// job.</param>
        /// <param name="inputArguments">Input parameters in JSON format to be
        /// passed to job execution</param>
        /// <param name="outputArguments">Output parameters in JSON format
        /// resulted from job execution</param>
        public WebhookJobDto(long? id = default(long?), System.Guid? key = default(System.Guid?), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), WebhookJobDtoState? state = default(WebhookJobDtoState?), string source = default(string), WebhookJobDtoSourceType? sourceType = default(WebhookJobDtoSourceType?), System.Guid? batchExecutionKey = default(System.Guid?), string info = default(string), long? startingScheduleId = default(long?), string releaseName = default(string), WebhookJobDtoType? type = default(WebhookJobDtoType?), string hostMachineName = default(string), WebhookRobotDto robot = default(WebhookRobotDto), WebhookReleaseDto release = default(WebhookReleaseDto), object inputArguments = default(object), object outputArguments = default(object))
        {
            Id = id;
            Key = key;
            StartTime = startTime;
            EndTime = endTime;
            State = state;
            Source = source;
            SourceType = sourceType;
            BatchExecutionKey = batchExecutionKey;
            Info = info;
            StartingScheduleId = startingScheduleId;
            ReleaseName = releaseName;
            Type = type;
            HostMachineName = hostMachineName;
            Robot = robot;
            Release = release;
            InputArguments = inputArguments;
            OutputArguments = outputArguments;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public long? Id { get; private set; }

        /// <summary>
        /// Gets the unique job identifier.
        /// </summary>
        [JsonProperty(PropertyName = "Key")]
        public System.Guid? Key { get; private set; }

        /// <summary>
        /// Gets the date and time when the job execution started or null if
        /// the job hasn't started yet.
        /// </summary>
        [JsonProperty(PropertyName = "StartTime")]
        public System.DateTime? StartTime { get; private set; }

        /// <summary>
        /// Gets the date and time when the job execution ended or null if the
        /// job hasn't ended yet.
        /// </summary>
        [JsonProperty(PropertyName = "EndTime")]
        public System.DateTime? EndTime { get; private set; }

        /// <summary>
        /// Gets the state in which the job is. Possible values include:
        /// 'Pending', 'Running', 'Stopping', 'Terminating', 'Faulted',
        /// 'Successful', 'Stopped', 'Suspended', 'Resumed'
        /// </summary>
        [JsonProperty(PropertyName = "State")]
        public WebhookJobDtoState? State { get; private set; }

        /// <summary>
        /// Gets the Source name of the job.
        /// </summary>
        [JsonProperty(PropertyName = "Source")]
        public string Source { get; private set; }

        /// <summary>
        /// Gets the Source type of the job. Possible values include: 'Manual',
        /// 'Schedule', 'Agent', 'Queue'
        /// </summary>
        [JsonProperty(PropertyName = "SourceType")]
        public WebhookJobDtoSourceType? SourceType { get; private set; }

        /// <summary>
        /// Gets the unique identifier grouping multiple jobs. It is usually
        /// generated when the job is created by a schedule.
        /// </summary>
        [JsonProperty(PropertyName = "BatchExecutionKey")]
        public System.Guid? BatchExecutionKey { get; private set; }

        /// <summary>
        /// Gets additional information about the current job.
        /// </summary>
        [JsonProperty(PropertyName = "Info")]
        public string Info { get; private set; }

        /// <summary>
        /// Gets the Id of the schedule that started the job, or null if the
        /// job was started by the user.
        /// </summary>
        [JsonProperty(PropertyName = "StartingScheduleId")]
        public long? StartingScheduleId { get; private set; }

        /// <summary>
        /// Gets the name of the release associated with the current name.
        /// </summary>
        [JsonProperty(PropertyName = "ReleaseName")]
        public string ReleaseName { get; private set; }

        /// <summary>
        /// Gets the type of the job, Attended if started via the robot,
        /// Unattended otherwise. Possible values include: 'Unattended',
        /// 'Attended'
        /// </summary>
        [JsonProperty(PropertyName = "Type")]
        public WebhookJobDtoType? Type { get; private set; }

        /// <summary>
        /// Gets the name of the machine where the Robot run the job.
        /// </summary>
        [JsonProperty(PropertyName = "HostMachineName")]
        public string HostMachineName { get; private set; }

        /// <summary>
        /// Gets the robot associated with the current job.
        /// </summary>
        [JsonProperty(PropertyName = "Robot")]
        public WebhookRobotDto Robot { get; private set; }

        /// <summary>
        /// Gets the release associated with the current job.
        /// </summary>
        [JsonProperty(PropertyName = "Release")]
        public WebhookReleaseDto Release { get; private set; }

        /// <summary>
        /// Gets input parameters in JSON format to be passed to job execution
        /// </summary>
        [JsonProperty(PropertyName = "InputArguments")]
        public object InputArguments { get; private set; }

        /// <summary>
        /// Gets output parameters in JSON format resulted from job execution
        /// </summary>
        [JsonProperty(PropertyName = "OutputArguments")]
        public object OutputArguments { get; private set; }

    }
}
