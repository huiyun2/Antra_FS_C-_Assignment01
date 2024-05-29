using System;

namespace ParseURL
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://www.apple.com/iphone";
            ParseUrl(url);

            url = "ftp://www.example.com/employee";
            ParseUrl(url);

            url = "https://google.com";
            ParseUrl(url);

            url = "www.apple.com";
            ParseUrl(url);
        }

        static void ParseUrl(string url)
        {
            Uri uri;
            if (!url.Contains("://"))
            {
                url = "http://" + url;
            }
            uri = new Uri(url);

            string protocol = uri.Scheme != Uri.UriSchemeHttp ? uri.Scheme : "";
            string server = uri.Host;
            string resource = uri.AbsolutePath.Trim('/');

            Console.WriteLine($"[protocol] = \"{protocol}\"");
            Console.WriteLine($"[server] = \"{server}\"");
            Console.WriteLine($"[resource] = \"{resource}\"");
            Console.WriteLine();
        }
    }
}


