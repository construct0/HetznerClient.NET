using HetznerClient;

namespace HetznerConsole;

internal class Program {
	static void Main(string[] args) {
		// Bearer tokens are distributed on a per-project basis
		var cloudClient = new CloudClient(
			new CloudConfig("9cMmMenuxBVuiENTUP7d9iLDo6L5V0HBRqUavuOLDZSK0RDmVrSWIw3ntCaFHlfl")
		);

		var existingCertificates = cloudClient.Certificate.GetAll();
	}
}