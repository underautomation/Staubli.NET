//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Configuration for above/below joint orientation.
	/// </summary>
	public enum AboveBelowConfig {

		/// <summary>
		/// Keep the same configuration as the current one.
		/// </summary>
		Same = 0,

		/// <summary>
		/// Above configuration.
		/// </summary>
		Above = 1,

		/// <summary>
		/// Below configuration.
		/// </summary>
		Below = 2,

		/// <summary>
		/// Free configuration (no constraint).
		/// </summary>
		Free = 3,
	}
}
