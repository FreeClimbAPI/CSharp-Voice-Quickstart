using Microsoft.AspNetCore.Mvc;
using com.freeclimb.percl;

namespace VoiceQuickstart.Controllers;

[ApiController]
[Route("[controller]")]
public class IncomingCallController : ControllerBase
{

    private readonly ILogger<IncomingCallController> _logger;

    public IncomingCallController(ILogger<IncomingCallController> logger)
    {
        _logger = logger;
    }

    [HttpPost(Name = "PostIncomingCall")]
    public string Post()
    {
        // Create PerCL Script
        PerCLScript HelloWorldScript = new PerCLScript();

        // Create Say Command
        Say SayHelloWorld = new Say();
        SayHelloWorld.setText("Hello, World!");

        // Add Command to PerCL Script
        HelloWorldScript.Add(SayHelloWorld);

        // Respond to FreeClimb with PerCL Script
        return HelloWorldScript.toJson();
    }
}


