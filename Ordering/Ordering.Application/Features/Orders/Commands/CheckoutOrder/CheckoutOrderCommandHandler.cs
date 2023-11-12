using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using Ordering.Application.Contracts.Infrastructure;
using Ordering.Application.Contracts.Persistence;
using Ordering.Application.Models;
using Ordering.Application.Models.Dtos;
using Ordering.Application.Models.Invariant;
using Ordering.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommandHandler : IRequestHandler<CheckoutOrderCommand, ResponseResult<int>>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;
        private  IModelConstraint modelConstraint;

        public CheckoutOrderCommandHandler(IOrderRepository orderRepository, IMapper mapper, IEmailService emailService, ILogger<CheckoutOrderCommandHandler> logger, IModelConstraint modelConstraint)
        {
            _orderRepository = orderRepository ?? throw new ArgumentNullException(nameof(orderRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _emailService = emailService ?? throw new ArgumentNullException(nameof(emailService));
            this.modelConstraint = modelConstraint;
        }

        public async Task<ResponseResult<int>> Handle(CheckoutOrderCommand request, CancellationToken cancellationToken)
        {
            modelConstraint = new LessThan_5000_Constraint(modelConstraint);
            modelConstraint = new PermitedTimeConstraint(modelConstraint);
            if (modelConstraint.IsSatisfied().isValid)
            {
                var orderEntity = _mapper.Map<Order>(request);

                var newOrder = await _orderRepository.AddAsync(orderEntity);
                return new ResponseResult<int>
                {
                    IsSucess = true,
                    Value = newOrder.Id
                };
            }
            else
            {
                return
                    new ResponseResult<int>()
                    {
                        IsSucess = false,
                        Message = modelConstraint.IsSatisfied().contraintErrorTypes.ToString()
                    };
            }
         
            
        
        }

       
    }
}
