namespace HetznerClient.Logic.Exceptions;

public partial class Exception : System.Exception {
	private string VerboseMessage { get; set; } = "";

	public override string ToString() {
		var includesStackTrace = true;
		var activeException = this;
		var exceptionStack = new List<Exception>() { activeException };

		do {
			this.VerboseMessage += "\r\n-------------------------------------------------\r\n\r\n";
			this.VerboseMessage += $">>>[{exceptionStack.IndexOf(activeException)}][{activeException.GetType().Name}][Message]:\n\r{activeException.Message}\n\r";

			if (includesStackTrace) {
				this.VerboseMessage += $"\r\n>>>[Stacktrace]:\r\n{this.StackTrace}";
			}
			this.VerboseMessage += "\r\n-------------------------------------------------\r\n\r\n";

			activeException = (Exception)activeException.InnerException!;

			if(activeException is not null) {
				exceptionStack.Add(activeException);
			}
		} while (activeException is not null);

		return VerboseMessage;
	}
}


























