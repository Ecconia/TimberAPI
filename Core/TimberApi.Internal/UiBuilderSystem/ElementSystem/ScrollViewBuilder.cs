using System;
using System.Collections.Generic;
using TimberApi.Core2.ModAssetSystem;
using TimberApi.Internal.UiBuilderSystem.PresetSystem;
using Timberborn.CoreUI;
using UnityEngine.UIElements;

namespace TimberApi.Internal.UiBuilderSystem.ElementSystem
{
    public class ScrollViewBuilder : BaseElementBuilder<ScrollView, ScrollViewBuilder>, IScrollableBuilder<ScrollViewBuilder>
    {
        protected override ScrollViewBuilder BuilderInstance => this;
        
        public ScrollViewBuilder(VisualElementInitializer visualElementInitializer, IAssetLoader assetLoader, UiPresetFactory uiPresetFactory) 
            : base(new ScrollView(), visualElementInitializer, assetLoader, uiPresetFactory)
        {
        }
        
        public ScrollViewBuilder ModifyVerticalScroller(Action<Scroller> modifyScroller)
        {
            modifyScroller.Invoke(Root.verticalScroller);
            return this;
        }

        public ScrollViewBuilder ModifyHorizontalScroller(Action<Scroller> modifyScroller)
        {
            modifyScroller.Invoke(Root.horizontalScroller);
            return this;
        }
        
        public ScrollViewBuilder AddChildren(IEnumerable<VisualElement> children)
        {
            foreach (VisualElement visualElement in children)
            {
                Root.Add(visualElement);
            }
            return this;
        }

        public ScrollViewBuilder AddChild(VisualElement element)
        {
            Root.Add(element);
            return this;
        }
    }
}