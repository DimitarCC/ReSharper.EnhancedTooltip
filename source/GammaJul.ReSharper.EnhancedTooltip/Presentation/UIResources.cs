using System;
using System.Windows;
using System.Windows.Controls;
using JetBrains.Annotations;
using JetBrains.Application;
using JetBrains.Application.UI.Extensions;
using JetBrains.ReSharper.Resources.Shell;
using JetBrains.Util;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation {

	[ShellComponent]
	internal sealed class UIResources {

		[NotNull]
		public static UIResources Instance
			=> Shell.Instance.GetComponent<UIResources>();

		[NotNull] [ItemNotNull] private readonly Lazy<ResourceDictionary> _lazyResourceDictionary = Lazy.Of(LoadResourceDictionary, true);
		
		[NotNull]
		public Style HeaderedContentControlStyle
			=> (Style) _lazyResourceDictionary.Value["HeaderedContentControlStyle"];

		[NotNull]
		public Style QuickInfoListBoxStyle
			=> (Style) _lazyResourceDictionary.Value["QuickInfoListBoxStyle"];

		[NotNull]
		public DataTemplate QuickInfoItemDataTemplate
			=> (DataTemplate) _lazyResourceDictionary.Value["QuickInfoItemDataTemplate"];

		[NotNull]
		public DataTemplate LegacyQuickInfoItemDataTemplate
			=> (DataTemplate) _lazyResourceDictionary.Value["LegacyQuickInfoItemDataTemplate"];

		[NotNull]
		public ControlTemplate QuickInfoRootControlTemplate
			=> (ControlTemplate) _lazyResourceDictionary.Value["QuickInfoRootControlTemplate"];

		[NotNull]
		private static ResourceDictionary LoadResourceDictionary()
			=> new ResourceDictionary {
				Source = UriHelpers.MakeUri("Presentation/UIResources.xaml", typeof(UIResources).Assembly)
			};

	}

}