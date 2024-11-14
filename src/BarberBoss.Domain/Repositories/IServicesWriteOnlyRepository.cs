﻿using BarberBoss.Domain.Entities;

namespace BarberBoss.Domain.Repositories
{
    public interface IServicesWriteOnlyRepository
    {
        Task Add(Service service);
    }
}
