using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.Bookstore.Authors
{
    public interface IAuthorAppService: IApplicationService
    {
        Task<AuthorDto> GetByIdAsync(Guid Id);
        Task<PagedResultDto<AuthorDto>> GetListAsync(GetAuthorListDto input);
        Task<AuthorDto> CreateAsync(CreateAuthorDto input);

        Task UpdateAsync(Guid id, UpdateAuthorDto input);

        Task DeleteAsync(Guid id);
    }
}
