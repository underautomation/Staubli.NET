//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP request to compute forward kinematics for a robot.
	/// </summary>
	public class ForwardKinRequest {

		/// <summary>
		/// Robot identifier.
		/// </summary>
		public int robot;

		/// <summary>
		/// Joint positions in radians.
		/// </summary>
		public double[] joint;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.ForwardKinRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ForwardKinRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified robot and joint positions.
		/// </summary>
		/// <param name="robot">Robot identifier.</param>
		/// <param name="joint">Joint positions in radians.</param>
		public ForwardKinRequest(int robot, double[] joint)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
