﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using Microsoft.CodeAnalysis.Sarif;
using Microsoft.Sarif.Viewer.Models;

namespace Microsoft.Sarif.Viewer.Sarif
{
    internal static class StackExtensions
    {
        public static StackCollection ToStackCollection(this Stack stack, int resultId, int runIndex)
        {
            if (stack == null)
            {
                return null;
            }

            var model = new StackCollection(stack.Message?.Text);

            if (stack.Frames != null)
            {
                foreach (StackFrame frame in stack.Frames)
                {
                    model.Add(frame.ToStackFrameModel(resultId, runIndex));
                }
            }

            return model;
        }
    }
}
