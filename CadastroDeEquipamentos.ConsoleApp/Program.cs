using System;
using System.Security.Cryptography.X509Certificates;
using CadastroDeEquipamentos.ConsoleApp;

namespace CadastroDeEquipamentos
{
	public class Program
	{
        public static void Main(string[] args) { 

            // Criando um novo equipamento
            Equipamento meuEquipamento = new Equipamento("Meu Equipamento", 1000.0m, "123456789", DateTime.Now, "Fabricante XYZ");

            //Criando alguns equipamentos
            Equipamento equipamento1 = new Equipamento("Equipamento 1", 2000.0m, "123456789", DateTime.Now, "Fabricante XYZ");
            Equipamento equipamento2 = new Equipamento("Equipamento 2", 3000.0m, "987654321", DateTime.Now, "Fabricante ABC");


            //Requisito 1.2
            // Adicionando os equipamentos a uma lista
            List<Equipamento> listaEquipamentos = new List<Equipamento>();
            listaEquipamentos.Add(equipamento1);
            listaEquipamentos.Add(equipamento2);

            //// Exibindo os equipamentos registrados
            foreach (Equipamento e in listaEquipamentos)
            {
                Console.WriteLine(e.ToString());
            }


            //Requisito 1.3
            // Criando um equipamento
            Equipamento equipamento3 = new Equipamento("Equipamento 3", 2000.0m, "123456789", DateTime.Now, "Fabricante XYZ");

            // Adicionando o equipamento a uma lista
            List<Equipamento> listaEquipamentos2 = new List<Equipamento>();
            listaEquipamentos2.Add(equipamento3);
            
            // Editando o equipamento
            equipamento3.EditarEquipamento("Novo Equipamento", 2500.0m, "987654321", DateTime.Now.AddDays(-365), "Novo Fabricante");

            // Exibindo o equipamento editado
            Console.WriteLine(equipamento3.ToString());


            //Requisito 1.4
            //Criando dois equipamentos
            Equipamento equipamento4 = new Equipamento("Equipamento 4", 2000.0m, "123456789", DateTime.Now, "Fabricante XYZ");
            Equipamento equipamento5 = new Equipamento("Equipamento 5", 1500.0m, "987654321", DateTime.Now.AddDays(-365), "Fabricante ABC");

            // Adicionando os equipamentos a uma lista
            List<Equipamento> listaEquipamentos3 = new List<Equipamento>();
            listaEquipamentos3.Add(equipamento4);
            listaEquipamentos3.Add(equipamento5);

            // Excluindo o equipamento 2
            Equipamento.ExcluirEquipamento(listaEquipamentos3, equipamento5);

            // Exibindo o inventário atualizado
            foreach (Equipamento eq in listaEquipamentos3)
            {
                Console.WriteLine(eq.ToString());
            }


            //Requisito 2.1
            //// Criando um equipamento
            Equipamento equipamento = new Equipamento("Equipamento 1", 2000.0m, "123456789", DateTime.Now, "Fabricante XYZ");

            //// Criando um chamado de manutenção para o equipamento
            ChamadoManutencao chamado = new ChamadoManutencao("Chamado 1", "Descrição do chamado 1", equipamento, DateTime.Now);

            //// Exibindo as informações do chamado
            Console.WriteLine(chamado.titulo);
            Console.WriteLine(chamado.descricao);
            Console.WriteLine(chamado.equipamento);
            Console.WriteLine(chamado.dataAbertura);


            //Requisito 2.2
            //Criando uma lista de chamados de manutenção
            List<ChamadoManutencao> chamados = new List<ChamadoManutencao>();

            // Adicionando um chamado de manutenção à lista
            Equipamento equipamento6 = new Equipamento("Equipamento 6", 2000.0m, "123456789", DateTime.Now, "Fabricante XYZ");
            ChamadoManutencao chamado1 = new ChamadoManutencao("Chamado 1", "Descrição do chamado 1", equipamento6, DateTime.Now.AddDays(-5));
            chamados.Add(chamado1);

            // Exibindo as informações dos chamados
            foreach (ChamadoManutencao c in chamados)
            {
               Console.WriteLine(c.GetInfoChamado(c.equipamento));
            }


            //Requisito 2.3
            // Criando um equipamento
            Equipamento equipamento7 = new Equipamento("Equipamento 7", 2000.0m, "123456789", DateTime.Now, "Fabricante XYZ");

            // Cria um chamado
            ChamadoManutencao chamado2 = new ChamadoManutencao("Chamado 2", "Descricao do Chamado", equipamento, DateTime.Now);

            //// Adicionando o chamado a uma lista
            List<ChamadoManutencao> listaChamados = new List<ChamadoManutencao>();
            listaChamados.Add(chamado2);

            // Editando um chamado
            chamado2.EditarChamado("Novo título do chamado", "Nova descrição", equipamento, DateTime.Now);

            //// Exibindo o equipamento editado
            Console.WriteLine(chamado2.GetInfoChamado(equipamento));


            //Requisito 2.4
            List<ChamadoManutencao> listaChamados2 = new List<ChamadoManutencao>();

            // Criando um equipamento
            Equipamento e1 = new Equipamento("Equipamento 1", 2000.0m, "123456789", DateTime.Now, "Fabricante XYZ");
        
            // Cria um chamado
            ChamadoManutencao c1 = new ChamadoManutencao("Chamado 1", "Descricao do Chamado", e1, DateTime.Now);

            c1.ExcluirChamado(listaChamados2);

        }
    }
}