﻿using Bindito.Core;
using TimberApi.New.AssetShaderSystem.ShaderFix;
using TimberApi.New.ConfiguratorSystem;
using TimberApi.New.SceneSystem;

namespace TimberApi.New.AssetShaderSystem
{
    [Configurator(SceneEntrypoint.InGame | SceneEntrypoint.MapEditor)]
    public class ShaderFixSystemConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.MultiBind<IShaderFixApplier>().To<DirtShaderFixApplier>().AsSingleton();
            containerDefinition.MultiBind<IShaderFixApplier>().To<PathShaderFixApplier>().AsSingleton();
        }
    }

    [Configurator(SceneEntrypoint.All)]
    public class ShaderSystemConfigurator : IConfigurator
    {
        public void Configure(IContainerDefinition containerDefinition)
        {
            containerDefinition.Bind<AssetShaderFixer>().AsSingleton();
        }
    }
}