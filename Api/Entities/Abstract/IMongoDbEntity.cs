using System;

namespace Api.Entities.Abstract
{
    public interface IMongoDbEntity
    {
    }

    public interface IMongoDbEntity<out TKey> : IMongoDbEntity where TKey : IEquatable<TKey>
    {
        public TKey Id { get; }
        DateTime CreatedAt { get; set; }
    }
}