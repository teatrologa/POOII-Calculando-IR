using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Telas
{
    public class InfoTela
    {
        public const string tabelaImposto = @"
  -------------------------------------------------------
    Faixas de Valor ($)	          Aliquota	 Deduzir
  -------------------------------------------------------
  Até 22.847,76	                   Isento       Isento
  De 22.847,77 a 33.919,80	   0,075	1.713,58
  De R$ 33.919,81 a 45.012,60	   0,150	4.257,57
  De R$ 45.012,61 a 55.976,16	   0,225	7.633,51
  Acima de 55.976,16	           0,275	10.432,32

";

        public const string explicacaoCalculoImposto = @" Primeiro você deve encontrar qual é a faixa de valor correspondente a
 sua renda anual bruta. Depois, realizar o calculo abaixo com os valores de
 aliquota e dedução respestivas.
";

        public const string calculoImposto = @" Imposto a ser pago = (Renda anual bruta * Aliquota) - Dedução de valor
";
    }
}
