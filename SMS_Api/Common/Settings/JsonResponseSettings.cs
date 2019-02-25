using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace SMS_Api.Common.Settings
{
	public static class JsonResponseSettings
	{
		public static JsonSerializerSettings SetJsonSerializerSettings()
		{
			var settings = new JsonSerializerSettings();
			settings.NullValueHandling = NullValueHandling.Ignore;
			return settings;
		}
	}
}