﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Scheduler.NET.Core.JobManager;
using Scheduler.NET.Core.JobManager.Job;

namespace Scheduler.NET.Core.Controllers.V1
{
	[Route("api/v1.0/[controller]")]
	public class CallbackJobController : BaseController<CallbackJob>
	{
		public CallbackJobController(IJobManager<CallbackJob> jobManager, ILoggerFactory loggerFactory, ISchedulerOptions configuration) : base(jobManager, loggerFactory, configuration)
		{
		}
	}
}
