using JetBrains.Annotations;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Resolve;
using JetBrains.ReSharper.Psi.Tree;

namespace GammaJul.ReSharper.EnhancedTooltip.Presentation {

	internal interface IColorizer {

		[NotNull]
		PresentedInfo AppendDeclaredElement(
			[NotNull] IDeclaredElement element,
			[NotNull] ISubstitution substitution,
			[NotNull] PresenterOptions options,
			[CanBeNull] ITreeNode contextualNode);
		
		void AppendPresentableNode(
			[NotNull] ITreeNode treeNode,
			[NotNull] PresenterOptions options);

	}

}