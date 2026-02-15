//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Definition state of a physical I/O.
	/// </summary>
	public enum PhysicalIoEnumState {

		/// <summary>
		/// The I/O is defined and available.
		/// </summary>
		Defined = 0,

		/// <summary>
		/// The I/O is not defined.
		/// </summary>
		Undefined = 1,

		/// <summary>
		/// The I/O name is invalid.
		/// </summary>
		InvalidName = 2,
	}
}
