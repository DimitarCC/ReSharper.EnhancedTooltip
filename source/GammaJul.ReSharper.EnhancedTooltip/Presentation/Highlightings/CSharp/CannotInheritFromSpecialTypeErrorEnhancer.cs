using GammaJul.ReSharper.EnhancedTooltip.DocumentMarkup;
using JetBrains.Annotations;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CodeAnnotations;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings.CSharp {

	[SolutionComponent]
	internal sealed class CannotInheritFromSpecialTypeErrorEnhancer : CSharpHighlightingEnhancer<CannotInheritFromSpecialTypeError> {

		protected override void AppendTooltip(CannotInheritFromSpecialTypeError highlighting, CSharpColorizer colorizer) {
			colorizer.AppendPlainText("Cannot derive from special class '");
			colorizer.AppendExpressionType(TypeFactory.CreateType(highlighting.TypeElement), false, PresenterOptions.QualifiedName);
			colorizer.AppendPlainText("'");
		}
		
		public CannotInheritFromSpecialTypeErrorEnhancer(
			[NotNull] TextStyleHighlighterManager textStyleHighlighterManager,
			[NotNull] CodeAnnotationsConfiguration codeAnnotationsConfiguration,
			[NotNull] HighlighterIdProviderFactory highlighterIdProviderFactory)
			: base(textStyleHighlighterManager, codeAnnotationsConfiguration, highlighterIdProviderFactory) {
		}

	}

}