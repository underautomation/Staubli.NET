//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Internal.V2 {
	/// <summary>
	/// SOAP request to resume a suspended task on the controller.
	/// </summary>
	public class TaskResumeRequest {

		/// <summary>
		/// Name of the task to resume.
		/// </summary>
		public string taskName;

		/// <summary>
		/// Creator of the task.
		/// </summary>
		public string createdBy;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V2.TaskResumeRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public TaskResumeRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified task name and creator.
		/// </summary>
		/// <param name="taskName">Name of the task to resume.</param>
		/// <param name="createdBy">Creator of the task.</param>
		public TaskResumeRequest(string taskName, string createdBy)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
