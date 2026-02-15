//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Blend mode used during motion transitions between segments.
	/// </summary>
	public enum BlendType {

		/// <summary>
		/// No blending; the robot stops at each target point.
		/// </summary>
		BlendOff = 0,

		/// <summary>
		/// Joint-space blending between motion segments.
		/// </summary>
		BlendJoint = 1,

		/// <summary>
		/// Cartesian-space blending between motion segments.
		/// </summary>
		BlendCartesian = 2,
	}
}
