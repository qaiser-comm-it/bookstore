using Acme.Bookstore.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Acme.Bookstore;

[DependsOn(
    typeof(BookstoreEntityFrameworkCoreTestModule)
    )]
public class BookstoreDomainTestModule : AbpModule
{

}
