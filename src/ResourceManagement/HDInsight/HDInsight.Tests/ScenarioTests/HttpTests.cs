//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

using System;
using System.Linq;
using System.Net;
using HDInsight.Tests.Helpers;
using Hyak.Common;
using Microsoft.Azure.Management.HDInsight;
using Microsoft.Azure.Management.HDInsight.Models;
using Microsoft.Azure.Test;
using Xunit;

namespace HDInsight.Tests
{
    public class HttpTests
    {
        [Fact]
        [Obsolete]
        public void TestDisableEnableHttp()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (var context = UndoContext.Current)
            {
                context.Start();

                var client = HDInsightManagementTestUtilities.GetHDInsightManagementClient(handler);
                var resourceManagementClient = HDInsightManagementTestUtilities.GetResourceManagementClient(handler);

                var resourceGroup = HDInsightManagementTestUtilities.CreateResourceGroup(resourceManagementClient);
                const string dnsname = "hdisdk-httptest2";

                var spec = GetClusterSpecHelpers.GetPaasClusterSpec();

                client.Clusters.Create(resourceGroup, dnsname, spec);

                var httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.True(httpSettings.HttpUserEnabled);

                var httpParams = new HttpSettingsParameters
                {
                    HttpUserEnabled = false,
                };

                client.Clusters.ConfigureHttpSettings(resourceGroup, dnsname, httpParams);
                httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.False(httpSettings.HttpUserEnabled);

                httpParams = new HttpSettingsParameters
                {
                    HttpUserEnabled = true,
                    HttpUsername = "admin",
                    HttpPassword = "Password1!"
                };

                client.Clusters.ConfigureHttpSettings(resourceGroup, dnsname, httpParams);
                httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.True(httpSettings.HttpUserEnabled);

                client.Clusters.Delete(resourceGroup, dnsname);
            }
        }

        [Fact]
        [Obsolete]
        public void TestEnableEnableHttp()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (var context = UndoContext.Current)
            {
                context.Start();

                var client = HDInsightManagementTestUtilities.GetHDInsightManagementClient(handler);
                var resourceManagementClient = HDInsightManagementTestUtilities.GetResourceManagementClient(handler);

                var resourceGroup = HDInsightManagementTestUtilities.CreateResourceGroup(resourceManagementClient);
                const string dnsname = "hdisdk-httptest3";

                var spec = GetClusterSpecHelpers.GetPaasClusterSpec();

                client.Clusters.Create(resourceGroup, dnsname, spec);

                var httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);

                Assert.True(httpSettings.HttpUserEnabled);
                
                var httpParams = new HttpSettingsParameters
                {
                    HttpUserEnabled = true,
                    HttpUsername = "admin",
                    HttpPassword = "Password1!"
                };

                try
                {
                    client.Clusters.ConfigureHttpSettings(resourceGroup, dnsname, httpParams);
                }
                catch (CloudException ex)
                {
                    Assert.Equal(ex.Response.StatusCode, HttpStatusCode.Conflict);
                }
                httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.True(httpSettings.HttpUserEnabled);

                var result = client.Clusters.Delete(resourceGroup, dnsname);
                //Assert.Equal(result.StatusCode, HttpStatusCode.NoContent);
            }
        }

        [Fact]
        [Obsolete]
        public void TestEnableDisableDisableHttp()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (var context = UndoContext.Current)
            {
                context.Start();

                var client = HDInsightManagementTestUtilities.GetHDInsightManagementClient(handler);
                var resourceManagementClient = HDInsightManagementTestUtilities.GetResourceManagementClient(handler);

                var resourceGroup = HDInsightManagementTestUtilities.CreateResourceGroup(resourceManagementClient);
                const string dnsname = "hdisdk-httptest3";

                var spec = GetClusterSpecHelpers.GetPaasClusterSpec();

                var cluster = client.Clusters.Create(resourceGroup, dnsname, spec);

                string errorMessage = cluster.Cluster.Properties.ErrorInfos.Any()
                    ? cluster.Cluster.Properties.ErrorInfos[0].Message
                    : String.Empty;

                Assert.True(cluster.Cluster.Properties.ClusterState.Equals("Running", StringComparison.OrdinalIgnoreCase),
                    String.Format("Cluster Creation Failed ErrorInfo: {0}", errorMessage));

                HDInsightManagementTestUtilities.WaitForClusterToMoveToRunning(resourceGroup, dnsname, client);

                var httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.True(httpSettings.HttpUserEnabled);

                var httpParams = new HttpSettingsParameters
                {
                    HttpUserEnabled = false,
                };

                client.Clusters.ConfigureHttpSettings(resourceGroup, dnsname, httpParams);
                httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.False(httpSettings.HttpUserEnabled);
                
                client.Clusters.ConfigureHttpSettings(resourceGroup, dnsname, httpParams);

                httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.False(httpSettings.HttpUserEnabled);

                client.Clusters.Delete(resourceGroup, dnsname);
            }
        }

        [Fact]
        [Obsolete]
        public void TestDisableEnableHttpCustomCode()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (var context = UndoContext.Current)
            {
                context.Start();

                var client = HDInsightManagementTestUtilities.GetHDInsightManagementClient(handler);
                var resourceManagementClient = HDInsightManagementTestUtilities.GetResourceManagementClient(handler);

                var resourceGroup = HDInsightManagementTestUtilities.CreateResourceGroup(resourceManagementClient);
                const string dnsname = "hdisdk-httptest3";

                var spec = GetClusterSpecHelpers.GetPaasClusterSpec();

                client.Clusters.Create(resourceGroup, dnsname, spec);

                var httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.True(httpSettings.HttpUserEnabled);

                client.Clusters.DisableHttp(resourceGroup, dnsname);
                httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.False(httpSettings.HttpUserEnabled);

                client.Clusters.EnableHttp(resourceGroup, dnsname, "admin", "Password1!");
                httpSettings = client.Clusters.GetConnectivitySettings(resourceGroup, dnsname);
                Assert.True(httpSettings.HttpUserEnabled);

                client.Clusters.Delete(resourceGroup, dnsname);
            }
        }

        [Fact]
        public void TestHttpGetGatewaySettings()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (var context = UndoContext.Current)
            {
                context.Start();

                var client = HDInsightManagementTestUtilities.GetHDInsightManagementClient(handler);
                var resourceManagementClient = HDInsightManagementTestUtilities.GetResourceManagementClient(handler);

                var resourceGroup = HDInsightManagementTestUtilities.CreateResourceGroup(resourceManagementClient);
                const string dnsname = "hdisdk-httptest4";

                var clusterparams = GetClusterSpecHelpers.GetCustomCreateParametersIaas();
                clusterparams.Version = "3.6";
                clusterparams.Location = "North Central US";
                

                client.Clusters.Create(resourceGroup, dnsname, clusterparams);

                var httpGatewaySettings = client.Clusters.GetGatewaySettings(resourceGroup, dnsname);

                Assert.True(httpGatewaySettings.HttpUserEnabled);

                var httpParams = new HttpSettingsParameters
                {
                    HttpUserEnabled = true,
                    HttpUsername = "admin",
                    HttpPassword = "Password1!"
                };

                Assert.Equal(httpParams.HttpUsername, httpGatewaySettings.HttpUsername);

                var result = client.Clusters.Delete(resourceGroup, dnsname);
                
            }
        }

        [Fact]
        public void TestHttpUpdateGatewaySettings()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (var context = UndoContext.Current)
            {
                context.Start();

                var client = HDInsightManagementTestUtilities.GetHDInsightManagementClient(handler);
                var resourceManagementClient = HDInsightManagementTestUtilities.GetResourceManagementClient(handler);

                var resourceGroup = HDInsightManagementTestUtilities.CreateResourceGroup(resourceManagementClient);

                const string dnsname = "zzy-hdisdk-httptest5";


                var clusterparams = GetClusterSpecHelpers.GetCustomCreateParametersIaas();
                clusterparams.Version = "3.6";
                clusterparams.Location = "North Central US";

                client.Clusters.Create(resourceGroup, dnsname, clusterparams);

                var httpGatewaySettings = client.Clusters.GetGatewaySettings(resourceGroup, dnsname);

                Assert.True(httpGatewaySettings.HttpUserEnabled);

                var httpParams = new HttpSettingsParameters
                {
                    HttpUserEnabled = true,
                    HttpUsername = "admin",
                    HttpPassword = "Password2!"
                };

              
                Assert.Equal(httpParams.HttpUsername, httpGatewaySettings.HttpUsername);

                var result = client.Clusters.UpdateGatewaySettings(resourceGroup, dnsname, httpParams);
                Assert.Equal(result.StatusCode, HttpStatusCode.OK);

                httpGatewaySettings = client.Clusters.GetGatewaySettings(resourceGroup, dnsname);
                Assert.Equal(httpParams.HttpPassword, httpGatewaySettings.HttpPassword);

                result = client.Clusters.Delete(resourceGroup, dnsname);
                
            }
        }

        [Fact]
        public void TestHttpListConfigurationsSettings()
        {
            var handler = new RecordedDelegatingHandler { StatusCodeToReturn = HttpStatusCode.OK };

            using (var context = UndoContext.Current)
            {
                context.Start();

                var client = HDInsightManagementTestUtilities.GetHDInsightManagementClient(handler);
                var resourceManagementClient = HDInsightManagementTestUtilities.GetResourceManagementClient(handler);

                var resourceGroup = HDInsightManagementTestUtilities.CreateResourceGroup(resourceManagementClient);
                
                
                const string dnsname = "zzy-hdisdk-httptest5";
                var clusterparams = GetClusterSpecHelpers.GetCustomCreateParametersIaas();
                clusterparams.Version = "3.6";
                clusterparams.Location = "North Central US";

                client.Clusters.Create(resourceGroup, dnsname, clusterparams);

                var httpConfigurations = client.Clusters.ListConfigurations(resourceGroup,dnsname);

                var core = httpConfigurations.Configurations["core-site"];
                var gateway = httpConfigurations.Configurations["gateway"];


                Assert.NotEmpty(core.Configuration["fs.defaultFS"]);
                Assert.NotEmpty(gateway.Configuration["restAuthCredential.isEnabled"]);

                var result = client.Clusters.Delete(resourceGroup, dnsname);
                
            }
        }
    }
}
