//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Internal {
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
		/// Port of the SOAP service (default: 851)
		/// </summary>
		public int Port { get; set; }
	}
}
