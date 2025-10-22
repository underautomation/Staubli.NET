//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {

	public class ControllerTask {


		public ControllerTask()
		{
			// Source is hidden, a Source licence is needed to access internal code...
		}


		public string Name { get; set; }


		public ControllerTaskState State { get; set; }


		public int Priority { get; set; }


		public string CreatedBy { get; set; }


		public int RuntimeError { get; set; }


		public string RuntimeErrorDescription { get; set; }


		public ProgramLine ProgramLine { get; set; }
	}
}
