//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Positive/negative configuration for a robot joint.
	/// </summary>
	public enum PositiveNegativeConfig {

		/// <summary>
		/// Keep the same configuration as the current one.
		/// </summary>
		Same = 0,

		/// <summary>
		/// Positive configuration.
		/// </summary>
		Positive = 1,

		/// <summary>
		/// Negative configuration.
		/// </summary>
		Negative = 2,

		/// <summary>
		/// Free configuration (no constraint).
		/// </summary>
		Free = 3,
	}
}
