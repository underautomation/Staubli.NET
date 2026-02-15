//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Execution state of a controller task.
	/// </summary>
	public enum ControllerTaskState {

		/// <summary>
		/// Task is idle and not executing.
		/// </summary>
		Idle = 0,

		/// <summary>
		/// Task is transitioning between states.
		/// </summary>
		Transition = 1,

		/// <summary>
		/// Task is currently running.
		/// </summary>
		Running = 2,

		/// <summary>
		/// Task is executing step by step.
		/// </summary>
		Stepping = 3,

		/// <summary>
		/// Task is stopped.
		/// </summary>
		Stopped = 4,
	}
}
