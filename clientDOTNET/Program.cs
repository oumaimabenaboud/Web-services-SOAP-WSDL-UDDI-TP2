﻿// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        ServiceReference1.BanqueServiceClient stub =

        new ServiceReference1.BanqueServiceClient();

        Console.WriteLine("-------- Conversion ---------");
        Console.WriteLine(stub.Convert(77));
        Console.WriteLine("-------- Consulter un Compte ---------");
        ServiceReference1.compte cp = stub.getCompte(2);
        Console.WriteLine("Solde=" + cp.solde);
        Console.WriteLine("-------- Liste des comptes ---------");
        ServiceReference1.compte[] cptes = stub.listComptes();
        for (int i = 0; i < cptes.Length; i++)
        {
            Console.WriteLine(cptes[i].code + "-----" + cptes[i].solde);
        }

        Console.ReadLine();

    }
}