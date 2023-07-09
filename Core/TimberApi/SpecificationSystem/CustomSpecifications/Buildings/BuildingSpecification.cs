﻿using System.Collections.Generic;
using System.Collections.Immutable;

namespace TimberApi.SpecificationSystem.CustomSpecifications.Buildings
{
    /// <summary>
    ///     Represents the various settings that can be changed
    ///     on Buildings using TimberAPI
    /// </summary>
    public class BuildingSpecification
    {
        public string BuildingId;

        public int? PowerInput;

        public int? PowerOutput;

        public ImmutableArray<string> RecipeIds;

        public BuildingSpecification(string buildingId, int? scienceCost, int? powerInput, int? powerOutput, IEnumerable<string> recipeIds, IEnumerable<BuildingCost> buildingCosts)
        {
            BuildingId = buildingId;
            RecipeIds = recipeIds.ToImmutableArray();
            ScienceCost = scienceCost;
            BuildingCosts = buildingCosts.ToImmutableArray();
            PowerInput = powerInput;
            PowerOutput = powerOutput;
        }

        public int? ScienceCost { get; set; }

        public ImmutableArray<BuildingCost> BuildingCosts { get; set; }
    }
}