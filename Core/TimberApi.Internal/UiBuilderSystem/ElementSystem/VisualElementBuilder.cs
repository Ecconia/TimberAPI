using TimberApi.Core2.ModAssetSystem;
using TimberApi.Internal.UiBuilderSystem.PresetSystem;
using Timberborn.CoreUI;
using UnityEngine.UIElements;

namespace TimberApi.Internal.UiBuilderSystem.ElementSystem
{
    public class VisualElementBuilder : BaseElementBuilder<VisualElement, VisualElementBuilder>
    {
        protected override VisualElementBuilder BuilderInstance => this;
        
        public VisualElementBuilder(VisualElementInitializer visualElementInitializer, IAssetLoader assetLoader, UiPresetFactory uiPresetFactory) 
            : base(new NineSliceVisualElement(), visualElementInitializer, assetLoader, uiPresetFactory)
        {

        }
        
        public VisualElementBuilder(VisualElementInitializer visualElementInitializer, IAssetLoader assetLoader, UiPresetFactory uiPresetFactory, VisualElement element) 
            : base(element, visualElementInitializer, assetLoader, uiPresetFactory)
        {

        }
    }
}