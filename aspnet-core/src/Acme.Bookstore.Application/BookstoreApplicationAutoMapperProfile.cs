﻿using Acme.Bookstore.Books;
using AutoMapper;

namespace Acme.Bookstore;

public class BookstoreApplicationAutoMapperProfile : Profile
{
    public BookstoreApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        CreateMap<Book, BookDto>();
        CreateMap<CreateUpdateBookDto, Book>();
    }
}
