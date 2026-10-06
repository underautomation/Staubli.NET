//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;

namespace UnderAutomation.Staubli.Files {
	/// <summary>
	/// Exception thrown when an operation on the files of the controller fails: the controller refused it, the file does not exist,
	/// or the communication failed. The message gives the reason and, when it is known, what to do.
	/// </summary>
	public class FileException : Exception, ISerializable {

		/// <summary>
		/// Path of the file or folder on the controller concerned by the operation. Null when the operation has no path.
		/// </summary>
		public string RemotePath { get; }

		/// <summary>
		/// FTP reply code returned by the controller (for example 550). 0 when the controller did not reply, and with an emulated controller.
		/// </summary>
		public int ReplyCode { get; }

		/// <summary>
		/// Reply text returned by the controller. Null when the controller did not reply, and with an emulated controller.
		/// </summary>
		public string ReplyMessage { get; }
	}
}
