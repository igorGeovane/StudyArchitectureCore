using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateProjeto.Infrastructure.Repository.Context
{
    public class HomeCareContext : DbContextBase
    {
        public HomeCareContext() : base("ConnectionStringHomeCare")
        {
            EntityTypeConfigurationPath = "HomeCare";
        }
    }
}
