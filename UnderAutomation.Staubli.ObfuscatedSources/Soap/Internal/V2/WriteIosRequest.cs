//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Internal.V2 {
	/// <summary>
	/// SOAP request to write values to specified physical I/Os.
	/// </summary>
	public class WriteIosRequest {

		/// <summary>
		/// Array of physical I/O paths to write.
		/// </summary>
		public string[] ios;

		/// <summary>
		/// Array of values to write to the I/Os.
		/// </summary>
		public double[] values;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V2.WriteIosRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public WriteIosRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified I/O paths and values.
		/// </summary>
		/// <param name="ios">Array of physical I/O paths to write.</param>
		/// <param name="values">Array of values to write.</param>
		public WriteIosRequest(string[] ios, double[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
