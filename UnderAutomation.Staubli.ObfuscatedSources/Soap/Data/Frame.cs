//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents a 3D transformation composed of orientation (a 3x3 rotation matrix)
	/// and position (a translation vector) in space.
	/// Used to define the pose of a robot or tool in a 3D environment.
	/// 
	/// Matrix representation:
	/// [ Nx  Ox  Ax  Px ]
	/// [ Ny  Oy  Ay  Py ]
	/// [ Nz  Oz  Az  Pz ]
	/// [  0   0   0   1 ]
	/// </summary>
	public class Frame {

		/// <summary>
		/// Default constructor.
		/// </summary>
		public Frame()
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
		/// X component of the local X-axis vector (Normal X).
		/// </summary>
		public double Nx { get; set; }

		/// <summary>
		/// Y component of the local X-axis vector (Normal Y).
		/// </summary>
		public double Ny { get; set; }

		/// <summary>
		/// Z component of the local X-axis vector (Normal Z).
		/// </summary>
		public double Nz { get; set; }

		/// <summary>
		/// X component of the local Y-axis vector (Orientation X).
		/// </summary>
		public double Ox { get; set; }

		/// <summary>
		/// Y component of the local Y-axis vector (Orientation Y).
		/// </summary>
		public double Oy { get; set; }

		/// <summary>
		/// Z component of the local Y-axis vector (Orientation Z).
		/// </summary>
		public double Oz { get; set; }

		/// <summary>
		/// X component of the local Z-axis vector (Approach X).
		/// </summary>
		public double Ax { get; set; }

		/// <summary>
		/// Y component of the local Z-axis vector (Approach Y).
		/// </summary>
		public double Ay { get; set; }

		/// <summary>
		/// Z component of the local Z-axis vector (Approach Z).
		/// </summary>
		public double Az { get; set; }

		/// <summary>
		/// X coordinate of the frame's origin in global space (Pose X).
		/// </summary>
		public double Px { get; set; }

		/// <summary>
		/// Y coordinate of the frame's origin in global space (Pose Y).
		/// </summary>
		public double Py { get; set; }

		/// <summary>
		/// Z coordinate of the frame's origin in global space (Pose Z).
		/// </summary>
		public double Pz { get; set; }
	}
}
