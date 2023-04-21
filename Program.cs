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

        // Deliberately hardcoded secrets
        BlobServiceClient blobServiceClient = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=thisivulnerablestorage;AccountKey=+eAwigsvbNxLb7ZcOxvgrHjuXE0oliYfNQb21rpeuFkENfUoJ/abfDw1eOaSwIGOR1CIHWYGIXZx+AStJb4kqA==;EndpointSuffix=core.windows.net");
        blobServiceClient.GetBlobContainerClient("demo-devsecops").GetBlobClient("demo-devsecops.txt").DownloadTo("demo-devsecops.txt");


        string sas_token = "sp=rl&st=2023-04-21T13:53:33Z&se=2024-04-21T21:53:33Z&spr=https&sv=2021-12-02&sr=c&sig=Wk7kp6JMRaHaxUtOa0nkBR2zSuFQd1JfnkV9md8TiJw%3D";
        string sas_url = "https://thisivulnerablestorage.blob.core.windows.net/demo-devsecops?sp=rl&st=2023-04-21T13:53:33Z&se=2024-04-21T21:53:33Z&spr=https&sv=2021-12-02&sr=c&sig=Wk7kp6JMRaHaxUtOa0nkBR2zSuFQd1JfnkV9md8TiJw%3D";

        Console.WriteLine("SAS token is: " + sas_token);
        Console.WriteLine("SAS URL is: " + sas_url);

        // TODO: Create more vulnerabilities to test Sonarcloud such as a weak hashing algorithm    }
    }
}

