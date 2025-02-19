﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading.Tasks;
using Azure.Core.TestFramework;
using NUnit.Framework;

namespace Azure.AI.OpenAI.Tests;

public class SpeechGenerationTests : OpenAITestBase
{
    public SpeechGenerationTests(bool isAsync)
        : base(Scenario.SpeechGeneration, isAsync) // , RecordedTestMode.Live)
    {
    }

    [RecordedTest]
    [TestCase(Service.Azure, "mp3")]
    [TestCase(Service.NonAzure, "mp3")]
    [TestCase(Service.Azure, "wav")]
    [TestCase(Service.NonAzure, "wav")]
    public async Task GenerateSpeechFromText(Service serviceTarget, string responseFormat)
    {
        OpenAIClient client = GetTestClient(serviceTarget);
        string deploymentOrModelName = GetDeploymentOrModelName(serviceTarget);

        SpeechGenerationOptions requestOptions = new()
        {
            DeploymentName = deploymentOrModelName,
            Input = "Hello World",
            Voice = SpeechVoice.Alloy,
            ResponseFormat = responseFormat,
        };

        Response<BinaryData> response = await client.GenerateSpeechFromTextAsync(requestOptions);

        Assert.That(response?.Value, Is.Not.Null);
        Assert.That(response.Value, Is.InstanceOf<BinaryData>());

        byte[] byteArray = response.Value.ToArray();
        Assert.That(byteArray, Is.Not.Empty);
    }
}
