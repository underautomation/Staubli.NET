//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Threading;
using System.Threading.Tasks;
using System;
using System.IO;

namespace UnderAutomation.Staubli.Files.Internal {
	/// <summary>
	/// Upload, download, listing and management of the files of the controller.
	/// With a real controller, the files are accessed through the FTP server of the controller.
	/// With a controller emulated by Staubli Robotics Suite, there is no FTP server: give the path of its .controller file as address. The files are
	/// accessed in the folder of this file, which has the same tree. The paths are the same in both cases (for example "/usr/usrapp/myApp/myApp.pjx").
	/// A path that does not start with "/" is relative to the root of the controller.
	/// The VAL 3 applications are in the folder "/usr/usrapp" of the controller (<see cref="UnderAutomation.Staubli.Files.Internal.FileClientBase.USER_APP_FOLDER"/>): one sub-folder per application,
	/// named as the application, that contains the project file (myApp.pjx) and the other files of the application.
	/// </summary>
	public abstract class FileClientBase {

		/// <summary>
		/// Folder of the VAL 3 applications on the controller. Each application is in a sub-folder named as the application
		/// (for example "/usr/usrapp/myApp/myApp.pjx"). The project path "Disk://myApp/myApp.pjx" of robot.Soap.LoadProject(...) is this file.
		/// </summary>
		public const string USER_APP_FOLDER = "/usr/usrapp";

		/// <summary>
		/// Disconnects the client
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Lists the files and folders of a folder of the controller
		/// </summary>
		/// <param name="path">Path of the folder on the controller (for example "/usr/usrapp")</param>
		/// <returns>The files and folders of the folder</returns>
		public FileItem[] GetListing(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets information about a file or a folder of the controller
		/// </summary>
		/// <param name="path">Path of the file or folder on the controller</param>
		/// <returns>The information, or null when the file or folder does not exist</returns>
		public FileItem GetFileInfo(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks if a file exists on the controller
		/// </summary>
		/// <param name="path">Path of the file on the controller</param>
		/// <returns>True if the file exists</returns>
		public bool FileExists(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks if a folder exists on the controller
		/// </summary>
		/// <param name="path">Path of the folder on the controller</param>
		/// <returns>True if the folder exists</returns>
		public bool DirectoryExists(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a folder on the controller, with its parent folders when they do not exist. Nothing is done when the folder exists.
		/// </summary>
		/// <param name="path">Path of the new folder on the controller</param>
		public void CreateDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes a file of the controller
		/// </summary>
		/// <param name="path">Path of the file on the controller</param>
		public void DeleteFile(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Deletes a folder of the controller and all its content
		/// </summary>
		/// <param name="path">Path of the folder on the controller</param>
		public void DeleteDirectory(string path)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Renames or moves a file or a folder of the controller
		/// </summary>
		/// <param name="path">Path of the file or folder on the controller</param>
		/// <param name="newPath">New path of the file or folder on the controller</param>
		public void Rename(string path, string newPath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Lists the files and folders of a folder of the controller (asynchronous)
		/// </summary>
		/// <param name="path">Path of the folder on the controller (for example "/usr/usrapp")</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The files and folders of the folder</returns>
		public Task<FileItem[]> GetListingAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Gets information about a file or a folder of the controller (asynchronous)
		/// </summary>
		/// <param name="path">Path of the file or folder on the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The information, or null when the file or folder does not exist</returns>
		public Task<FileItem> GetFileInfoAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks if a file exists on the controller (asynchronous)
		/// </summary>
		/// <param name="path">Path of the file on the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True if the file exists</returns>
		public Task<bool> FileExistsAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Checks if a folder exists on the controller (asynchronous)
		/// </summary>
		/// <param name="path">Path of the folder on the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>True if the folder exists</returns>
		public Task<bool> DirectoryExistsAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Creates a folder on the controller, with its parent folders when they do not exist (asynchronous). Nothing is done when the folder exists.
		/// </summary>
		/// <param name="path">Path of the new folder on the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task CreateDirectoryAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deletes a file of the controller (asynchronous)
		/// </summary>
		/// <param name="path">Path of the file on the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task DeleteFileAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Deletes a folder of the controller and all its content (asynchronous)
		/// </summary>
		/// <param name="path">Path of the folder on the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task DeleteDirectoryAsync(string path, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Renames or moves a file or a folder of the controller (asynchronous)
		/// </summary>
		/// <param name="path">Path of the file or folder on the controller</param>
		/// <param name="newPath">New path of the file or folder on the controller</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task RenameAsync(string path, string newPath, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a local file to the controller. The file of the controller is replaced when it exists.
		/// </summary>
		/// <param name="localPath">Path of the file on this computer</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="createRemoteDir">Create the folder of the file on the controller when it does not exist</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		public void UploadFileToController(string localPath, string remotePath, bool createRemoteDir = false, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads data as a file to the controller. The file of the controller is replaced when it exists.
		/// </summary>
		/// <param name="data">Content of the file</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="createRemoteDir">Create the folder of the file on the controller when it does not exist</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		public void UploadBytesToController(byte[] data, string remotePath, bool createRemoteDir = false, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads the content of a stream as a file to the controller, from the current position of the stream to its end. The file of the controller is replaced when it exists.
		/// </summary>
		/// <param name="stream">Stream to read</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="createRemoteDir">Create the folder of the file on the controller when it does not exist</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred, -1 when the length of the stream is not known</param>
		public void UploadStreamToController(Stream stream, string remotePath, bool createRemoteDir = false, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Uploads a local file to the controller (asynchronous). The file of the controller is replaced when it exists.
		/// </summary>
		/// <param name="localPath">Path of the file on this computer</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="createRemoteDir">Create the folder of the file on the controller when it does not exist</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UploadFileToControllerAsync(string localPath, string remotePath, bool createRemoteDir = false, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads data as a file to the controller (asynchronous). The file of the controller is replaced when it exists.
		/// </summary>
		/// <param name="data">Content of the file</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="createRemoteDir">Create the folder of the file on the controller when it does not exist</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UploadBytesToControllerAsync(byte[] data, string remotePath, bool createRemoteDir = false, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads the content of a stream as a file to the controller, from the current position of the stream to its end (asynchronous). The file of the controller is replaced when it exists.
		/// </summary>
		/// <param name="stream">Stream to read</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="createRemoteDir">Create the folder of the file on the controller when it does not exist</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred, -1 when the length of the stream is not known</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task UploadStreamToControllerAsync(Stream stream, string remotePath, bool createRemoteDir = false, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a complete VAL 3 application to the controller. The local folder of the application, named as the application and with its
		/// project file inside (for example C:\MyApps\myApp\myApp.pjx), is copied with its sub-folders to "/usr/usrapp/myApp" (<see cref="UnderAutomation.Staubli.Files.Internal.FileClientBase.USER_APP_FOLDER"/>).
		/// When the application already exists on the controller, its folder is deleted first: the files that are not in the local folder are removed.
		/// Stop and unload the application before (robot.Soap.StopAndUnloadAll()), then load it after (robot.Soap.LoadProject("Disk://myApp/myApp.pjx")).
		/// </summary>
		/// <param name="localAppFolder">Folder of the application on this computer</param>
		/// <param name="progress">Called during the transfer with the percentage of all the files transferred</param>
		/// <returns>Path of the folder of the application on the controller (for example "/usr/usrapp/myApp")</returns>
		public string UploadApplicationToController(string localAppFolder, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Uploads a complete VAL 3 application to the controller (asynchronous). The local folder of the application, named as the application and with its
		/// project file inside (for example C:\MyApps\myApp\myApp.pjx), is copied with its sub-folders to "/usr/usrapp/myApp" (<see cref="UnderAutomation.Staubli.Files.Internal.FileClientBase.USER_APP_FOLDER"/>).
		/// When the application already exists on the controller, its folder is deleted first: the files that are not in the local folder are removed.
		/// Stop and unload the application before (robot.Soap.StopAndUnloadAll()), then load it after (robot.Soap.LoadProject("Disk://myApp/myApp.pjx")).
		/// </summary>
		/// <param name="localAppFolder">Folder of the application on this computer</param>
		/// <param name="progress">Called during the transfer with the percentage of all the files transferred</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>Path of the folder of the application on the controller (for example "/usr/usrapp/myApp")</returns>
		public Task<string> UploadApplicationToControllerAsync(string localAppFolder, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file of the controller to a local file. The local file is replaced when it exists, and its folder is created when it does not exist.
		/// </summary>
		/// <param name="localPath">Path of the file on this computer</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		public void DownloadFileFromController(string localPath, string remotePath, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Downloads a file of the controller and returns its content
		/// </summary>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		/// <returns>The content of the file</returns>
		public byte[] DownloadBytesFromController(string remotePath, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file of the controller and writes its content to a stream
		/// </summary>
		/// <param name="stream">Stream that receives the content of the file</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		public void DownloadStreamFromController(Stream stream, string remotePath, OnProgressDelegate progress = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Downloads a file of the controller to a local file (asynchronous). The local file is replaced when it exists, and its folder is created when it does not exist.
		/// </summary>
		/// <param name="localPath">Path of the file on this computer</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task DownloadFileFromControllerAsync(string localPath, string remotePath, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file of the controller and returns its content (asynchronous)
		/// </summary>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns>The content of the file</returns>
		public Task<byte[]> DownloadBytesFromControllerAsync(string remotePath, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Downloads a file of the controller and writes its content to a stream (asynchronous)
		/// </summary>
		/// <param name="stream">Stream that receives the content of the file</param>
		/// <param name="remotePath">Path of the file on the controller (for example "/usr/usrapp/myApp/myApp.pjx")</param>
		/// <param name="progress">Called during the transfer with the percentage of the file transferred</param>
		/// <param name="cancellationToken">Cancellation token</param>
		public Task DownloadStreamFromControllerAsync(Stream stream, string remotePath, OnProgressDelegate progress = null, CancellationToken cancellationToken = default)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// IP or host name of the controller. Null with an emulated controller.
		/// </summary>
		public string Ip { get; }

		/// <summary>
		/// Port of the FTP server of the controller. 0 with an emulated controller.
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Full path of the .controller file of the controller emulated by Staubli Robotics Suite. Null with a real controller.
		/// </summary>
		public string ControllerFile { get; }

		/// <summary>
		/// Full path of the folder of the .controller file: root of the files of the emulated controller. Null with a real controller.
		/// </summary>
		public string ControllerFolder { get; }

		/// <summary>
		/// True when the files are accessed in the folder of the .controller file of a controller emulated by Staubli Robotics Suite,
		/// false when they are accessed through FTP
		/// </summary>
		public bool IsSimulated { get; }

		/// <summary>
		/// True when the client is connected
		/// </summary>
		public bool Enabled { get; }
	}
}
