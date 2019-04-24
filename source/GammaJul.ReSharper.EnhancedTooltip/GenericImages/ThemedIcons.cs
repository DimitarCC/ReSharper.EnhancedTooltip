using System.Windows.Markup;
using GammaJul.ReSharper.EnhancedTooltip;
using JetBrains.Annotations;
using JetBrains.UI.Icons;
using JetBrains.UI.Icons.CompiledIcons;

[assembly: XmlnsDefinition("urn:shemas-jetbrains-com:ui-application-icons-generic", "GammaJul.ReSharper.EnhancedTooltip")]
[assembly: CompiledIconsPack(
	IconPackResourceIdentification = ThemedIcons.IconPackResourceName,
	IconNames = new[] { "Logo16" })]

namespace GammaJul.ReSharper.EnhancedTooltip {

	[UsedImplicitly]
	public sealed class ThemedIcons {

		internal const string IconPackResourceName = "GammaJul.ReSharper.EnhancedTooltip;component/GenericImages/ThemedIcons.Generic.Generated.Xaml";

		[CompiledIconClass(IconPackResourceName, 0, "Logo16")]
		public sealed class Logo16 : CompiledIconClass {

			[UsedImplicitly] public static IconId Id = new CompiledIconId(IconPackResourceName, 0, "Logo16");

		}

	}

}