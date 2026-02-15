//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Internal;

namespace Common {
	/// <summary>
	/// SOAP connection parameters for communicating with the Staubli robot controller.
	/// </summary>
	public class SoapConnectParameters : SoapConnectParametersBase {

		/// <summary>
		/// Default port for SOAP service
		/// </summary>
		public const int DEFAULT_PORT = 851;


		public SoapConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Should use this service (default: true)
		/// </summary>
		public bool Enable { get; set; }
	}
}
