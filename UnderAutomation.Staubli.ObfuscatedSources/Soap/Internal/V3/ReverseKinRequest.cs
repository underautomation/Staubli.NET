//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP request to compute reverse (inverse) kinematics for a robot.
	/// </summary>
	public class ReverseKinRequest {

		/// <summary>
		/// Robot identifier.
		/// </summary>
		public int robot;

		/// <summary>
		/// Initial joint positions in radians.
		/// </summary>
		public double[] jointIn;

		/// <summary>
		/// Target Cartesian frame.
		/// </summary>
		public Frame target;

		/// <summary>
		/// Robot configuration.
		/// </summary>
		public Config config;

		/// <summary>
		/// Allowed joint range limits.
		/// </summary>
		public JointRange jointRange;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.ReverseKinRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ReverseKinRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified parameters.
		/// </summary>
		/// <param name="robot">Robot identifier.</param>
		/// <param name="jointIn">Initial joint positions in radians.</param>
		/// <param name="target">Target Cartesian frame.</param>
		/// <param name="config">Robot configuration.</param>
		/// <param name="jointRange">Allowed joint range limits.</param>
		public ReverseKinRequest(int robot, double[] jointIn, Frame target, Config config, JointRange jointRange)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
