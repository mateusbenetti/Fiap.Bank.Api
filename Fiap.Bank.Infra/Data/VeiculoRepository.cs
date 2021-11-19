using Fiap.Bank.Infra.Data.Entities;
using Fiap.Bank.Infra.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Threading.Tasks;

namespace Fiap.Bank.Infra.Data
{
    [ExcludeFromCodeCoverage]
    public sealed class VeiculoRepository : IVeiculoRepository
    {
        private readonly IMongoCollection<VeiculoEntity> _veiculos;

        public VeiculoRepository(IMongoCollection<VeiculoEntity> veiculos)
        {
            _veiculos = veiculos;
        }

        public async Task<AddVeiculoResult> CriarVeiculosAsync(CancellationToken cancellationToken)
        {
            var veiculoCollection = new VeiculoEntity[]
            {
                new VeiculoEntity { Id = Guid.NewGuid(), Ano = 2021, Marca = "Volkswagen", Modelo = "CG", Placa = "NAT-1004", Tipo = TipoVeiculo.Carro, DataCadastro = DateTime.Now },
                new VeiculoEntity { Id = Guid.NewGuid(), Ano = 2010, Marca = "Chevrolet", Modelo = "CG", Placa = "MTS-1685", Tipo = TipoVeiculo.Carro, DataCadastro = DateTime.Now },
                new VeiculoEntity { Id = Guid.NewGuid(), Ano = 2020, Marca = "Honda", Modelo = "CG", Placa = "HBG-1249", Tipo = TipoVeiculo.Moto, DataCadastro = DateTime.Now }
            };
            try
            {
                foreach (var veiculo in veiculoCollection)
                {
                    await _veiculos.InsertOneAsync(veiculo, new InsertOneOptions { }, cancellationToken)
                        .ConfigureAwait(false);
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

        public async Task<List<VeiculoEntity>> ListarVeiculosAsync(CancellationToken cancellationToken)
        {
            var veiculos = await _veiculos
                .AsQueryable().ToListAsync(cancellationToken)
                .ConfigureAwait(false);

            return veiculos;
        }
    }
}