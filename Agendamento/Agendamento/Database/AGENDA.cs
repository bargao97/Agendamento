//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Agendamento.Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class AGENDA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AGENDA()
        {
            this.EMAIL = new HashSet<EMAIL>();
            this.TELEFONE = new HashSet<TELEFONE>();
        }
    
        public int ID_AGENDA { get; set; }
        public string NOME { get; set; }
        public string TEL_PRINCIPAL { get; set; }
        public string TIPO_TEL_PRINCIPAL { get; set; }
        public string CEP_RESIDENCIAL { get; set; }
        public string UF_RESIDENCIAL { get; set; }
        public string LOCALIDADE_RESIDENCIAL { get; set; }
        public string LOGRADOURO_RESIDENCIAL { get; set; }
        public string NUMERO_RESIDENCIAL { get; set; }
        public string COMPLEMENTO_RESIDENCIAL { get; set; }
        public string BAIRRO_RESIDENCIAL { get; set; }
        public string NOME_EMPRESA { get; set; }
        public string CARGO_EMPRESA { get; set; }
        public string CEP_EMPRESA { get; set; }
        public string UF_EMPRESA { get; set; }
        public string LOCALIDADE_EMPRESA { get; set; }
        public string LOGRADOURO_EMPRESA { get; set; }
        public string NUMERO_EMPRESA { get; set; }
        public string COMPLEMENTO_EMPRESA { get; set; }
        public string BAIRRO_EMPRESA { get; set; }
        public string FLAG_EXCLUIDO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EMAIL> EMAIL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TELEFONE> TELEFONE { get; set; }
    }
}