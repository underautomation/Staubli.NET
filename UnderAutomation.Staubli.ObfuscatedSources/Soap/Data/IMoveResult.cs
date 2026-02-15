//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents the result of a robot motion command.
	/// </summary>
	public interface IMoveResult {

		/// <summary>
		/// Identifier of the motion command.
		/// </summary>
		int Id { get; }

		/// <summary>
		/// Return code indicating the outcome of the motion command.
		/// </summary>
		MotionReturnCode ReturnCode { get; }
	}
}
