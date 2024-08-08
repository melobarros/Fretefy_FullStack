using Fretefy.Test.Domain.Interfaces.Services;
using Fretefy.Test.Infra.EntityFramework.Repositories;
using Fretefy.Test.Domain.Interfaces.Repositories;

namespace Fretefy.Test.Domain.Services
{
    public class RegiaoService : IRegiaoService
    {
        private readonly IRegiaoRepository _regiaoRepository;
        private readonly ICidadeRepository _cidadeRepository;

        public RegiaoService(IRegiaoRepository regiaoRepository, ICidadeRepository cidadeRepository)
        {
            _regiaoRepository = regiaoRepository;
            _cidadeRepository = cidadeRepository;
        }

        
    }
}
