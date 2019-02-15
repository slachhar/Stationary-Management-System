using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SMS_Api.Context
{
	public class SMSContext: DbContext
	{
		public SMSContext() : base("SMSDB")
		{
			Database.SetInitializer<SMSContext>(new SMSDBInitializer());
		}
	}
}