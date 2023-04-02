using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace CadastroDeEquipamentos.ConsoleApp
{
    public class ChamadoManutencao
    {
        public string titulo { get; set; }
        public string descricao { get; set; }
        public Equipamento equipamento { get; set; }
        public DateTime dataAbertura { get; set; }

        public ChamadoManutencao() { }

        public ChamadoManutencao(string titulo, string descricao, Equipamento equipamento, DateTime dataAbertura)
        {
            titulo = titulo;
            descricao = descricao;
            equipamento = equipamento;
            dataAbertura = dataAbertura;
        }

        public string GetInfoChamado(Equipamento equipamento)
        {
            TimeSpan diasAberto = DateTime.Now - dataAbertura;
            return $"Título: {titulo}\nEquipamento: {equipamento.nome}\nData de abertura: {dataAbertura.ToShortDateString()}\nDias aberto: {diasAberto.Days}";
        }

        public void EditarChamado(string novoTitulo, string novaDescricao, Equipamento novoEquipamento, DateTime novaDataAbertura)
        {
            titulo = novoTitulo;
            descricao = novaDescricao;
            equipamento = novoEquipamento;
            dataAbertura = novaDataAbertura;
        }

        public void RemoverChamado(List<ChamadoManutencao> listaChamados, ChamadoManutencao chamado)
        {
            listaChamados.Remove(chamado);
        }

        public void ExcluirChamado(List<ChamadoManutencao> listaChamados)
        {
            Console.WriteLine("Digite o título do chamado que deseja excluir: ");
            string tituloDigitado = Console.ReadLine();

            //Procura o chamado que tem na listaChamados e compara
            //se o titulo do chamado é igual ao título digitado pelo usuário
            //o método FirstOrDefault busca em uma lista, como um foreach.
            ChamadoManutencao chamado = listaChamados.FirstOrDefault(c => c.titulo == tituloDigitado);

            //Se o chamado for encontrado
            if (chamado != null)
            {
                this.RemoverChamado(listaChamados, chamado);
                Console.WriteLine("Chamado excluído com sucesso.");
            }
            else
            {
                Console.WriteLine("Chamado não encontrado na lista de chamados.");
            }
        }


    }
}
