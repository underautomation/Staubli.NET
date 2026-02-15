//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Robot configuration containing kinematic-specific settings.
	/// </summary>
	public class Config {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.Config" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public Config()
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
		/// Anthropomorphic robot configuration.
		/// </summary>
		public AnthroConfig AnthroConfig { get; set; }

		/// <summary>
		/// SCARA robot configuration.
		/// </summary>
		public ScaraConfig ScaraConfig { get; set; }

		/// <summary>
		/// VRBX robot configuration.
		/// </summary>
		public VrbxConfig VrbxConfig { get; set; }
	}
}
