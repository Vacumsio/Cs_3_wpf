using System.Collections.Generic;
using MailSender.lib.Entities.Base;
using MailSender.lib.Services.Interfaces;

namespace MailSender.lib.Services.InMemory
{
    public abstract class InDataProvider<T> : IDataProvider<T> where T : BaseEntity
    {
        public readonly List<T> _Items = new List<T>();

        public IEnumerable<T> GetAll() => _Items;

        public T GetById(int id) => _Items.FirstOrDefault(item => item.Id == id);

        public int Create(T item)
        {
            if (_Items.Contains(item)) return item.Id;

            item.Id = _Items.Count == 0 ? 1 : _Items.Max(r => r.Id) + 1;

            _Items.Add(item);

            return item.Id;
        }

        public bool Remove(int id)
        {
            var db_tem = GetById(id);
            return _Items.Remove(db_tem);
        }

        public abstract void Edit(int id, T item);
         

        public void SaveChanges()
        {
            
        }
    }
}
