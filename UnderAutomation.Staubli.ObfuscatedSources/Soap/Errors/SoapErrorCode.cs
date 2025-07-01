//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Errors {

	public enum SoapErrorCode {


		Unknown = -1,


		InvalidCredentials = 0,


		TaskNotFound = 1,


		MismatchedCode = 2,


		ProgramNotFound = 3,


		TaskAlreadyLocked = 4,


		SinReturnCodeNok = 5,


		SchedulingModeError = 6,


		ApplicationNotFound = 7,


		StackFrameNotFound = 8,


		ProgramLineNotFound = 9,


		ReadAccessErrorCode = 10,


		SetPosNotSimulCode = 11,


		InvalidSessionIdCode = 12,


		WriteAccessErrorCode = 13,


		CannotStartApplication = 14,


		ClientAlreadyConnected = 15,


		IoWriteAccessErrorCode = 16,


		ClientCommunicationError = 17,


		IoWriteAccessErrorValidation = 18,


		IoWriteAccessErrorWorkingMode = 19,


		InvalidRobotIdCode = 20,
	}
}
