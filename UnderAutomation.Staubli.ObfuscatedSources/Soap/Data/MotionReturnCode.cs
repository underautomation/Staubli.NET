//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Return code for robot motion commands.
	/// </summary>
	public enum MotionReturnCode {

		/// <summary>
		/// Success, no error occurred.
		/// </summary>
		Success = 0,

		/// <summary>
		/// The robot is not ready to execute motion.
		/// </summary>
		NotReady = 1,

		/// <summary>
		/// Invalid parameter provided to the motion command.
		/// </summary>
		ParameterError = 2,

		/// <summary>
		/// Motion command misuse error.
		/// </summary>
		MisuseError = 3,

		/// <summary>
		/// An unexpected error occurred during motion.
		/// </summary>
		UnexpectedError = 4,
	}
}
