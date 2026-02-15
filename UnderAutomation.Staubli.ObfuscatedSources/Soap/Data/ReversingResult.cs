//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Result code for reverse kinematics computation.
	/// </summary>
	public enum ReversingResult {

		/// <summary>
		/// Reverse kinematics succeeded.
		/// </summary>
		Success = 0,

		/// <summary>
		/// The algorithm did not converge to a solution.
		/// </summary>
		NoConvergence = 1,

		/// <summary>
		/// The computed joint position is out of range.
		/// </summary>
		JointOutOfRange = 2,

		/// <summary>
		/// The target is outside the robot workspace.
		/// </summary>
		OutOfWorkspace = 3,

		/// <summary>
		/// The specified configuration is invalid.
		/// </summary>
		InvalidConfiguration = 4,

		/// <summary>
		/// The specified orientation is invalid.
		/// </summary>
		InvalidOrientation = 5,

		/// <summary>
		/// The robot kinematics type is not supported.
		/// </summary>
		UnsupportedKinematics = 6,

		/// <summary>
		/// The frame is unconstrained.
		/// </summary>
		UnconstrainedFrame = 7,

		/// <summary>
		/// Invalid error code returned.
		/// </summary>
		InvalidErrorCode = 8,
	}
}
