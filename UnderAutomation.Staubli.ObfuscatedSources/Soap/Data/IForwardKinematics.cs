//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents the result of a forward kinematics computation.
	/// </summary>
	public interface IForwardKinematics {

		/// <summary>
		/// Cartesian position resulting from the forward kinematics computation.
		/// </summary>
		Frame Position { get; }

		/// <summary>
		/// Robot configuration associated with the computed position.
		/// </summary>
		Config Config { get; }
	}
}
