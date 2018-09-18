using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using TemplateProjeto.Domain.Models;

namespace TemplateProjeto.Infrastructure.Repository.Configuration.HomeCare
{
    public class AtendimentoEntityConfiguration : IEntityTypeConfiguration<Atendimento>
    {
        public void Configure(EntityTypeBuilder<Atendimento> builder)
        {
            builder.ToTable("HC_Atendimento");

            builder.HasKey(atendimento => atendimento.Id);

            builder.Property(atendimento => atendimento.Id)
                .HasColumnName("id")
                .IsRequired();

            builder.Property(atendimento => atendimento.CodigoAtendimento)
                .HasColumnName("CD_ATENDIMENTO");

            builder.Property(atendimento => atendimento.IdPaciente)
                .HasColumnName("HC_Paciente_ID");

            builder.Property(atendimento => atendimento.IdConvenio)
                .HasColumnName("HC_Convenio_ID");

            builder.Property(atendimento => atendimento.IdEnfermaria)
                .HasColumnName("HC_Enfermaria_ID");

            builder.Property(atendimento => atendimento.IdOrigemAtendimento)
                .HasColumnName("HC_OrigemAtendimento_ID");

            builder.Property(atendimento => atendimento.CID)
                .HasColumnName("CID")
                .HasMaxLength(6);

            builder.Property(atendimento => atendimento.Deambula)
                .HasColumnName("Deambula");

            builder.Property(atendimento => atendimento.Isolamento)
                .HasColumnName("Isolamento");

            builder.Property(atendimento => atendimento.Liminar)
                .HasColumnName("Liminar");

            builder.Property(atendimento => atendimento.RefeicaoObservacao)
                .HasColumnName("RefeicaoObs")
                .HasMaxLength(200);

            builder.Property(atendimento => atendimento.DataCadastro)
                .HasColumnName("Data_Cadastro");

            builder.Property(atendimento => atendimento.DataOperacao)
                .HasColumnName("Data_Operacao");

            builder.Property(atendimento => atendimento.DataInicio)
                .HasColumnName("Data_Inicio");

            builder.Property(atendimento => atendimento.VIP)
                .HasColumnName("VIP");

            builder.Property(atendimento => atendimento.Poliqueixoso)
                .HasColumnName("Poliqueixoso");

            builder.Property(atendimento => atendimento.NomeResponsavel)
                .HasColumnName("NomeResponsavel");

            builder.Property(atendimento => atendimento.IdParentesco)
                .HasColumnName("IdParentesco");

            builder.Property(atendimento => atendimento.Telefone)
                .HasColumnName("Telefone");

            builder.Property(atendimento => atendimento.IdCepRH)
                .HasColumnName("RH_CEP_ID");

            builder.Property(atendimento => atendimento.NumeroEndereco)
                .HasColumnName("Endereco_Numero");

            builder.Property(atendimento => atendimento.ComplementoEndereco)
                .HasColumnName("Endereco_Complemento");

            builder.Property(atendimento => atendimento.IdPreferenciaAtendimento)
                .HasColumnName("Pref_Temperamento");

            builder.Property(atendimento => atendimento.IdPreferenciaPorteFisico)
                .HasColumnName("Pref_PorteFisico");

            builder.Property(atendimento => atendimento.IdPreferenciaReligiao)
                .HasColumnName("Pref_Religiao");

            builder.Property(atendimento => atendimento.IdPreferenciaRaca)
                .HasColumnName("Pref_Raca");

            builder.Property(atendimento => atendimento.PreferenciaSexo)
                .HasColumnName("Pref_Sexo");

            builder.Property(atendimento => atendimento.IdComplexidadeHC)
                .HasColumnName("HC_Complexidade_ID");

            builder.Property(atendimento => atendimento.IdOpcaoRefeicaoHC)
                .HasColumnName("HC_OpcaoRefeicao_ID");

            builder.Property(atendimento => atendimento.IdRelogio)
                .HasColumnName("idHCRelogio");

            builder.Property(atendimento => atendimento.IdMotivoAlta)
                .HasColumnName("Id_MotivoAlta");

            builder.Property(atendimento => atendimento.DataAlta)
                .HasColumnName("DataAlta");

            builder.Property(atendimento => atendimento.SituacaoMarcacao)
                .HasColumnName("SituacaoMarcacao");

            builder.Property(atendimento => atendimento.IdPreferenciaFumante)
                .HasColumnName("Pref_Fumante");

            builder.Property(atendimento => atendimento.ReferenciaEndereco)
                .HasColumnName("Endereco_Referencia");
        }
    }
}
