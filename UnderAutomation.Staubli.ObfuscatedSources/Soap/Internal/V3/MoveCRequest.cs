//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP request for a circular motion command.
	/// </summary>
	public class MoveCRequest {

		/// <summary>
		/// Robot identifier.
		/// </summary>
		public int robot;

		/// <summary>
		/// Intermediate waypoint frame.
		/// </summary>
		public Frame frameB;

		/// <summary>
		/// Target frame.
		/// </summary>
		public Frame frameC;

		/// <summary>
		/// Motion description parameters.
		/// </summary>
		public MotionDesc mdesc;

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.MoveCRequest" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public MoveCRequest()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified parameters.
		/// </summary>
		/// <param name="robot">Robot identifier.</param>
		/// <param name="frameB">Intermediate waypoint frame.</param>
		/// <param name="frameC">Target frame.</param>
		/// <param name="mdesc">Motion description.</param>
		public MoveCRequest(int robot, Frame frameB, Frame frameC, MotionDesc mdesc)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}
	}
}
