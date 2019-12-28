using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace twilio.Controllers
{
    public class smsController : Controller
    {
        //
        // GET: /sms/
        public ActionResult sms()
        {
            var sid = "<TWILLIO SID>";
            var token = "<TWILLIO TOKEEN>";
            TwilioClient.Init(sid, token);
            var to = new PhoneNumber("<TO NUMBER>");
            var from = new PhoneNumber("<FROM NUMBER PROVIDED BY TWILLIO>");
            var message = MessageResource.Create(
                to: to,
                from: from,
                // body: "\n hi \n hello abc \n hi"
                body: "this is a test message from HAMZA ASIF"
                );
            return Content(message.Sid);

        }
	}
}