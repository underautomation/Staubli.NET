//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP response for motion control operations (reset, restart, stop).
	/// </summary>
	public class ResetMotionResponse {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.ResetMotionResponse" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ResetMotionResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified return code.
		/// </summary>
		/// <param name="motRet">Motion return code.</param>
		public ResetMotionResponse(MotionReturnCode motRet)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Return code indicating the outcome of the motion operation.
		/// </summary>
		public MotionReturnCode ReturnCode { get; set; }
	}
}
