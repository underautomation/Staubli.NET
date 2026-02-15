//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Errors {
	/// <summary>
	/// Error codes that can occur when starting an application on the controller.
	/// </summary>
	public enum StartApplicationError {

		/// <summary>
		/// Not enough memory to start the application.
		/// </summary>
		MemoryFull = 0,

		/// <summary>
		/// The library is currently busy.
		/// </summary>
		LibraryBusy = 1,

		/// <summary>
		/// The library ZIP file is invalid.
		/// </summary>
		LibraryInvalidZip = 2,

		/// <summary>
		/// The required data was not found.
		/// </summary>
		DataNotFound = 3,

		/// <summary>
		/// The data is currently busy.
		/// </summary>
		DataBusy = 4,

		/// <summary>
		/// The data name is invalid.
		/// </summary>
		DataInvalidName = 5,

		/// <summary>
		/// The data already exists.
		/// </summary>
		DataAlreadyExists = 6,

		/// <summary>
		/// The data size is invalid.
		/// </summary>
		DataInvalidSize = 7,

		/// <summary>
		/// The data is not an array.
		/// </summary>
		DataNotAnArray = 8,

		/// <summary>
		/// The routine name is invalid.
		/// </summary>
		RoutineInvalidName = 9,

		/// <summary>
		/// The routine already exists.
		/// </summary>
		RoutineAlreadyExists = 10,

		/// <summary>
		/// The routine name is too long.
		/// </summary>
		RoutineNameTooLong = 11,

		/// <summary>
		/// The routine parameter position is invalid.
		/// </summary>
		RoutineInvalidParamPosition = 12,

		/// <summary>
		/// The routine was not found.
		/// </summary>
		RoutineNotFound = 13,

		/// <summary>
		/// The routine is currently busy.
		/// </summary>
		RoutineBusy = 14,

		/// <summary>
		/// The project is currently busy.
		/// </summary>
		ProjectBusy = 15,

		/// <summary>
		/// The project name is invalid.
		/// </summary>
		ProjectInvalidName = 16,

		/// <summary>
		/// The project alias is invalid.
		/// </summary>
		ProjectInvalidAlias = 17,

		/// <summary>
		/// The project alias is already in use.
		/// </summary>
		ProjectAliasAlreadyUsed = 18,

		/// <summary>
		/// The project already exists.
		/// </summary>
		ProjectAlreadyExists = 19,

		/// <summary>
		/// A code error occurred in the project.
		/// </summary>
		ProjectCodeError = 20,

		/// <summary>
		/// A data error occurred in the project.
		/// </summary>
		ProjectDataError = 21,

		/// <summary>
		/// The start routine was not found.
		/// </summary>
		StartRoutineNotFound = 22,

		/// <summary>
		/// The project main entry point is invalid.
		/// </summary>
		ProjectInvalidMain = 23,

		/// <summary>
		/// The project is invalid.
		/// </summary>
		ProjectInvalidProject = 24,

		/// <summary>
		/// The stop routine was not found.
		/// </summary>
		StopRoutineNotFound = 25,

		/// <summary>
		/// The project destructor is invalid.
		/// </summary>
		ProjectInvalidDestructor = 26,

		/// <summary>
		/// The default stack size is too small.
		/// </summary>
		ProjectDefaultStackTooSmall = 27,

		/// <summary>
		/// The project is already running.
		/// </summary>
		ProjectAlreadyRunning = 28,

		/// <summary>
		/// The project is already ending.
		/// </summary>
		ProjectAlreadyEnding = 29,

		/// <summary>
		/// The project is locked.
		/// </summary>
		ProjectLocked = 30,

		/// <summary>
		/// A file error occurred in the project.
		/// </summary>
		ProjectFileError = 31,

		/// <summary>
		/// The file manager was not found.
		/// </summary>
		ProjectFilemanagerNotFound = 32,

		/// <summary>
		/// A library error occurred in the project.
		/// </summary>
		ProjectLibraryError = 33,

		/// <summary>
		/// An unresolved symbol was found in the project.
		/// </summary>
		ProjectUnresolvedSymbol = 34,

		/// <summary>
		/// An inconsistent resolved symbol was found.
		/// </summary>
		ProjectInconsistantResolvedSymbol = 35,

		/// <summary>
		/// An interface is still in use.
		/// </summary>
		ProjectInterfaceStillUsed = 36,

		/// <summary>
		/// The project is used as a struct.
		/// </summary>
		ProjectUsedAsStruct = 37,

		/// <summary>
		/// An interface task has not been killed.
		/// </summary>
		ProjectInterfaceTaskNotKilled = 38,

		/// <summary>
		/// The type name is invalid.
		/// </summary>
		ProjectInvalidTypename = 39,

		/// <summary>
		/// The type name is already in use.
		/// </summary>
		ProjectTypenameAlreadyUsed = 40,

		/// <summary>
		/// A type project error occurred.
		/// </summary>
		ProjectTypeProjectError = 41,

		/// <summary>
		/// The type is currently busy.
		/// </summary>
		ProjectTypeBusy = 42,

		/// <summary>
		/// A circular reference was detected in the project.
		/// </summary>
		ProjectCircularReference = 43,
	}
}
