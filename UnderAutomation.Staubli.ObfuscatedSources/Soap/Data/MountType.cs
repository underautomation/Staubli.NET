//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Robot mounting type.
	/// </summary>
	public enum MountType {

		/// <summary>
		/// Invalid or unknown mount type.
		/// </summary>
		Invalid = 0,

		/// <summary>
		/// Robot is floor-mounted.
		/// </summary>
		Floor = 1,

		/// <summary>
		/// Robot is ceiling-mounted.
		/// </summary>
		Ceiling = 2,

		/// <summary>
		/// Robot is wall-mounted.
		/// </summary>
		Wall = 3,
	}
}
