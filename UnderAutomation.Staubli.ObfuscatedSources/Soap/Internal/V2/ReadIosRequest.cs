//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Internal.V2 {
	/// <summary>
	/// SOAP request to read the state of specified physical I/Os.
	/// </summary>
	public class ReadIosRequest {

		/// <summary>
		/// Array of physical I/O paths to read.
		/// </summary>
		public string[] ios;

		/// <summary>
		/// Whether to include I/O descriptions in the response.
		/// </summary>
		public bool xgetDescription;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V2.ReadIosRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ReadIosRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified I/O paths and description flag.
		/// </summary>
		/// <param name="ios">Array of physical I/O paths to read.</param>
		/// <param name="xgetDescription">Whether to include I/O descriptions in the response.</param>
		public ReadIosRequest(string[] ios, bool xgetDescription)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
