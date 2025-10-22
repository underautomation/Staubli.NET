//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using System.Runtime.Serialization;

namespace Soap.Errors {
	/// <summary>
	/// Custom exception class for handling SOAP errors with specific error codes and descriptions.
	/// </summary>
	public class CustomSoapException : Exception, ISerializable {

		/// <summary>
		/// The error code text as received from the SOAP response, formatted as a kebab-case string.
		/// </summary>
		public string ErrorCodeText { get; }

		/// <summary>
		/// The error code as an enum value, parsed from the ErrorCodeText.
		/// </summary>
		public SoapErrorCode ErrorCode { get; }

		/// <summary>
		/// A human-readable description of the error, providing additional context about the failure.
		/// </summary>
		public string Description { get; }

		/// <summary>
		/// Gets the error message that describes the current exception.
		/// </summary>
		public override string Message => default;
	}
}
