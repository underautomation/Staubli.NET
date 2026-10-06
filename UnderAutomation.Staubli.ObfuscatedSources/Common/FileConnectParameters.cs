//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Staubli.Files.Internal;

namespace UnderAutomation.Staubli.Common {
	/// <summary>
	/// Connection parameters of the file client (robot.File).
	/// With a real controller, the files are accessed through the FTP server of the controller, with the user and the password of these parameters.
	/// With a controller emulated by Staubli Robotics Suite, give the path of its .controller file as address: the files are accessed in the folder of this file.
	/// </summary>
	public class FileConnectParameters : FileConnectParametersBase {

		/// <summary>
		/// Default port of the FTP server
		/// </summary>
		public const int DEFAULT_PORT = 21;

		/// <summary>
		/// Default timeout of the FTP connection and of the transfers, in milliseconds
		/// </summary>
		public const int DEFAULT_TIMEOUT_MS = 30000;


		public FileConnectParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Should use this service (default: false)
		/// </summary>
		public bool Enable { get; set; }
	}
}
