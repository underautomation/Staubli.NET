//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP request for a linear motion command.
	/// </summary>
	public class MoveLRequest {

		/// <summary>
		/// Robot identifier.
		/// </summary>
		public int robot;

		/// <summary>
		/// Target Cartesian frame.
		/// </summary>
		public Frame frame;

		/// <summary>
		/// Motion description parameters.
		/// </summary>
		public MotionDesc mdesc;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.MoveLRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public MoveLRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified parameters.
		/// </summary>
		/// <param name="robot">Robot identifier.</param>
		/// <param name="frame">Target Cartesian frame.</param>
		/// <param name="mdesc">Motion description.</param>
		public MoveLRequest(int robot, Frame frame, MotionDesc mdesc)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
