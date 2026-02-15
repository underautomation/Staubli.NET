//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V0 {
	/// <summary>
	/// SOAP request to retrieve a robot's joint and Cartesian positions.
	/// </summary>
	public class GetRobotJntCartPosRequest {

		/// <summary>
		/// Robot identifier.
		/// </summary>
		public int robot;

		/// <summary>
		/// Tool pose in flange frame.
		/// </summary>
		public CartesianPosition tool;

		/// <summary>
		/// Reference frame for the Cartesian position.
		/// </summary>
		public CartesianPosition frame;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V0.GetRobotJntCartPosRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public GetRobotJntCartPosRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified robot, tool and frame.
		/// </summary>
		/// <param name="robot">Robot identifier.</param>
		/// <param name="tool">Tool pose in flange frame.</param>
		/// <param name="frame">Reference frame for the Cartesian position.</param>
		public GetRobotJntCartPosRequest(int robot, CartesianPosition tool, CartesianPosition frame)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
