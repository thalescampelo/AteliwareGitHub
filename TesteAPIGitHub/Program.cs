using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Linq;
using Octokit;
using Octokit.Internal;
using Octokit.Reactive;

namespace TesteAPIGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new GitHubClient(new ProductHeaderValue("MyAteliware"));

            var basicAuth = new Credentials("thalescampelo", "github@123"); // NOTE: not real credentials
            client.Credentials = basicAuth;

            var options = new ApiOptions();
            //var repositories = await client.Repository.GetAllForCurrent(options);
        }

        private void Teste1()
        {
            
        }
    }
}
