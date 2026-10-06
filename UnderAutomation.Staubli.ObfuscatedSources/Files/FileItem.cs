//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace UnderAutomation.Staubli.Files {
	/// <summary>
	/// A file or a folder of the controller
	/// </summary>
	public class FileItem {


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Name of the file or folder, without its path (for example "myApp.pjx")
		/// </summary>
		public string Name { get; }

		/// <summary>
		/// Full path of the file or folder on the controller (for example "/usr/usrapp/myApp/myApp.pjx")
		/// </summary>
		public string FullName { get; }

		/// <summary>
		/// File or folder
		/// </summary>
		public FileItemType Type { get; }

		/// <summary>
		/// Size of the file in bytes. 0 for a folder, and 0 when the controller does not give the size.
		/// </summary>
		public long Size { get; }

		/// <summary>
		/// Date and time of the last modification, as given by the controller. With a controller emulated by Staubli Robotics Suite, local time of the computer.
		/// </summary>
		public DateTime Modified { get; }
	}
}
