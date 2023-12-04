using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetznerClient.Logic.Controllers;

public class QueryParametersSpecification {
	public Dictionary<string, string> Parameters { get; init; }

	public QueryParametersSpecification() {
		Parameters = new() { };
		Parameters.Add("page", "1");
		Parameters.Add("per_page", "50");
	}
}

public class CertificateController {
	private CloudClient _cloudClient { get; init; }

	public CertificateController(CloudClient cloudClient) {
		this._cloudClient = cloudClient;
	}

	//todo
	public void GetAll() {

	}

	//todo
	public void Get() {

	}

	//todo
	public void Create() {

	}

	//todo
	public void Update() {

	}

	//todo
	public void Delete() {

	}

	//todo
	public void GetActions() {

	}

	//todo
	public void GetAction() {

	}

	//todo
	public void RetryIssuanceOrRenewal() {

	}
}
