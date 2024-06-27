namespace Assignment2;
using System.Text.RegularExpressions;
public class Url
{
    public void ParseAndDisplayUrl()
    {
        // Request the URL input from the user
        Console.WriteLine("Enter a URL to parse:");
        string url = Console.ReadLine();

        // Regex pattern to parse URL into protocol, server, and resource
        string pattern = @"^(?:(?<protocol>\w+)://)?(?<server>[^/]+)(?:/(?<resource>.*))?$";

        Match match = Regex.Match(url, pattern);

        if (match.Success)
        {
            string protocol = match.Groups["protocol"].Value;
            string server = match.Groups["server"].Value;
            string resource = match.Groups["resource"].Value;

            Console.WriteLine("Parsed URL components:");
            Console.WriteLine("[protocol] = \"" + (string.IsNullOrEmpty(protocol) ? "" : protocol) + "\"");
            Console.WriteLine("[server] = \"" + server + "\"");
            Console.WriteLine("[resource] = \"" + (string.IsNullOrEmpty(resource) ? "" : resource) + "\"");
        }
        else
        {
            Console.WriteLine("Failed to parse URL: " + url);
        }
    }
}