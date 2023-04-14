using System;
using WebApplication1.Models;
using WebApplication1.Models.ViewModels;

namespace WebApplication1.Models
{
	public interface IMummyRepository
	{
        public IQueryable<Burialmain> WebApplication1 { get; }

        public IQueryable<Mummy> GetBurials(Dictionary<string, string?>? burialParams = null);
    }
}

