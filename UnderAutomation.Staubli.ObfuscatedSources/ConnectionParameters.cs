//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Staubli.Common;

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


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Address of the robot: IP or host name of a real controller.
		/// For a controller emulated by Staubli Robotics Suite, path of the .controller file of the controller in the cell
		/// (for example C:\...\MyCell\Controller1\Controller1.controller): the SOAP client then connects to the local computer, and the file
		/// client uses the folder of this file. Give a UNC path when the emulation runs on another computer: the SOAP client then connects to
		/// this computer. A path that is not a .controller file is refused.
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

		/// <summary>
		/// File client connection parameters (upload, download, listing and management of the files of the controller)
		/// </summary>
		public FileConnectParameters File { get; set; }
	}
}
