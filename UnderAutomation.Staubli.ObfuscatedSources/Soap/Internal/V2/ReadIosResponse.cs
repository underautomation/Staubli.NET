//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V2 {
	/// <summary>
	/// SOAP response containing the state of physical I/Os.
	/// </summary>
	public class ReadIosResponse {

		/// <summary>
		/// Array of physical I/O states.
		/// </summary>
		public PhysicalIoState[] state;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V2.ReadIosResponse" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ReadIosResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified I/O states.
		/// </summary>
		/// <param name="state">Array of physical I/O states.</param>
		public ReadIosResponse(PhysicalIoState[] state)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
