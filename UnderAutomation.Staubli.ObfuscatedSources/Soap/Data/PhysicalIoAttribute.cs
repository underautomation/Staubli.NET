//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Physical I/O attribute containing either analog or digital specific attributes.
	/// </summary>
	public class PhysicalIoAttribute {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.PhysicalIoAttribute" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public PhysicalIoAttribute()
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
		/// Analog I/O specific attributes (null if digital).
		/// </summary>
		public PhysicalAioAttribute AioAttribute { get; set; }

		/// <summary>
		/// Digital I/O specific attributes (null if analog).
		/// </summary>
		public PhysicalDioAttribute DioAttribute { get; set; }
	}
}
