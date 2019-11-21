using BlogDemo.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlogDemo.Core.Entities
{
    public abstract class Entity:IEntity
    {
        public int Id { get; set; }
    }
}
