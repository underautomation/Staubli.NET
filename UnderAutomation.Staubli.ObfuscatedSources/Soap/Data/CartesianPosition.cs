//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents a Cartesian position with X, Y, Z translation and Rx, Ry, Rz rotation components.
	/// </summary>
	public class CartesianPosition {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.CartesianPosition" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public CartesianPosition()
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
		/// X translation component (m).
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Y translation component (m).
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Z translation component (m).
		/// </summary>
		public double Z { get; set; }

		/// <summary>
		/// Rotation around the X axis (radians).
		/// </summary>
		public double Rx { get; set; }

		/// <summary>
		/// Rotation around the Y axis (radians).
		/// </summary>
		public double Ry { get; set; }

		/// <summary>
		/// Rotation around the Z axis (radians).
		/// </summary>
		public double Rz { get; set; }
	}
}
