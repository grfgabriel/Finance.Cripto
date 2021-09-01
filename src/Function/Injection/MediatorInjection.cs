using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Service.UseCase;


namespace Function.Injection
{
    public static class MediatorInjection
    {
        public static void AdicionarMediatR(this IServiceCollection servico)
        {
            servico.AddMediatR(typeof(CadastrarCaritera));
        }
    }

}
