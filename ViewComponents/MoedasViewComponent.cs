using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PesquisaCrypto.Models;

namespace PesquisaCrypto.ViewComponents
{
    public class MoedasViewComponent : ViewComponent
    {
        private readonly MoedaContext _moedaContext;

        public MoedasViewComponent(MoedaContext moedaContext)
        {
            _moedaContext = moedaContext;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _moedaContext.Moedas.ToListAsync());
        }
    }
}
