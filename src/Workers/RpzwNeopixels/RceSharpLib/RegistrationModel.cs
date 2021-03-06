﻿using System.Collections.Generic;

namespace RceSharpLib
{
	public class RegistrationModel
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public string Base64Logo { get; set; }
		public List<JobDescription> JobDescriptions { get; set; }
		public List<string> Owners { get; set; }
	}
}
