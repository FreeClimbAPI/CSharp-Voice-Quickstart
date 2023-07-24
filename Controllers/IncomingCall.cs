using Microsoft.AspNetCore.Mvc;
using freeclimb.Model;

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
        PerclScript HelloWorldScript = new PerclScript(new List<PerclCommand>());

        // Create Say Command
        Say SayHelloWorld = new Say("Hello, World!");
        Console.WriteLine(SayHelloWorld.ToJson());
        // Add Command to PerCL Script
        HelloWorldScript.Commands.Add(SayHelloWorld);
        Console.WriteLine(HelloWorldScript.ToJson());

        // Respond to FreeClimb with PerCL Script
        return HelloWorldScript.ToJson();
    }
}


