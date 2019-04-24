using GammaJul.ReSharper.EnhancedTooltip.DocumentMarkup;
using JetBrains.Annotations;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Daemon.CSharp.Errors;
using JetBrains.ReSharper.Psi.CodeAnnotations;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation.Highlightings.CSharp {

	[SolutionComponent]
	internal sealed class CannotSpecifyConstructorConstraintForValueTypeErrorEnhancer : CSharpHighlightingEnhancer<CannotSpecifyConstructorConstraintForValueTypeError> {

		protected override void AppendTooltip(CannotSpecifyConstructorConstraintForValueTypeError highlighting, CSharpColorizer colorizer) {
			colorizer.AppendPlainText("The '");
			colorizer.AppendKeyword("new");
			colorizer.AppendPlainText("()' constraint cannot be used with the '");
			colorizer.AppendKeyword("struct");
			colorizer.AppendPlainText("' constraint");
		}
		
		public CannotSpecifyConstructorConstraintForValueTypeErrorEnhancer(
			[NotNull] TextStyleHighlighterManager textStyleHighlighterManager,
			[NotNull] CodeAnnotationsConfiguration codeAnnotationsConfiguration,
			[NotNull] HighlighterIdProviderFactory highlighterIdProviderFactory)
			: base(textStyleHighlighterManager, codeAnnotationsConfiguration, highlighterIdProviderFactory) {
		}

	}

}