//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Robot kinematic type.
	/// </summary>
	public enum Kinematic {

		/// <summary>
		/// Invalid or unknown kinematic type.
		/// </summary>
		Invalid = 0,

		/// <summary>
		/// 6-axis anthropomorphic robot.
		/// </summary>
		Anthropomorph6 = 1,

		/// <summary>
		/// 6-axis anthropomorphic parallel robot.
		/// </summary>
		Anthrioparallel6 = 2,

		/// <summary>
		/// 5-axis anthropomorphic robot.
		/// </summary>
		Anthropomorph5 = 3,

		/// <summary>
		/// SCARA robot.
		/// </summary>
		Scara = 4,

		/// <summary>
		/// Eisenmann kinematic type.
		/// </summary>
		Eisenmann = 5,
	}
}
