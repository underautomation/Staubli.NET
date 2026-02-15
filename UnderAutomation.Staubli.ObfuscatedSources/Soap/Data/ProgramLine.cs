//              WARNING
// This file is an empty shell containing only public C# items.
// The internal code is hidden; to access it, you need to obtain a Source licence of the library.


namespace Soap.Data {
	/// <summary>
	/// Represents a line of a VAL3 program being executed on the controller.
	/// </summary>
	public class ProgramLine {

		/// <summary>
		/// Initializes a new instance of the <xref href="UnderAutomation.Staubli.Soap.Data.ProgramLine" data-throw-if-not-resolved="false"></xref> class.
		/// </summary>
		public ProgramLine()
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
		/// Name of the application containing the program.
		/// </summary>
		public string ApplicationName { get; set; }

		/// <summary>
		/// Name of the program.
		/// </summary>
		public string ProgramName { get; set; }

		/// <summary>
		/// Line number currently being executed.
		/// </summary>
		public int LineNumber { get; set; }

		/// <summary>
		/// Content of the line being executed.
		/// </summary>
		public string LineContent { get; set; }
	}
}
