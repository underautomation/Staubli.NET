//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using UnderAutomation.Staubli.Files.Internal;
using System.Threading;
using System.Threading.Tasks;

namespace UnderAutomation.Staubli.Files {
	/// <summary>
	/// Standalone client for the files of a Staubli controller: upload, download, listing and management.
	/// With a real controller, the files are accessed through the FTP server of the controller.
	/// With a controller emulated by Staubli Robotics Suite, they are accessed in the folder of its .controller file.
	/// </summary>
	public class FileClient : FileClientBase {

		/// <summary>
		/// Create a new instance of FileClient
		/// </summary>
		public FileClient()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to a controller
		/// </summary>
		/// <param name="address">IP or host name of a real controller. For a controller emulated by Staubli Robotics Suite, path of its .controller file
		///             (local path, or UNC path when the emulation runs on another computer).</param>
		/// <param name="user">User of the FTP server of the controller. Not used with an emulated controller.</param>
		/// <param name="password">Password of the user. Not used with an emulated controller.</param>
		/// <param name="port">Port of the FTP server of the controller</param>
		/// <param name="timeoutMs">Timeout of the FTP connection and of the transfers, in milliseconds</param>
		public void Connect(string address, string user, string password, int port = 21, int timeoutMs = 30000)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connect to a controller (asynchronous)
		/// </summary>
		/// <param name="address">IP or host name of a real controller. For a controller emulated by Staubli Robotics Suite, path of its .controller file
		///             (local path, or UNC path when the emulation runs on another computer).</param>
		/// <param name="user">User of the FTP server of the controller. Not used with an emulated controller.</param>
		/// <param name="password">Password of the user. Not used with an emulated controller.</param>
		/// <param name="port">Port of the FTP server of the controller</param>
		/// <param name="timeoutMs">Timeout of the FTP connection and of the transfers, in milliseconds</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task ConnectAsync(string address, string user, string password, int port = 21, int timeoutMs = 30000, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}
	}
}
