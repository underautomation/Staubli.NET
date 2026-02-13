//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {

	public class MotionDesc {


		public MotionDesc()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Defines the pose of the robot's tool center point (TCP) in flange, including both position and orientation.
		/// </summary>
		public Frame Tool { get; set; }

		/// <summary>
		/// Defines the frame in which the tool position is located, including both position and orientation.
		/// </summary>
		public Frame Frame { get; set; }

		/// <summary>
		/// Specifies whether the motion is defined in absolute or relative terms.
		/// </summary>
		public MoveType AbsRel { get; set; }

		/// <summary>
		/// Contains additional configuration parameters specific to the robot type, such as anthropomorphic, SCARA, or VRBX configurations.
		/// </summary>
		public Config Config { get; set; }

		/// <summary>
		/// Specifies the type of blending to be applied when transitioning between motion segments.
		/// </summary>
		public BlendType BlendType { get; set; }

		/// <summary>
		/// In the joint and Cartesian blending modes, the distance between the target point where blending begins and the next point, in millimeters or inches, depending on the length unit used in the application.
		/// </summary>
		public double DistanceBlendPrevious { get; set; }

		/// <summary>
		/// In joint and Cartesian blending modes, the distance between the target point where blending ends and the next point, in millimeters or inches, depending on the length unit of the application.
		/// </summary>
		public double DistanceBlendNext { get; set; }

		/// <summary>
		/// Maximum allowable joint speed, as a percentage of the robot's nominal speed.
		/// </summary>
		public double Velocity { get; set; }

		/// <summary>
		/// Maximum allowed joint acceleration, as a percentage of the robot's nominal acceleration.
		/// </summary>
		public double Acceleration { get; set; }

		/// <summary>
		/// Maximum allowed joint deceleration, as a percentage of the robot's nominal deceleration.
		/// </summary>
		public double Deceleration { get; set; }

		/// <summary>
		/// Maximum allowed feed rate of the tool center, in mm/s or inches/s depending on the length unit of the application.
		/// </summary>
		public double TranslationVelocity { get; set; }

		/// <summary>
		/// Maximum permitted tool rotation speed, in degrees per second.
		/// </summary>
		public double RotationVelocity { get; set; }

		/// <summary>
		/// Frequency of motion in Hz.
		/// </summary>
		public double Frequency { get; set; }
	}
}
