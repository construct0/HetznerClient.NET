using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetznerClient.Logic.Controllers;
public class LoadBalancerTypeController {
	private CloudClient _cloudClient { get; init; }

	public LoadBalancerTypeController(CloudClient cloudClient) {
		this._cloudClient = cloudClient;
	}

	//todo
	public void GetAll() {

	}

	//todo
	public void Get() {

	}
}
