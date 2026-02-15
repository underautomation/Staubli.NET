//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Errors {
	/// <summary>
	/// Error codes returned by the SOAP service.
	/// </summary>
	public enum SoapErrorCode {

		/// <summary>
		/// Unknown or unrecognized error code.
		/// </summary>
		Unknown = -1,

		/// <summary>
		/// The provided credentials are invalid.
		/// </summary>
		InvalidCredentials = 0,

		/// <summary>
		/// The specified task was not found.
		/// </summary>
		TaskNotFound = 1,

		/// <summary>
		/// Mismatched code error.
		/// </summary>
		MismatchedCode = 2,

		/// <summary>
		/// The specified program was not found.
		/// </summary>
		ProgramNotFound = 3,

		/// <summary>
		/// The task is already locked by another client.
		/// </summary>
		TaskAlreadyLocked = 4,

		/// <summary>
		/// SIN return code indicates failure.
		/// </summary>
		SinReturnCodeNok = 5,

		/// <summary>
		/// Scheduling mode error.
		/// </summary>
		SchedulingModeError = 6,

		/// <summary>
		/// The specified application was not found.
		/// </summary>
		ApplicationNotFound = 7,

		/// <summary>
		/// The specified stack frame was not found.
		/// </summary>
		StackFrameNotFound = 8,

		/// <summary>
		/// The specified program line was not found.
		/// </summary>
		ProgramLineNotFound = 9,

		/// <summary>
		/// Read access error.
		/// </summary>
		ReadAccessErrorCode = 10,

		/// <summary>
		/// Cannot set position outside simulation mode.
		/// </summary>
		SetPosNotSimulCode = 11,

		/// <summary>
		/// The session ID is invalid or expired.
		/// </summary>
		InvalidSessionIdCode = 12,

		/// <summary>
		/// Write access error.
		/// </summary>
		WriteAccessErrorCode = 13,

		/// <summary>
		/// Cannot start the application.
		/// </summary>
		CannotStartApplication = 14,

		/// <summary>
		/// A client is already connected.
		/// </summary>
		ClientAlreadyConnected = 15,

		/// <summary>
		/// I/O write access error.
		/// </summary>
		IoWriteAccessErrorCode = 16,

		/// <summary>
		/// Client communication error.
		/// </summary>
		ClientCommunicationError = 17,

		/// <summary>
		/// I/O write access validation error.
		/// </summary>
		IoWriteAccessErrorValidation = 18,

		/// <summary>
		/// I/O write access error due to working mode.
		/// </summary>
		IoWriteAccessErrorWorkingMode = 19,

		/// <summary>
		/// The specified robot ID is invalid.
		/// </summary>
		InvalidRobotIdCode = 20,
	}
}
