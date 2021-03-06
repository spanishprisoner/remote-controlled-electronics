﻿using Newtonsoft.Json.Linq;
using System;

namespace RceSharpLib
{
	public class Job
	{
		public Guid WorkerId { get; set; }
		public Guid JobId { get; set; }
		public string JobName { get; set; }
		public JObject Payload { get; set; }
	}
}
