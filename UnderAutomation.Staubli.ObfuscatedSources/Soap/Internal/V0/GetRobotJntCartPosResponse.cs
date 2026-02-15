//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V0 {
	/// <summary>
	/// SOAP response containing the robot's joint and Cartesian positions.
	/// </summary>
	public class GetRobotJntCartPosResponse {

		/// <summary>
		/// Joint positions in radians.
		/// </summary>
		public double[] jntPos;

		/// <summary>
		/// Cartesian position of the tool.
		/// </summary>
		public CartesianPosition cartPos;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V0.GetRobotJntCartPosResponse" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public GetRobotJntCartPosResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified joint and Cartesian positions.
		/// </summary>
		/// <param name="jntPos">Joint positions in radians.</param>
		/// <param name="cartPos">Cartesian position of the tool.</param>
		public GetRobotJntCartPosResponse(double[] jntPos, CartesianPosition cartPos)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
