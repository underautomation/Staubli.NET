//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal.V3 {
	/// <summary>
	/// SOAP response containing the forward kinematics result.
	/// </summary>
	public class ForwardKinResponse : IForwardKinematics {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Internal.V3.ForwardKinResponse" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ForwardKinResponse()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Initializes a new instance with the specified position and configuration.
		/// </summary>
		/// <param name="position">Cartesian position.</param>
		/// <param name="config">Robot configuration.</param>
		public ForwardKinResponse(Frame position, Config config)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Cartesian position resulting from forward kinematics.
		/// </summary>
		public Frame Position { get; set; }

		/// <summary>
		/// Robot configuration at the computed position.
		/// </summary>
		public Config Config { get; set; }
	}
}
