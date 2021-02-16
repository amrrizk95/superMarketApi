using Microsoft.EntityFrameworkCore;
using superMarket.Domain.Models;
using superMarket.Domain.Repositories;
using superMarket.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace superMarket.Persistence.Repositories
{
    public class CategoryRepository: BaseRepository,ICategoryRepository
    {
        public CategoryRepository(AppDbContext context) : base(context)
        {
        }
        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Categories.ToListAsync();
        }
        public async Task AddAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }
    }
}
