﻿using TimberApi.Common.Extensions;
using TimberApi.VersionSystem;

namespace TimberApi
{
    public class Versions
    {
        public static readonly Version GameVersion = Version.Parse(Timberborn.Versioning.Versions.VersionNumber);

        public static Version TimberApiVersion { get; } = Version.Parse("TIMBER_API_VERSION_PLACEHOLDER".ReplacePlaceholderWithFakeVersion());

        internal static Version TimberApiMinimumGameVersion { get; } = Version.Parse("MINIMUN_GAME_VERSION_PLACEHOLDER".ReplacePlaceholderWithFakeVersion());
    }
}