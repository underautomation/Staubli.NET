//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Return code for robot power commands.
	/// </summary>
	public enum PowerReturnCode {

		/// <summary>
		/// Success, no error occurred.
		/// </summary>
		Success = 0,

		/// <summary>
		/// Cannot change power while the robot is not stopped.
		/// </summary>
		RobotNotStopped = 1,

		/// <summary>
		/// Timeout while enabling power.
		/// </summary>
		EnableTimeout = 2,

		/// <summary>
		/// Timeout while disabling power.
		/// </summary>
		DisableTimeout = 3,

		/// <summary>
		/// Power can only be changed in remote mode.
		/// </summary>
		OnlyInRemoteMode = 4,
	}
}
