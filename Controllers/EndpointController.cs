using Microsoft.AspNetCore.Mvc;

namespace RodriguezMMagic8Ball.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("Magic8Ball")]

    public string Magic8Ball()
    {
        string wordOutput = "";
        Random rndNum = new Random();
        long num = rndNum.Next(1,9);

        switch(num)
        {
            case 1:
            
            wordOutput = "Yes";

            break;

            case 2:

            wordOutput = "No";

            break;

            case 3:

            wordOutput = "Maybe";

            break;

            case 4:

            wordOutput = "Bro are you for real?";

            break;

            case 5:

            wordOutput = "Most Likely";

            break;

            case 6:

            wordOutput = "Never";

            break;

            case 7:

            wordOutput = "Mehoy Minoy";

            break;

            case 8:

            wordOutput = "Ask Again";

            break;
        }

        return wordOutput;
    }
}
