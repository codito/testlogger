// Copyright (c) Spekt Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Spekt.TestLogger.Platform
{
    using System;
    using System.IO;

    public class FileSystem : IFileSystem
    {
        public string Read(string path)
        {
            if (!File.Exists(path))
            {
                throw new ArgumentException("File does not exist.", nameof(path));
            }

            using (var reader = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                return reader.ReadToEnd();
            }
        }

        public void Write(string path, string content)
        {
            using (var writer = new StreamWriter(new FileStream(path, FileMode.OpenOrCreate)))
            {
                writer.Write(content);
            }
        }

        public void Delete(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}