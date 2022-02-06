using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DutchTreat.Data.Entities;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Data
{
  public class DutchRepository : IDutchRepository
  {
    private readonly DutchContext _ctx;

    public DutchRepository(DutchContext ctx) 
    {
      _ctx = ctx;
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _ctx.Products
                .OrderBy(p => p.Id)
                   .ToList();

    }

   

    public bool SaveAll()
    {
      return _ctx.SaveChanges() > 0;
    }
  }
}
