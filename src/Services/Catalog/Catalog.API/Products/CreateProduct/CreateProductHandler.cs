﻿using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price,
    string ImageFile,
    List<string> Category
    ): IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductHandler : IRequestHandler<CreateProductCommand, CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
