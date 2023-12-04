using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetznerClient.Logic.Controllers;
public class DatacenterController {
	private CloudClient _cloudClient { get; init; }

	public DatacenterController(CloudClient cloudClient) {
		this._cloudClient = cloudClient;
	}

	// todo
	public void GetAllDatacenters() {

	}

	//todo
	public void GetDatacenter() {

	}
}
