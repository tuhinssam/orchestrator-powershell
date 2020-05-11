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
    /// Extension methods for TaskForms.
    /// </summary>
    public static partial class TaskFormsExtensions
    {
            /// <summary>
            /// Creates a new Form Task.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Write.
            ///
            /// Required permissions: Tasks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='formTaskCreateRequest'>
            /// The form task to be created.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TaskDataDto CreateFormTask(this ITaskForms operations, FormTaskCreateRequest formTaskCreateRequest, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.CreateFormTaskAsync(formTaskCreateRequest, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a new Form Task.
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Write.
            ///
            /// Required permissions: Tasks.Create.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='formTaskCreateRequest'>
            /// The form task to be created.
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskDataDto> CreateFormTaskAsync(this ITaskForms operations, FormTaskCreateRequest formTaskCreateRequest, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.CreateFormTaskWithHttpMessagesAsync(formTaskCreateRequest, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns form dto to render task form
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Read.
            ///
            /// Required permissions: Tasks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskId'>
            /// Task id
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TaskFormDto GetTaskFormById(this ITaskForms operations, long taskId, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetTaskFormByIdAsync(taskId, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns form dto to render task form
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Read.
            ///
            /// Required permissions: Tasks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskId'>
            /// Task id
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskFormDto> GetTaskFormByIdAsync(this ITaskForms operations, long taskId, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetTaskFormByIdWithHttpMessagesAsync(taskId, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Returns task data dto
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Read.
            ///
            /// Required permissions: Tasks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskId'>
            /// Task id
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static TaskDataDto GetTaskDataById(this ITaskForms operations, long taskId, long? xUIPATHOrganizationUnitId = default(long?))
            {
                return operations.GetTaskDataByIdAsync(taskId, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns task data dto
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Read.
            ///
            /// Required permissions: Tasks.View.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskId'>
            /// Task id
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<TaskDataDto> GetTaskDataByIdAsync(this ITaskForms operations, long taskId, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetTaskDataByIdWithHttpMessagesAsync(taskId, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Complete the task by saving form data and action taken
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskCompletionRequest'>
            /// TaskCompletionRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            public static void CompleteTask(this ITaskForms operations, TaskCompletionRequest taskCompletionRequest, long? xUIPATHOrganizationUnitId = default(long?))
            {
                operations.CompleteTaskAsync(taskCompletionRequest, xUIPATHOrganizationUnitId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Complete the task by saving form data and action taken
            /// </summary>
            /// <remarks>
            /// Client Credentials Flow required permissions: Tasks or Tasks.Write.
            ///
            /// Required permissions: Tasks.Edit.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='taskCompletionRequest'>
            /// TaskCompletionRequest
            /// </param>
            /// <param name='xUIPATHOrganizationUnitId'>
            /// Folder/OrganizationUnit Id
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task CompleteTaskAsync(this ITaskForms operations, TaskCompletionRequest taskCompletionRequest, long? xUIPATHOrganizationUnitId = default(long?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                (await operations.CompleteTaskWithHttpMessagesAsync(taskCompletionRequest, xUIPATHOrganizationUnitId, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
