using System;
using System.Collections.Generic;
using System.Text;
using BlogDemo.Core.Entities;
using BlogDemo.Infrastructure.Services;

namespace BlogDemo.Infrastructure.Resources
{
    public class PostPropertyMapping : PropertyMapping<PostResource, Post>
    {
        //排序依据待具体看 StringComparer.OrdinalIgnoreCase
        public PostPropertyMapping() : base(
            new Dictionary<string, List<MappedProperty>>
                (StringComparer.OrdinalIgnoreCase)
                {
                    [nameof(PostResource.Title)] = new List<MappedProperty>
                    {
                        new MappedProperty{ Name = nameof(Post.Title), Revert = false}
                    },
                    [nameof(PostResource.Body)] = new List<MappedProperty>
                    {
                        new MappedProperty{ Name = nameof(Post.Body), Revert = false}
                    },
                    [nameof(PostResource.Author)] = new List<MappedProperty>
                    {
                        new MappedProperty{ Name = nameof(Post.Author), Revert = false}
                    },
                    //更新时间
                    [nameof(PostResource.UpdateTime)] = new List<MappedProperty>
                    {
                        new MappedProperty{ Name = nameof(Post.LastModified),Revert = true}
                    }
                })
        {
        }
    }
}
