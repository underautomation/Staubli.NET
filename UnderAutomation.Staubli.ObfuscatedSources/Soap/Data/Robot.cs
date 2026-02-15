//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents a robot managed by the controller.
	/// </summary>
	public class Robot {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.Robot" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public Robot()
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
		/// Kinematic type of the robot.
		/// </summary>
		public Kinematic Kinematic { get; set; }

		/// <summary>
		/// Arm model identifier.
		/// </summary>
		public string Arm { get; set; }

		/// <summary>
		/// Tuning identifier.
		/// </summary>
		public string Tuning { get; set; }

		/// <summary>
		/// Mounting type of the robot (floor, ceiling, wall).
		/// </summary>
		public MountType MountType { get; set; }

		/// <summary>
		/// Length of the third axis.
		/// </summary>
		public LengthAxis3 LengthAxis3 { get; set; }

		/// <summary>
		/// Diameter of the third axis.
		/// </summary>
		public DiameterAxis3 DiameterAxis3 { get; set; }
	}
}
