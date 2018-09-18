using System;
using System.Collections.Generic;
using System.Text;
using TemplateProjeto.Domain.Abstractions.Repositories;
using TemplateProjeto.Domain.Models;
using TemplateProjeto.Infrastructure.Repository.Context;

namespace TemplateProjeto.Infrastructure.Repository.Implementations
{
    public class AtendimentoRepository : RepositoryBase<Atendimento>, IAtendimentoRepository
    {
        public AtendimentoRepository(HomeCareContext homeCareContext) : base(homeCareContext) { }
    }
}
