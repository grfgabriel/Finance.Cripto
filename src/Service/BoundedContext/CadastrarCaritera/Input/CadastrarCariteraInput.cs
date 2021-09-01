using Domain.ChildEntity;
using MediatR;
using Service.BoundedContext.CadastrarCaritera.Output;

namespace Service.BoundedContext.CadastrarCaritera.Input
{
    public class CadastrarCariteraInput: IRequest<CadastrarCariteraOutput> 
    {
        public TipoCarteira tipoCarteira {get;set;}
    }
}