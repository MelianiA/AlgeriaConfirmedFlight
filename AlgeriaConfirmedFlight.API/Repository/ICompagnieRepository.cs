﻿using AlgeriaConfirmedFlight.Shared.Model;

namespace AlgeriaConfirmedFlight.API.Repository
{
    public interface ICompagnieRepository
    {
        public IEnumerable<Compagnie> GetCompagnies();
    }
}
