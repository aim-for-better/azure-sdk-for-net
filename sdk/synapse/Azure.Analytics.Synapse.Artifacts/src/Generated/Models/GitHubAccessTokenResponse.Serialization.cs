// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class GitHubAccessTokenResponse
    {
        internal static GitHubAccessTokenResponse DeserializeGitHubAccessTokenResponse(JsonElement element)
        {
            Optional<string> gitHubAccessToken = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("gitHubAccessToken"))
                {
                    gitHubAccessToken = property.Value.GetString();
                    continue;
                }
            }
            return new GitHubAccessTokenResponse(gitHubAccessToken.Value);
        }
    }
}
