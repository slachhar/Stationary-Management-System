using System.Data.Entity;

namespace SMS_Api.Context
{
	public class SMSDBInitializer : DropCreateDatabaseAlways<SMSContext>
	{
	}
}