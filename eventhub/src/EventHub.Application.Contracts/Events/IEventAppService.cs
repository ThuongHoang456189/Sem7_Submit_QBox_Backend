﻿using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace EventHub.Events
{
    public interface IEventAppService : IApplicationService
    {
        Task CreateAsync(CreateEventDto input);
    }
}