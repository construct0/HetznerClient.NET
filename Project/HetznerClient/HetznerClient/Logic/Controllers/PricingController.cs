using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HetznerClient.Logic.Controllers;
public class PricingController {
	private CloudClient _cloudClient { get; init; }

	public PricingController(CloudClient cloudClient) {
		this._cloudClient = cloudClient;
	}

	//todo
	public void GetAll() {

	}
}
