//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents a task running on the controller.
	/// </summary>
	public class ControllerTask {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.ControllerTask" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ControllerTask()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the task.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Current execution state of the task.
		/// </summary>
		public ControllerTaskState State { get; set; }

		/// <summary>
		/// Priority level of the task.
		/// </summary>
		public int Priority { get; set; }

		/// <summary>
		/// Name of the entity that created the task.
		/// </summary>
		public string CreatedBy { get; set; }

		/// <summary>
		/// Runtime error code (0 if no error).
		/// </summary>
		public int RuntimeError { get; set; }

		/// <summary>
		/// Human-readable description of the runtime error.
		/// </summary>
		public string RuntimeErrorDescription { get; set; }

		/// <summary>
		/// Current program line being executed by the task.
		/// </summary>
		public ProgramLine ProgramLine { get; set; }
	}
}
