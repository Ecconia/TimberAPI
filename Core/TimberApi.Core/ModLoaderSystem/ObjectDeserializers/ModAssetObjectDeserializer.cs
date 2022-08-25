﻿using System;
using System.Collections.Generic;
using System.Linq;
using TimberApi.Core.Common;
using TimberApi.Core.ConsoleSystem;
using TimberApi.Core2.Common;
using Timberborn.Persistence;

namespace TimberApi.Core.ModLoaderSystem.ObjectDeserializers
{
    internal class ModAssetObjectDeserializer : IObjectSerializer<ModAssetInfo>
    {
        private readonly IInternalConsoleWriter _consoleWriter;

        public ModAssetObjectDeserializer(IInternalConsoleWriter consoleWriter)
        {
            _consoleWriter = consoleWriter;
        }

        public void Serialize(ModAssetInfo value, IObjectSaver objectSaver)
        {
            throw new System.NotImplementedException();
        }

        public Obsoletable<ModAssetInfo> Deserialize(IObjectLoader objectLoader)
        {
            string prefix = objectLoader.Get(new PropertyKey<string>("Prefix"));
            SceneEntrypoint sceneEntrypoint = ConvertToFlag(objectLoader.Get(new ListKey<string>("Scenes")).Select(Enum.Parse<SceneEntrypoint>));

            string path = objectLoader.GetValueOrDefault(new PropertyKey<string>("Path"), "assets");
            return new ModAssetInfo(prefix, sceneEntrypoint, path);
        }

        private static T ConvertToFlag<T>(IEnumerable<T> flags) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum)
                throw new NotSupportedException($"{typeof(T)} must be an enumerated type");

            return (T)(object)flags.Cast<int>().Aggregate(0, (c, n) => c |= n);
        }
    }
}