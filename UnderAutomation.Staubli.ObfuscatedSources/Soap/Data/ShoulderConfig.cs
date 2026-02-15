//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Shoulder configuration for the robot arm.
	/// </summary>
	public enum ShoulderConfig {

		/// <summary>
		/// Keep the same configuration as the current one.
		/// </summary>
		Same = 0,

		/// <summary>
		/// Left-handed configuration.
		/// </summary>
		Lefty = 1,

		/// <summary>
		/// Right-handed configuration.
		/// </summary>
		Righty = 2,

		/// <summary>
		/// Free configuration (no constraint).
		/// </summary>
		Free = 3,
	}
}
