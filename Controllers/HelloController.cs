using Microsoft.AspNetCore.Mvc;
using com.freeclimb.percl;
using com.freeclimb.webhooks.call;


namespace GettingStarted.Controllers
{
    [Route("voice/")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // POST voice/
        [HttpPost]
        public string Post(CallStatusCallback request)
        {
          // Create a PerCl script
          PerCLScript helloScript = new PerCLScript();

          // Create a Say Command
          Say sayHello = new Say();
          sayHello.setText("Hello, FreeClimb!");

          // Add the command
          helloScript.Add(sayHello);

          // Respond to FreeClimb with your script
          return helloScript.toJson();
        }
    }
}
