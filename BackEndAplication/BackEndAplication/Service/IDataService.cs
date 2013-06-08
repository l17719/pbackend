using System;
using System.Collections.ObjectModel;
using BackEndAplication.Models;
using BackEndAplication.Models.TerminalDBModel;
using Caliburn.Micro;

namespace BackEndAplication.Service
{
    internal interface IDataService
    {
        BindableCollection<string> GetDataBasesFromInstance(string valueInstance);
        BindableCollection<TbTerminal> LoadTerminais();
        BindableCollection<TbOpcoesTerminal> LoadOpcoesTerminal();
        BindableCollection<string> LoadFiltrosClientes();
        BindableCollection<string> LoadFiltrosStocks();
        BindableCollection<int> CarregaDossiersInternos();
        BindableCollection<int> LoadVendedores();
       

        string SetNomeVendedor(int valueNumVendedor);
        string GetNomeDossier(int valueDossier);
        int DevolveValorDesconto(decimal value);
        string GetIniciaisPhc(int value);
        bool CreateTerminal(TbTerminal valuet, TbOpcoesTerminal valueOp);
        void UpdateTerminal(TbTerminal value, TbOpcoesTerminal valueop);
        void DeleteTerminal(Guid value);


        void LoadBulkData();
        string DevolveStampFiltroClientes(string value);
        string DevolveStampFiltroStocks(string value);
        decimal DevolveArmazem(int value);
        ///mock data
        ObservableCollection<Terminal> LoadMockTerminals();

        void CreateMockTerminal(Terminal value);
        void UpdateTerminal(Terminal value);
        void DeleteMockTerminal(Terminal vaue);
        //
    }
}