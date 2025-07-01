//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {

	public class MotionDesc {


		public MotionDesc()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public Frame Tool { get; set; }


		public Frame Frame { get; set; }


		public MoveType AbsRel { get; set; }


		public Config Config { get; set; }


		public BlendType BlendType { get; set; }


		public double DistanceBlendPrevious { get; set; }


		public double DistanceBlendNext { get; set; }


		public double Velocity { get; set; }


		public double Acceleration { get; set; }


		public double Deceleration { get; set; }


		public double TranslationVelocity { get; set; }


		public double RotationVelocity { get; set; }


		public double Frequency { get; set; }
	}
}
