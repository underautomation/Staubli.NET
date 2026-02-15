//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Configuration for a VRBX-type robot.
	/// </summary>
	public class VrbxConfig {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.VrbxConfig" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public VrbxConfig()
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
		/// Joint 1 above/below configuration.
		/// </summary>
		public AboveBelowConfig Joint1 { get; set; }

		/// <summary>
		/// Joint 3 positive/negative configuration.
		/// </summary>
		public PositiveNegativeConfig Joint3 { get; set; }

		/// <summary>
		/// Joint 5 positive/negative configuration.
		/// </summary>
		public PositiveNegativeConfig Joint5 { get; set; }
	}
}
