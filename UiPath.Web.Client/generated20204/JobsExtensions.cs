// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UiPath.Web.Client20204
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Jobs.
    /// </summary>
    public static partial class JobsExtensions
    {
            /// <summary>
            /// Gets Jobs.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Read.
            ///
            /// Required permissions: Jobs.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ODataValueIEnumerableJobDto Get(this IJobs operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets Jobs.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Read.
            ///
            /// Required permissions: Jobs.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='filter'>
            /// Filters the results, based on a Boolean condition.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='orderby'>
            /// Sorts the results.
            /// </param>
            /// <param name='top'>
            /// Returns only the first n results.
            /// </param>
            /// <param name='skip'>
            /// Skips the first n results.
            /// </param>
            /// <param name='count'>
            /// Includes a count of the matching results in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueIEnumerableJobDto> GetAsync(this IJobs operations, string expand = default(string), string filter = default(string), string select = default(string), string orderby = default(string), int? top = default(int?), int? skip = default(int?), bool? count = default(bool?), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(expand, filter, select, orderby, top, skip, count, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a single job.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Read.
            ///
            /// Required permissions: Jobs.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static JobDto GetById(this IJobs operations, long id, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetByIdAsync(id, expand, select, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a single job.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Read.
            ///
            /// Required permissions: Jobs.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='expand'>
            /// Expands related entities inline.
            /// </param>
            /// <param name='select'>
            /// Selects which properties to include in the response.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobDto> GetByIdAsync(this IJobs operations, long id, string expand = default(string), string select = default(string), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetByIdWithHttpMessagesAsync(id, expand, select, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Adds a new job and sets it in Pending state for each robot based on the
            /// input parameters and notifies the respective robots about the pending job.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
            ///
            /// Required permissions: Jobs.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startJobParameters'>
            /// StartInfo - The information required to register the new jobs.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static ODataValueIEnumerableJobDto StartJobs(this IJobs operations, StartJobParameters startJobParameters = default(StartJobParameters), long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.StartJobsAsync(startJobParameters, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Adds a new job and sets it in Pending state for each robot based on the
            /// input parameters and notifies the respective robots about the pending job.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
            ///
            /// Required permissions: Jobs.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='startJobParameters'>
            /// StartInfo - The information required to register the new jobs.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ODataValueIEnumerableJobDto> StartJobsAsync(this IJobs operations, StartJobParameters startJobParameters = default(StartJobParameters), long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.StartJobsWithHttpMessagesAsync(startJobParameters, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Cancels or terminates the specified job.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
            ///
            /// Required permissions: Jobs.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='stopJobParameters'>
            /// Strategy - States whether a job should be soft stopped or killed
            /// immediately.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void StopJobById(this IJobs operations, long id, StopJobParameters stopJobParameters, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.StopJobByIdAsync(id, stopJobParameters, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels or terminates the specified job.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
            ///
            /// Required permissions: Jobs.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// key: Id
            /// </param>
            /// <param name='stopJobParameters'>
            /// Strategy - States whether a job should be soft stopped or killed
            /// immediately.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopJobByIdAsync(this IJobs operations, long id, StopJobParameters stopJobParameters, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.StopJobByIdWithHttpMessagesAsync(id, stopJobParameters, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Cancels or terminates the specified jobs.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
            ///
            /// Required permissions: Jobs.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stopJobsParameters'>
            /// JobIds - The ids for the jobs to be canceled or terminated;
            /// Strategy - States whether a job should be soft stopped or killed
            /// immediately.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void StopJobs(this IJobs operations, StopJobsParameters stopJobsParameters, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.StopJobsAsync(stopJobsParameters, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Cancels or terminates the specified jobs.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
            ///
            /// Required permissions: Jobs.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='stopJobsParameters'>
            /// JobIds - The ids for the jobs to be canceled or terminated;
            /// Strategy - States whether a job should be soft stopped or killed
            /// immediately.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task StopJobsAsync(this IJobs operations, StopJobsParameters stopJobsParameters, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.StopJobsWithHttpMessagesAsync(stopJobsParameters, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Resumes the specified job.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
            ///
            /// Required permissions: Jobs.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resumeParameters'>
            /// The specified job key.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static JobDto ResumeJob(this IJobs operations, ResumeParameters resumeParameters, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.ResumeJobAsync(resumeParameters, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Resumes the specified job.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Jobs or Jobs.Write.
            ///
            /// Required permissions: Jobs.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resumeParameters'>
            /// The specified job key.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<JobDto> ResumeJobAsync(this IJobs operations, ResumeParameters resumeParameters, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ResumeJobWithHttpMessagesAsync(resumeParameters, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
