using Acme.Bookstore.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;
using System.Linq.Dynamic.Core;

namespace Acme.Bookstore.Authors
{
    public class EfCoreAuthorRepository : EfCoreRepository<BookstoreDbContext, Author, Guid>, IAuthorRepository
    {
        public EfCoreAuthorRepository(IDbContextProvider<BookstoreDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Author> FindByNameAsync(string name)
        {
            var dbset = await GetDbSetAsync();
            return await dbset.FirstOrDefaultAsync(author => author.Name == name);
        }

        public async Task<List<Author>> GetListAsync(int skipCount, int maxResultCount, string sorting, string filter = null)
        {
            var dbset = await GetDbSetAsync();
            return await dbset.WhereIf(!filter.IsNullOrWhiteSpace(), author => author.Name.Contains(filter))
                .OrderBy(sorting)
                .Skip(skipCount)
                .Take(maxResultCount)
                .ToListAsync();
        }
    }
}
