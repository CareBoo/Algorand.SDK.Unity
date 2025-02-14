using System;
using System.CodeDom;

namespace Algorand.Unity.Editor.CodeGen
{
    public class AddFormatterCodeMethodInvokeExpression : CodeMethodInvokeExpression
    {
        public AddFormatterCodeMethodInvokeExpression(Type type, CodeExpression formatterExpression)
            : base(
                GetCodeMethodReference(type),
                formatterExpression
            )
        { }


        private static CodeMethodReferenceExpression GetCodeMethodReference(Type type) =>
            new CodeMethodReferenceExpression(
                targetObject: new CodeTypeReferenceExpression(typeof(AlgoApiFormatterLookup)),
                methodName: AlgoApiFormatterLookup.AddFormatterMethodName,
                new CodeTypeReference(type.FullNameExpression())
            );
    }
}
