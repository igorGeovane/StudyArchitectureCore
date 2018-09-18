using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TemplateProjeto.Domain.Abstractions.Repositories;
using TemplateProjeto.Domain.Abstractions.Services;
using TemplateProjeto.Domain.Models;

namespace TemplateProjeto.Domain.Implementations.Services
{
    public class AtendimentoService : DomainServiceBase<Atendimento>, IAtendimentoService
    {
        protected AtendimentoService(IRepositoryBase<Atendimento> entityRepository) : base(entityRepository)
        {
        }
    }
}