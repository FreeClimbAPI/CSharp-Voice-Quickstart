using Microsoft.AspNetCore.Mvc;
using com.persephony.api;
using com.persephony.percl;
using com.persephony;
using com.persephony.webhooks;

namespace GettingStarted.Controllers
{
    [Route("voice/")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        // POST voice/
        [HttpPost]
        public string Post(PersyRequest request)
        {
          // Create a PerCl script
          PerCLScript helloScript = new PerCLScript();

          // Create a Say Command
          Say sayHello = new Say();
          sayHello.setText("Hello, Persephony!");
          sayHello.setLanguage(com.persephony.ELanguage.EnglishUS);

          // Add the command
          helloScript.Add(sayHello);

          // Respon to Persephony with your script
          return helloScript.toJson();
        }
    }
}
