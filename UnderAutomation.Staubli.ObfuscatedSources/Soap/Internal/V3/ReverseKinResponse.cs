//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP response containing the reverse kinematics result.
	/// </summary>
	public class ReverseKinResponse : IReverseKinematics {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.ReverseKinResponse" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ReverseKinResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified joint positions and result.
		/// </summary>
		/// <param name="jointOut">Computed joint positions in radians.</param>
		/// <param name="reversingResult">Result code of the reverse kinematics computation.</param>
		public ReverseKinResponse(double[] jointOut, ReversingResult reversingResult)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Computed joint positions in radians.
		/// </summary>
		public double[] Joint { get; set; }

		/// <summary>
		/// Result code of the reverse kinematics computation.
		/// </summary>
		public ReversingResult Result { get; set; }
	}
}
