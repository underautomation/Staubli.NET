//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Staubli.Files.Internal {
	/// <summary>
	/// Base class for the connection parameters of the file client
	/// </summary>
	public class FileConnectParametersBase {


		public FileConnectParametersBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// User of the FTP server of the controller (default: default). Not used with a controller emulated by Staubli Robotics Suite.
		/// </summary>
		public string User { get; set; }

		/// <summary>
		/// Password of the user (default: default). Not used with a controller emulated by Staubli Robotics Suite.
		/// </summary>
		public string Password { get; set; }

		/// <summary>
		/// Port of the FTP server of the controller (default: 21)
		/// </summary>
		public int Port { get; set; }

		/// <summary>
		/// Timeout of the FTP connection and of the transfers, in milliseconds (default: 30000)
		/// </summary>
		public int TimeoutMs { get; set; }
	}
}
