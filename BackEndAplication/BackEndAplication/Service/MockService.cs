using System;
using System.Collections.ObjectModel;
using System.Globalization;
using BackEndAplication.Models;

namespace BackEndAplication.Service
{
    public class MockService : IMockData
    {
        #region Implementation of IMockData

        public ObservableCollection<Terminal> GenerateMockData()
        {
            int i = 0;
            var resultado = new ObservableCollection<Terminal>();
            while (i < 150)
            {
                resultado.Add(new Terminal
                                  {
                                      TerminalId = "Terminal " + i.ToString(CultureInfo.InvariantCulture),
                                      ArmazemEnvio = "Armazem Envio: " + i.ToString(CultureInfo.InvariantCulture),
                                      ArmazemRegisto = "Armazem Registo: " + i.ToString(CultureInfo.InvariantCulture),
                                      DossierInterno = GenerateGuid(),
                                      NomeVendedor = GenerateGuid(),
                                      NumeroClienteFinal = 1000,
                                      NumeroClienteInicial = 0,
                                      NumeroEncomendasFinal = 1000,
                                      NumeroEncomendasInicial = 0
                                  });
                i++;
            }
            return resultado;
        }

        #endregion

        private string GenerateGuid()
        {
            Guid id = Guid.NewGuid();
            return id.ToString();
        }
    }
}