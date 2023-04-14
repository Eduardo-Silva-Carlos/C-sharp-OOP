using System;

namespace Atividades
{
    class Program
    {
        static void Main(String[] args)
        {
            float val_pag;
            Console.WriteLine("Informar o nome : ");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Infomar o endereço : ");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Pessoa física (f) ou Jurídica (j) ? ");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                //----------Pessoa Física----------
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar o CPF ");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar o RG ");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar o valor da comprar");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("---------Pessoa Física----------");
                Console.WriteLine("Nome..........: " + pf.nome);
                Console.WriteLine("Endereço......: " + pf.endereco);
                Console.WriteLine("CPF...........: " + pf.cpf);
                Console.WriteLine("RG............: " + pf.rg);
                Console.WriteLine("Valor de comprar : " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto.......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar : " + pf.total.ToString("C"));
            }


            if (var_tipo == "j")
            {
                //--------Pessao jurídica------------
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ : ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar Inscrição Estadual: ");
                pj.inscricao_estadual = Console.ReadLine();
                Console.WriteLine("Inforar valor de compra : ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("---------Pessoa Jurídica----------");
                Console.WriteLine("Nome........: " + pj.nome);
                Console.WriteLine("Endereço....: " + pj.endereco);
                Console.WriteLine("Inscrição Estadual : " + pj.inscricao_estadual);
                Console.WriteLine("Valor de compra : " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto.....: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total a pagar : " + pj.total.ToString("C"));
            }
            else
            {
                Console.Write("Favor digitar a opção correta! ");
            }
        }
    }
}
