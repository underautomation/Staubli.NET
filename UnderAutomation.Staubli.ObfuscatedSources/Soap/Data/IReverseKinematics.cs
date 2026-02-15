//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents the result of a reverse (inverse) kinematics computation.
	/// </summary>
	public interface IReverseKinematics {

		/// <summary>
		/// Joint angles resulting from the reverse kinematics computation.
		/// </summary>
		double[] Joint { get; }

		/// <summary>
		/// Result code indicating the outcome of the reverse kinematics computation.
		/// </summary>
		ReversingResult Result { get; }
	}
}
