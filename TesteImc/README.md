# Algoritmo de cálculo de IMC

Algoritmo simples para cálculo de Índice de Massa Corporal (IMC), utilizando conceitos de Orientação a Objetos.

**Funcionalidades**

- Cadastrar novas pessoas para análise
- Listar pessoas cadastradas
- Visualizar informações individualmente



#### Uso da classe PessoaRepositorio como base de dados

O objetivo dessa classe é simular um banco de dados dentro da própria aplicação, por meio de uma lista criada com os dados inseridos.

```c#
private List<Pessoa> ListaPessoa = new List<Pessoa>();
```



#### Uso de método override ToString(); para apresentar informações

Por meio desse método, é apresentado na tela um resumo das informações do usuário cadastrado no sistema, listando as informações cadastradas e retornando tudo como uma variável **string**:

```c#
public override string ToString()
{
    string InformacaoPessoa = "";
    InformacaoPessoa += "Nome: " + this.Nome + Environment.NewLine;
    InformacaoPessoa += "Massa: " + this.Massa.ToString("F1") + Environment.NewLine;
    InformacaoPessoa += "Altura: " + this.Altura.ToString("F2") + Environment.NewLine;
    InformacaoPessoa += "IMC: " + this.IMC.ToString("F1") + Environment.NewLine;
    return InformacaoPessoa;
}
```

O parâmetro **Environment.NewLine** foi utilizado para a quebra de linha, sem a necessidade de setar manualmente como seria realizada (uso de /n ou /r, etc). Ele busca automaticamente qual o ambiente e faz a quebra automática.

**Referência:** <https://docs.microsoft.com/pt-br/dotnet/api/system.environment.newline?view=net-5.0>



#### Switch case com range

Foi utilizada a estrutura de switch case de forma que em determinada sequência de resultado ou de valor, fosse atribuído um rótulo. No caso dessa aplicação, cada faixa de Kg/m² para referência do IMC teria uma definição.

```c#
switch (RecebeImc)
{
    case var n when RecebeImc < 17:
    	Console.WriteLine("O IMC está abaixo de 17kg/m², muito abaixo do peso.");
    	break;
    case var n when RecebeImc >= 17 && RecebeImc < 18:
    	Console.WriteLine("O IMC está na faixa de 17kg/m² a 18kg/m², abaixo do peso.");
        break;
    case var n when RecebeImc >= 18 && RecebeImc < 25:
    	Console.WriteLine("O IMC está na faixa de 18kg/m² a 25kg/m², peso normal.");
    	break;
    case var n when RecebeImc >= 25 && RecebeImc < 30:
    	Console.WriteLine("O IMC está na faixa de 25kg/m² a 30kg/m², acima do peso.");
    	break;
    case var n when RecebeImc >= 30 && RecebeImc < 35:
    	Console.WriteLine("O IMC está na faixa de 30kg/m² a 35kg/m², obesidade grau I.");
    	break;
    case var n when RecebeImc >= 35 && RecebeImc < 40:
        Console.WriteLine("O IMC está na faixa de 35kg/m² a 40kg/m², obesidade grau II.");
        break;
    case var n when RecebeImc >= 40:
    	Console.WriteLine("O IMC está acima de 40kg/m², obesidade grau III.");
    	break;
    default:
    	break;
}
```

**Referência:** <https://stackoverflow.com/questions/20147879/switch-case-can-i-use-a-range-instead-of-a-one-number>



### *Links para referência*

- <https://www.uol.com.br/vivabem/faq/imc-como-calcular-tabela-dicas-como-melhorar-e-mais.htm?next=0001H1880U47N>
- <https://pubmed.ncbi.nlm.nih.gov/22804918/>

