//Requisito 1.1: Como funcionário, Junior quer ter a possibilidade de registrar equipamentos  
//         •  Deve ter um nome com no mínimo 6 caracteres;  [x]
//         •  Deve ter um preço de aquisição;  [x]
//         •  Deve ter um número de série;  [x]
//         •  Deve ter uma data de fabricação; [x]  
//         •  Deve ter uma fabricante; [x]
namespace CadastroDeEquipamentos.ConsoleApp
{
    public class Equipamento
    {
        public string nome { get; set; }
        public decimal precoAquisicao { get; set; }
        public string numeroSerie { get; set; }
        public DateTime dataFabricacao { get; set; }
        public string fabricante { get; set; }

        public Equipamento() { }

        public Equipamento(string nome, decimal precoAquisicao, string numeroSerie, DateTime dataFabricacao, string fabricante)
        {
            if (nome.Length < 6)
                throw new ArgumentException("O equipamento deve ter um nome com no mínimo 6 caracteres.");
            

            nome = nome;
            precoAquisicao = precoAquisicao;
            numeroSerie = numeroSerie;
            dataFabricacao = dataFabricacao;
            fabricante = fabricante;
        }

        //Requisito 1.2
        public override string ToString()
        {
            return string.Format("Número: {0}, Nome: {1}, Preço de Aquisição: {2:C}, Fabricante: {3}, Data de Fabricação: {4:d}", this.numeroSerie, this.nome, this.precoAquisicao, this.fabricante, this.dataFabricacao);
        }

        //Requisito 1.3
        public void EditarEquipamento(string novoNome, decimal novoPrecoAquisicao, string novoNumeroSerie, DateTime novaDataFabricacao, string novoFabricante)
        {
            nome = novoNome;
            precoAquisicao = novoPrecoAquisicao;
            numeroSerie = novoNumeroSerie;
            dataFabricacao = novaDataFabricacao;
            fabricante = novoFabricante;
        }

        public static void ExcluirEquipamento(List<Equipamento> listaEquipamentos, Equipamento equipamento)
        {
            listaEquipamentos.Remove(equipamento);
        }


    }

}
