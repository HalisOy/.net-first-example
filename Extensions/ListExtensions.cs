using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Extensions
{
    public static class ListExtensions
    {
        public static List<T> FindAll<T>(this IList<T> values,Predicate<T> predicate)
        {
            return values.ToList().FindAll(predicate);
        }
        public static T? Find<T>(this IList<T> values, Predicate<T> predicate)
        {
            return values.ToList().Find(predicate);
        }
        public static void FindandAddControl<T,A>(this IList<T> newList,IList<A> list, Predicate<A> predicate)
        {
            A value = list.Find(predicate);
            if (value != null)
            {
                newList.Add(value.CastToObject<T>());
            }
        }
    }
}
