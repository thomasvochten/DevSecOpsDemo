namespace MyProject;

using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Azure.Storage.Blobs.Specialized;

class Program
{

    static void Main(string[] args)
    {


        Console.WriteLine("Let's get this party started!");

        // Deliberately hardcoded password
        var password = "pass@word1";
        Console.WriteLine("Password is: " + password);

        // Something silly
        var x = -1;
        if (x < 0)
        {
            new ArgumentException("x must be nonnegative");
        }

        const int MAX = 100;
        if (MAX == 100)
        {
            Console.WriteLine("MAX is exactly 100");
        }

        BlobServiceClient blobServiceClient = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=DevSecOpsDemo;AccountKey=Eby8vdM02xNOcqFlqUwJPLlmEtlCDXJ1OUzFT50uSRZ6IFsuFq2UVErCz4I6tq/K1SZFPTOtr/KBHBeksoGMGw==");

        // TODO: Create more vulnerabilities to test Sonarcloud such as a weak hashing algorithm    }
    }
}

