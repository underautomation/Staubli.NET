//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Current state and value of a physical I/O.
	/// </summary>
	public class PhysicalIoState {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.PhysicalIoState" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public PhysicalIoState()
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
		/// Definition state of the I/O.
		/// </summary>
		public PhysicalIoEnumState State { get; set; }

		/// <summary>
		/// Indicates whether the I/O is locked.
		/// </summary>
		public bool Locked { get; set; }

		/// <summary>
		/// Indicates whether the I/O is in simulation mode.
		/// </summary>
		public bool Simulated { get; set; }

		/// <summary>
		/// Current numeric value of the I/O.
		/// </summary>
		public double Value { get; set; }

		/// <summary>
		/// I/O type-specific attributes (analog or digital).
		/// </summary>
		public PhysicalIoAttribute Attribute { get; set; }
	}
}
