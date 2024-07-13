using Bindito.Core;
using TimberApi.SpecificationSystem;

namespace TimberApi.Tools.ToolSystem.Tools.WaterGenerator;

[Context("Game")]
public class WaterGeneratorToolConfigurator : IConfigurator
{
    public void Configure(IContainerDefinition containerDefinition)
    {
        containerDefinition.MultiBind<IToolFactory>().To<WaterGeneratorToolFactory>().AsSingleton();
        containerDefinition.MultiBind<ISpecificationGenerator>().To<WaterGeneratorToolGenerator>().AsSingleton();
    }
}