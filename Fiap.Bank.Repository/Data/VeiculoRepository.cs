using Fiap.Bank.Domain.Entities;
using Fiap.Bank.Repository.Interface;
using MongoDB.Driver;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Repository.Data
{
    [ExcludeFromCodeCoverage]
    public class VeiculoRepository : IVeiculoRepository
    {
        private readonly IMongoCollection<Veiculo> _veiculos;

        public VeiculoRepository(IMongoCollection<Veiculo> veiculos)
        {
            _veiculos = veiculos;
        }

        public async Task<AddVeiculoResult> BuildVeiculosAsync(CancellationToken cancellationToken)
        {
            var veiculoCollection = new Veiculo[]
            {
                new Veiculo { Id = System.Guid.NewGuid(), Ano = 2021, Marca = "Volkswagen", Modelo = "CG", Placa = "NAT-1004", Tipo = TipoVeiculo.Carro  },
                new Veiculo { Id = System.Guid.NewGuid(), Ano = 2010, Marca = "Chevrolet", Modelo = "CG", Placa = "MTS-1685", Tipo = TipoVeiculo.Carro },
                new Veiculo { Id = System.Guid.NewGuid(), Ano = 2020, Marca = "Honda", Modelo = "CG", Placa = "HBG-1249", Tipo = TipoVeiculo.Moto }
            };
            try
            {
                foreach (var veiculo in veiculoCollection)
                {
                    await _veiculos.InsertOneAsync(veiculo, new InsertOneOptions { }, cancellationToken);
                }

                return AddVeiculoResult.Sucesso;
            }
            catch (MongoWriteException ex)
            {
                if (ex.WriteError.Category == ServerErrorCategory.DuplicateKey)
                {
                    return AddVeiculoResult.VeiculoDuplicado;
                }
                throw;
            }
        }

        public async Task<List<Veiculo>> ListarVeiculosAsync(CancellationToken cancellationToken)
        {
            var veiculos = await _veiculos
                .AsQueryable().ToListAsync()
                .ConfigureAwait(false);

            return veiculos;
        }
    }
}