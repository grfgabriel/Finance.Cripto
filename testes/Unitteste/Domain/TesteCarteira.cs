using System;
using Domain;
using Domain.ChildEntity;
using Domain.ValueObject;
using FluentAssertions;
using Xunit;

namespace Unitteste
{
    public class TesteCarteira
    {
        [Theory]
        [InlineData(TipoCarteira.Acoes)]
        [InlineData(TipoCarteira.Cripto)]
        [InlineData(TipoCarteira.FundosImobiliarios)]
        public void DeveCriarCarteiraComOTipoEspecifico(TipoCarteira tipoCarteira)
        {
            Carteira carteira = new Carteira(tipoCarteira);

            carteira.Should().NotBeNull();
            carteira.Ativos.Should().BeEmpty();
            carteira.TipoCarteira.Should().Be(tipoCarteira);
        }
        [Fact]
        public void DeveAdicionarNovoAtivoNaCarteira()
        {
            Carteira carteira = new Carteira(TipoCarteira.Cripto);
            Ativo ativo = new Ativo("BitCoin", TipoAtivo.Cripto, 40000.00M, 1, null);

            carteira.AdicionarAtivo(ativo);

            carteira.Ativos.Should().NotBeNullOrEmpty();
            carteira.Ativos.Count.Should().Be(1);
        }

        [Fact]
        public void DeveRealizarOCalculoDaQuantidadeTotalQuandoAdicionarUmNovoAtivo()
        {
            Carteira carteira = new Carteira(TipoCarteira.Cripto);
            Ativo ativo = new Ativo("BitCoin", TipoAtivo.Cripto, 40000.00M, 1, null);

            carteira.AdicionarAtivo(ativo);

            carteira.Ativos.Should().NotBeNullOrEmpty();
            carteira.Ativos.Count.Should().Be(1);
            carteira.QuantidadeTotal.Should().BeGreaterOrEqualTo(ativo.Quantidade);
        }


        [Fact]
        public void DeveRealizarOCalculoDoValorTotalBrutoQuandoAdicionarUmNovoAtivo()
        {
            decimal quantidade = 0.00001520M;
            decimal valorUnitarioDoAtivoNaCompra = 40000.00M;
            Carteira carteira = new Carteira(TipoCarteira.Cripto);
            Ativo ativo = new Ativo("BitCoin", TipoAtivo.Cripto,valorUnitarioDoAtivoNaCompra ,quantidade , null);

            carteira.AdicionarAtivo(ativo);

            carteira.Ativos.Should().NotBeNullOrEmpty();
            carteira.Ativos.Count.Should().Be(1);
            carteira.QuantidadeTotal.Should().BeGreaterOrEqualTo(ativo.Quantidade);

            decimal valorTotalBruto = valorUnitarioDoAtivoNaCompra/quantidade;
            carteira.ValorTotalBruto.Should().BeGreaterOrEqualTo(valorTotalBruto);
        }
    }
}
