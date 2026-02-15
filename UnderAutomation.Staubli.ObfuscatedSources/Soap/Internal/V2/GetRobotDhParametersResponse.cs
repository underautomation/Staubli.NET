//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V2 {
	/// <summary>
	/// SOAP response containing the robot's Denavit-Hartenberg parameters.
	/// </summary>
	public class GetRobotDhParametersResponse {

		/// <summary>
		/// Array of Denavit-Hartenberg parameters for each joint.
		/// </summary>
		public DhParameters[] dhParametersArray;

		/// <summary>
		/// Last D parameter value.
		/// </summary>
		public double lastDParam;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V2.GetRobotDhParametersResponse" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public GetRobotDhParametersResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified DH parameters.
		/// </summary>
		/// <param name="dhParametersArray">Array of DH parameters per joint.</param>
		/// <param name="lastDParam">Last D parameter value.</param>
		public GetRobotDhParametersResponse(DhParameters[] dhParametersArray, double lastDParam)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
