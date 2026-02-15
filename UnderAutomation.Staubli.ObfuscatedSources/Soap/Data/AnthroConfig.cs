//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Configuration for an anthropomorphic robot (shoulder, elbow, wrist).
	/// </summary>
	public class AnthroConfig {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.AnthroConfig" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public AnthroConfig()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public override string ToString()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override bool Equals(object obj)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		public override int GetHashCode()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Shoulder configuration.
		/// </summary>
		public ShoulderConfig Shoulder { get; set; }

		/// <summary>
		/// Elbow configuration.
		/// </summary>
		public PositiveNegativeConfig Elbow { get; set; }

		/// <summary>
		/// Wrist configuration.
		/// </summary>
		public PositiveNegativeConfig Wrist { get; set; }
	}
}
