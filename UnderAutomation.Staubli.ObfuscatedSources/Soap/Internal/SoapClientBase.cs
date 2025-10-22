//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.

using Soap.Data;

namespace Soap.Internal {
	/// <summary>
	/// Base class for SOAP client
	/// </summary>
	public abstract class SoapClientBase {

		/// <summary>
		/// Disconnect SOAP client from robot
		/// </summary>
		public void Disconnect()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Get all the robots handled by this controller
		/// </summary>
		/// <returns>List of all robots</returns>
		public Robot[] GetRobots()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the Cartesian position and joint positions of a robot
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <param name="tool">Tool pose in flange frame. If null, the position of the flange is returned</param>
		/// <param name="frame">Frame in which the Cartesian position of the tool is returned</param>
		/// <returns>Robot joint position and specified tool current cartesian position</returns>
		public CartesianJointPosition GetCurrentCartesianJointPosition(int robot = 0, CartesianPosition tool = null, CartesianPosition frame = null)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the current joint position of a robot
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <returns>Position of each axis in radians</returns>
		public double[] GetCurrentJointPosition(int robot = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the current Cartesian position of a robot end effector
		/// </summary>
		/// <returns>List of parameters</returns>
		public Parameter[] GetControllerParameters()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get all the VAL applications available on the controller
		/// </summary>
		/// <returns>List of all applications</returns>
		public ValApplication[] GetValApplications()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get the range Min-Max of each joint of a robot
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <returns>The range of each axis</returns>
		public JointRange GetJointRange(int robot = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get all the physical I/O values of the controller
		/// </summary>
		/// <returns>Array of physical I/O</returns>
		public PhysicalIo[] GetAllPhysicalIos()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get Robot DH parameters
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <returns>DH parameters</returns>
		public DhParameters[] GetDhParameters(int robot = 0)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Get all the tasks available on the controller
		/// </summary>
		/// <returns>Array of robot task</returns>
		public ControllerTask[] GetTasks()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Read the state of specified physical I/Os
		/// </summary>
		/// <param name="ios">I/O names to read</param>
		/// <returns>Array of physical I/O states</returns>
		public PhysicalIoState[] ReadIos(string[] ios)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Start a VAL application on the controller
		/// </summary>
		/// <param name="applicationPath">Path to the VAL application to start</param>
		public void StartApplication(string applicationPath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stop all VAL applications on the controller
		/// </summary>
		public void StopAndUnloadAll()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Stop application on the controller
		/// </summary>
		public void StopApplication()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Kill a task on the controller
		/// </summary>
		/// <param name="taskName">Name of the task to kill</param>
		public void TaskKill(string taskName, string createdBy)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Resume a task on the controller
		/// </summary>
		/// <param name="taskName">Name of the task to suspend</param>
		public void TaskResume(string taskName, string createdBy)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Suspend a task on the controller
		/// </summary>
		/// <param name="taskName">Name of the task to suspend</param>
		public void TaskSuspend(string taskName, string createdBy)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Write values to specified physical I/Os
		/// </summary>
		/// <param name="ios">I/O names to write</param>
		/// <param name="values">Values to write to the I/Os</param>
		/// <returns>Array of physical I/O write responses</returns>
		public PhysicalIoWriteResponse[] WriteIos(string[] ios, double[] values)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Load a project in memory from disk (does not start it)
		/// </summary>
		/// <param name="projectPath">Path to the project file on the controller</param>
		public void LoadProject(string projectPath)
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Calculate the forward kinematics of a robot based on its joint positions
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <param name="joints">Joint positions in radians</param>
		/// <returns>IForwardKinematics containing the calculated Cartesian position and orientation of the robot end effector</returns>
		public IForwardKinematics ForwardKinematics(int robot, double[] joints)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Calculate the reverse kinematics of a robot to reach a target position and orientation
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <param name="joint">Initial joint positions in radians, used as a starting point for the calculation</param>
		/// <param name="target">Target position and orientation to reach</param>
		/// <param name="config">Configuration for the reverse kinematics calculation, such as orientation constraints</param>
		/// <param name="jointRange">Range of each joint, used to limit the search space for the solution</param>
		/// <returns>IReverseKinematics containing the calculated joint positions to reach the target position and orientation</returns>
		public IReverseKinematics ReverseKinematics(int robot, double[] joint, Frame target, Config config, JointRange jointRange)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Move the robot to a target position using a Cartesian path
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <param name="frameB">Starting position and orientation of the robot end effector</param>
		/// <param name="frameC">Target position and orientation of the robot end effector</param>
		/// <param name="mdesc">Motion description containing parameters such as speed, acceleration, ...</param>
		/// <returns>IMoveResult containing the result of the move operation, such as success status and any errors encountered</returns>
		public IMoveResult MoveC(int robot, Frame frameB, Frame frameC, MotionDesc mdesc)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Move the robot to a target position using a Cartesian path with joint constraints
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <param name="frame">Target position and orientation of the robot end effector</param>
		/// <param name="mdesc">Motion description containing parameters such as speed, acceleration, ...</param>
		/// <returns>IMoveResult containing the result of the move operation, such as success status and any errors encountered</returns>
		public IMoveResult MoveJC(int robot, Frame frame, MotionDesc mdesc)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Move the robot to a target position using joint positions
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <param name="joints">Joint positions in radians to reach the target position</param>
		/// <param name="mdesc">Motion description containing parameters such as speed, acceleration, ...</param>
		/// <returns>IMoveResult containing the result of the move operation, such as success status and any errors encountered</returns>
		public IMoveResult MoveJJ(int robot, double[] joints, MotionDesc mdesc)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Move the robot to a target position using a linear path in Cartesian space
		/// </summary>
		/// <param name="robot">Id of the robot (a controller can handle multiple robots, see method GetRobots()). Use 0 if you only have one robot</param>
		/// <param name="frame">Target position and orientation of the robot end effector</param>
		/// <param name="mdesc">Motion description containing parameters such as speed, acceleration, ...</param>
		/// <returns>IMoveResult containing the result of the move operation, such as success status and any errors encountered</returns>
		public IMoveResult MoveL(int robot, Frame frame, MotionDesc mdesc)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Reset the motion of the robot
		/// </summary>
		/// <returns>MotionReturnCode indicating the result of the reset operation</returns>
		public MotionReturnCode ResetMotion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Restart the motion of the robot
		/// </summary>
		/// <returns>MotionReturnCode indicating the result of the restart operation</returns>
		public MotionReturnCode RestartMotion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Stop the motion of the robot immediately
		/// </summary>
		/// <returns>MotionReturnCode indicating the result of the restart operation</returns>
		public MotionReturnCode StopMotion()
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}

		/// <summary>
		/// Set the power state of the robot (controller mut be in remote mode)
		/// </summary>
		/// <param name="power">true to power on the robot, false to power off</param>
		/// <returns>PowerReturnCode indicating the result of the operation</returns>
		public PowerReturnCode SetPower(bool power)
		{
			// Source is hidden, a Source licence is needed to access internal code...
			return default;
		}


		protected SoapClientBase()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}

		/// <summary>
		/// Connected robot IP address or host name
		/// </summary>
		public string Ip { get; }

		/// <summary>
		/// SOAP TCP port
		/// </summary>
		public int Port { get; }

		/// <summary>
		/// Session ID for the SOAP connection
		/// </summary>
		public int SessionId { get; }

		/// <summary>
		/// Check if the SOAP client is connected to a robot
		/// </summary>
		public bool Enabled { get; }
	}
}
