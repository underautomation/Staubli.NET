//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Common;

namespace UnderAutomation.Staubli {
	/// <summary>
	/// Connection parameters
	/// </summary>
	public class ConnectionParameters {

		/// <summary>
		/// Instanciate a new connection parameters
		/// </summary>
		public ConnectionParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Instanciate a new connection parameters with a specified address
		/// </summary>
		public ConnectionParameters(string address)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Address of the robot (IP or host name)
		/// </summary>
		public string Address { get; set; }

		/// <summary>
		/// Send a ping command before initializing any connections
		/// </summary>
		public bool PingBeforeConnect { get; set; }

		/// <summary>
		/// Soap connection parameters
		/// </summary>
		public SoapConnectParameters Soap { get; set; }
	}
}
