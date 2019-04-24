﻿using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using JetBrains.Application.Settings;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Feature.Services.Daemon;
using JetBrains.UI.RichText;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings {

	[SolutionComponent]
	public sealed class HighlightingEnhancerManager {

		[NotNull] private readonly Dictionary<Type, IHighlightingEnhancer> _highlightingEnhancers;

		[CanBeNull]
		public RichText TryEnhance([CanBeNull] IHighlighting highlighting, [NotNull] IContextBoundSettingsStore settings) {
			if (highlighting == null || !_highlightingEnhancers.TryGetValue(highlighting.GetType(), out IHighlightingEnhancer highlightingEnhancer))
				return null;

			return highlightingEnhancer.TryEnhance(highlighting, settings);
		}

		public HighlightingEnhancerManager([NotNull] IEnumerable<IHighlightingEnhancer> highlightingEnhancers) {
			_highlightingEnhancers = highlightingEnhancers.ToDictionary(he => he.HighlightingType);
		}

	}

}