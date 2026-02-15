//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Specifies whether the motion is absolute or relative.
	/// </summary>
	public enum MoveType {

		/// <summary>
		/// Absolute motion in the reference frame.
		/// </summary>
		Absolute = 0,

		/// <summary>
		/// Relative motion from the current position.
		/// </summary>
		Relative = 1,
	}
}
