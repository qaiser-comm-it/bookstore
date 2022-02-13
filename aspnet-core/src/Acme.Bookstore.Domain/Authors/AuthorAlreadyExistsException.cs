﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;

namespace Acme.Bookstore.Authors
{
    public class AuthorAlreadyExistsException: BusinessException
    {
        public AuthorAlreadyExistsException(string name): base(BookstoreDomainErrorCodes.AuthorAlreadyExists)
        {
            WithData("name", name);
        }
    }
}
