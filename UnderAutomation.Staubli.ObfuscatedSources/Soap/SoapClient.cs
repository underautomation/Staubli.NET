//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Staubli.Soap.Internal;

namespace UnderAutomation.Staubli.Soap {
	/// <summary>
	/// SOAP client for Staubli robots
	/// </summary>
	public class SoapClient : SoapClientBase {

		/// <summary>
		/// Create a new instance of SoapClient
		/// </summary>
		public SoapClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to a robot
		/// </summary>
		/// <param name="ip">IP or network name of the robot. For a controller emulated by Staubli Robotics Suite, path of the .controller file of the controller
		///             in the cell (UNC path when the emulation runs on another computer).</param>
		/// <param name="user">Username for the SOAP service</param>
		/// <param name="password">Password for the SOAP service</param>
		/// <param name="port">Port of the SOAP service. 0 (automatic): 851 for a real controller, port of the network configuration of an emulated controller.</param>
		public void Connect(string ip, string user, string password, int port)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
