using System.Linq.Expressions;

namespace TNeural.Utilities
{
    public interface IExpressable
    {
        Expression ToExpression();
    }

    public interface IExpressable<TDelegate>: IExpressable
    {
        Expression<TDelegate> ToExpression();
    }
}