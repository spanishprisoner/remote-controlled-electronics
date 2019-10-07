﻿using System;
using Newtonsoft.Json.Linq;

namespace RceServer.Domain.Models.Messages
{
	public class CompleteJobMessage : MessageBase, IRceMessage, IHasWorkerId
	{
		public Guid JobId { get; set; }
		public Guid WorkerId { get; set; }
		public JObject Status { get; set; }
	}
}
