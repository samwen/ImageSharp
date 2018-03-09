﻿// Copyright (c) Six Labors and contributors.
// Licensed under the Apache License, Version 2.0.

using SixLabors.ImageSharp.Processing.Transforms;
using SixLabors.ImageSharp.Processing.Transforms.Processors;
using Xunit;

namespace SixLabors.ImageSharp.Tests.Processing.Transforms
{
    public class EntropyCropTest : BaseImageOperationsExtensionTest
    {
        [Theory]
        [InlineData(0.5F)]
        [InlineData(.2F)]
        public void EntropyCropThresholdFloatEntropyCropProcessorWithThreshold(float threshold)
        {
            this.operations.EntropyCrop(threshold);
            EntropyCropProcessor<Rgba32> processor = this.Verify<EntropyCropProcessor<Rgba32>>();

            Assert.Equal(threshold, processor.Threshold);
        }
    }
}