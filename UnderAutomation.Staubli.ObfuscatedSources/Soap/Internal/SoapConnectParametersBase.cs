//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Staubli.Soap.Internal {
	/// <summary>
	/// Base class for SOAP connection parameters
	/// </summary>
	public class SoapConnectParametersBase {


		public SoapConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Username for the SOAP service (default: default)
		/// </summary>
		public string User { get; set; }

		/// <summary>
		/// Password for the SOAP service (default: default)
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Port of the SOAP service. Default: 0 (automatic). With 0, the SDK uses 851 for a real controller, and the SOAP port of the network
		/// configuration of a controller emulated by Staubli Robotics Suite (851 when it is not found).
		/// </summary>
		public int Port { get; set; }
	}
}
