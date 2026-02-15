//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP request for a joint-to-joint motion command.
	/// </summary>
	public class MoveJJRequest {

		/// <summary>
		/// Robot identifier.
		/// </summary>
		public int robot;

		/// <summary>
		/// Target joint positions in radians.
		/// </summary>
		public double[] joint;

		/// <summary>
		/// Motion description parameters.
		/// </summary>
		public MotionDesc mdesc;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.MoveJJRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public MoveJJRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified parameters.
		/// </summary>
		/// <param name="robot">Robot identifier.</param>
		/// <param name="joint">Target joint positions in radians.</param>
		/// <param name="mdesc">Motion description.</param>
		public MoveJJRequest(int robot, double[] joint, MotionDesc mdesc)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
