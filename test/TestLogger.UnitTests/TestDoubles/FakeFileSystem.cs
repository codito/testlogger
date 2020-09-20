// Copyright (c) Spekt Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Spekt.TestLogger.UnitTests.TestDoubles
{
    using System;
    using System.Collections.Generic;
    using Spekt.TestLogger.Platform;

    public class FakeFileSystem : IFileSystem
    {
        private readonly Dictionary<string, string> files;

        public FakeFileSystem()
        {
            this.files = new Dictionary<string, string>();
        }

        public string Read(string path)
        {
            if (this.files.TryGetValue(path, out var content))
            {
                return content;
            }

            throw new ArgumentException("File does not exist.", nameof(path));
        }

        public void Write(string path, string content)
        {
            this.files[path] = content;
        }

        public void Delete(string path)
        {
            if (this.files.ContainsKey(path))
            {
                this.files.Remove(path);
            }
        }
    }
}