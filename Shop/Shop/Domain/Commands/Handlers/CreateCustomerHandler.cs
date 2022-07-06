using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Commands.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse> //ICreateCustomerHandler
    {
        // se usasse a interface

        //public CreateCustomerResponse Handle(CreateCustomerRequest request)
        //{
        //    // Verificar se o cliente está cadastrado
        //    // Validar os dados
        //    // Insere Cliente
        //    // Algumas regras de negócio

        //    return new CreateCustomerResponse
        //    {
        //        Id = Guid.NewGuid(),
        //        Name = "TesteNome",
        //        Email = "teste@teste.com",
        //        Date = DateTime.Now
        //    };
        //}

        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            // Verificar se o cliente está cadastrado
            //    // Validar os dados
            //    // Insere Cliente
            //    // Algumas regras de negócio

            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "TesteNome",
                Email = "teste@teste.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
