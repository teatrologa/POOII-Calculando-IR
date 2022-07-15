using Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Validacao : IValidacao
    {

        public bool EntradaVazia(string input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }
    }
}
