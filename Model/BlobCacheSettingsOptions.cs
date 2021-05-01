using System;
using Microsoft.Extensions.Caching.Memory;

namespace WebApi.Model
{
    public class BlobCacheSettingsOptions
    {
        public const string BlobCacheSettings = "BlobCacheSettings";
        public TimeSpan SlidingExpiration { get; set; } = TimeSpan.FromHours(2);
        public CacheItemPriority Priority { get; set; }
        public int Size { get; set; }
    }
}