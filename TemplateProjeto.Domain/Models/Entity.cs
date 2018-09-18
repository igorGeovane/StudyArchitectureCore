using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateProjeto.Domain.Models
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public abstract Entity WithId(int id);
    }
}
