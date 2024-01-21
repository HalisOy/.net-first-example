using FirstExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstExample.Extensions;
public static class DictionaryExtensions
{
    public static void AddToDictionary<TKey, TValue>(this IDictionary<TKey, TValue> values, IList<TValue> lists, IDictionary<TKey, IList<TKey>> indexes)
        where TKey : notnull
        where TValue : IBaseUser
    {
        TKey castToKey(object key)
        {
            object newKey = "" + key + "";
            return (TKey)newKey;
        }
        void addIndex(object findKeyObject, TKey dataKey)
        {
            TKey findKey = castToKey(findKeyObject);
            if (indexes.ContainsKey(findKey))
            {
                indexes[findKey].Add(dataKey);
            }
            else
            {
                indexes.Add(findKey, new List<TKey>() { dataKey });
            }
        }
        lists.ToList().ForEach(item =>
        {
            TKey key = castToKey(item.UserName);
            values.Add(key, item);
            addIndex(item.UserName, key);
            addIndex(item.IdentityNumber, key);
            addIndex(item.FirstName, key);
            addIndex(item.LastName, key);
            var personal = item.CastToInterface<IPersonal>();
            var jobber = item.CastToInterface<IJobber>();
            var student = item.CastToInterface<IStudent>();
            if (personal != null)
            {
                addIndex(personal.SSN, key);
                addIndex(personal.Salary, key);
            }
            else if (jobber != null)
            {
                addIndex(jobber.WorkArea, key);
                addIndex(jobber.VehiclePlate, key);
            }
            else if (student != null)
            {
                addIndex(student.Absenteeism, key);
                addIndex(student.Marks, key);
                addIndex(student.StudentNumber, key);
            }
        });
    }
    
}