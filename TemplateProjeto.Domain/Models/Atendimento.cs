using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateProjeto.Domain.Models
{
    public class Atendimento : Entity
    {
        public int CodigoAtendimento { get; set; }
        public int IdPaciente { get; set; }
        public int IdConvenio { get; set; }
        public int IdEnfermaria { get; set; }
        public int IdOrigemAtendimento { get; set; }
        public int IdTipoAtendimento { get; set; }
        public string CID { get; set; }
        public bool Deambula { get; set; }
        public bool Isolamento { get; set; }
        public bool Liminar { get; set; }
        public string RefeicaoObservacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime? DataOperacao { get; set; }
        public DateTime? DataInicio { get; set; }
        public bool VIP { get; set; }
        public bool Poliqueixoso { get; set; }
        public string NomeResponsavel { get; set; }
        public int? IdParentesco { get; set; }
        public string Telefone { get; set; }
        public int? IdCepRH { get; set; }

        public string NumeroEndereco { get; set; }
        public string ComplementoEndereco { get; set; }
        public string ReferenciaEndereco { get; set; }

        public int? IdPreferenciaAtendimento { get; set; }
        public int? IdPreferenciaPorteFisico { get; set; }
        public int? IdPreferenciaReligiao { get; set; }
        public int? IdPreferenciaRaca { get; set; }
        public int? IdPreferenciaFumante { get; set; }
        public char PreferenciaSexo { get; set; }

        public int? IdComplexidadeHC { get; set; }
        public int? IdOpcaoRefeicaoHC { get; set; }

        public int? IdRelogio { get; set; }
        public int? IdMotivoAlta { get; set; }
        public DateTime? DataAlta { get; set; }

        public bool SituacaoMarcacao { get; set; }


        public override Entity WithId(int id)
        {
            Id = id;
            return this;
        }
    }
}
