using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class HashTable
    {
        class HashData
        {
            public object Value { get; set; }
            public int KeyHash { get; private set; } 

            public HashData(int key, object val)
            {
                KeyHash = key;
                Value = val;
            }
        }

        private List<HashData>[] data;
        /// <summary>
        /// Конструктор контейнера
        /// summary>
        /// size">Размер хэш-таблицы
        public HashTable(int size)
        {
            data = new List<HashData>[size];
            //new Tuple<int, List<object>>[size];
        }
        ///
        /// Метод складывающий пару ключ-значение в таблицу
        ///
        /// key">
        /// value">
        public void PutPair(object key, object value)
        {
            var keyHashCode = key.GetHashCode();
            var k = Math.Abs(keyHashCode) % data.Length;

            if (data[k]!= null)
            {
                var variable = data[k].FirstOrDefault(x => x.KeyHash == keyHashCode);
                if (variable != null) variable.Value = value;
                else data[k].Add(new HashData(keyHashCode, value));
            }

            if (data[k] == null)
                data[k] = new List<HashData> { new HashData(keyHashCode, value) };
        }
        /// <summary>
        /// Поиск значения по ключу
        /// summary>
        /// key">Ключ
        /// <returns>Значение, null если ключ отсутствует<returns>
        public object GetValueByKey(object key)
        {
            try
            {
                var HashCodeKey = key.GetHashCode();
                var k = Math.Abs(HashCodeKey) % data.Length;
                var keyByValue = data[k];
                return keyByValue.Find(x => x.KeyHash == HashCodeKey).Value;
            }
            catch
            {
                return null;
            }
        }
        public static void Main(string[] args)
        {

        }
    }
}