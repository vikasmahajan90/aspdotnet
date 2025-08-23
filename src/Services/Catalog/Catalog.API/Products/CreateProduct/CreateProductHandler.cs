﻿using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price,
    string ImageFile,
    List<string> Category
    ): ICommand<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    public class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
    {
        public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
        {
            if(command is not null)
                ArgumentNullException.ThrowIfNull(command, nameof(command));

            var productEntity = new Product
            {
                Name = command!.Name,
                Description = command.Description,
                Price = command.Price,
                ImageFile = command.ImageFile,
                Category = command.Category
            };

            return new CreateProductResult(Guid.NewGuid());

        }
    }
}
