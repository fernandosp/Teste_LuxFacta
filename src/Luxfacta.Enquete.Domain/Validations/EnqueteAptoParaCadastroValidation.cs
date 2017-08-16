using DomainValidation.Validation;
using Luxfacta.Enquete.Domain.Entities;
using Luxfacta.Enquete.Domain.Interfaces.Repository;
using Luxfacta.Enquete.Domain.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luxfacta.Enquete.Domain.Validations
{
    public class EnqueteAptoParaCadastroValidation : Validator<Poll>
    {
        public EnqueteAptoParaCadastroValidation(IPollRepository pollRepository)
        {
            var enqueteOpcoes = new EnqueteDeveTerOpcoesSpecifications();
            base.Add("EnqueteOpcoes", new Rule<Poll>(enqueteOpcoes, "Cadastro de enquete invalido, é necessario o cadastro de opções  "));
        }
    }
}
