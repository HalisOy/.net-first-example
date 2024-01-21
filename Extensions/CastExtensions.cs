using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Extensions;
public static class CastExtensions
{
    public static T CastToObject<T>(this object obj)
    {
        return (T)obj;
    }

    public static TObject? CastToInterface<TObject>(this object value)
        where TObject : class
    {
        if (value is TObject)
        {
            return value as TObject;
        }
        return null;
    }
}
