//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Denavit-Hartenberg parameters for a single robot joint.
	/// </summary>
	public class DhParameters {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.DhParameters" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public DhParameters()
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
		/// Joint angle theta (radians).
		/// </summary>
		public double Theta { get; set; }

		/// <summary>
		/// Link offset d (m).
		/// </summary>
		public double D { get; set; }

		/// <summary>
		/// Link length a (m).
		/// </summary>
		public double A { get; set; }

		/// <summary>
		/// Link twist alpha (radians).
		/// </summary>
		public double Alpha { get; set; }

		/// <summary>
		/// Joint twist beta (radians).
		/// </summary>
		public double Beta { get; set; }
	}
}
