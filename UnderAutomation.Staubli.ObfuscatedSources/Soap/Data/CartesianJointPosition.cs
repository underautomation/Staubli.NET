//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents the joint positions and the Cartesian position of a robot end effector.
	/// </summary>
	public class CartesianJointPosition {


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


		public CartesianJointPosition()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// The joint positions in radians.
		/// </summary>
		public double[] JointsPosition { get; set; }

		/// <summary>
		/// The Cartesian position of the robot end effector.
		/// </summary>
		public CartesianPosition CartesianPosition { get; set; }
	}
}
