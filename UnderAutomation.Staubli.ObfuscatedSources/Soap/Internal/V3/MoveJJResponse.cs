//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP response for a motion command, containing the result code.
	/// </summary>
	public class MoveJJResponse : IMoveResult {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.MoveJJResponse" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public MoveJJResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified motion identifier and return code.
		/// </summary>
		/// <param name="id">Motion command identifier.</param>
		/// <param name="motRet">Motion return code.</param>
		public MoveJJResponse(int id, MotionReturnCode motRet)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Motion command identifier.
		/// </summary>
		public int Id { get; set; }

		/// <summary>
		/// Return code indicating the outcome of the motion.
		/// </summary>
		public MotionReturnCode ReturnCode { get; set; }
	}
}
