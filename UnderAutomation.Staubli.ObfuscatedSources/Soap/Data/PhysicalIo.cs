//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents a physical I/O on the robot.
	/// </summary>
	public class PhysicalIo {


		public PhysicalIo()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Name of the physical I/O.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Description of the physical I/O.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Type of the physical I/O (e.g., din, dout, ain, serial, ...).
		/// </summary>
		public string TypeStr { get; set; }

		/// <summary>
		/// Indicates whether the physical I/O is lockable.
		/// </summary>
		public bool Lockable { get; set; }
	}
}
