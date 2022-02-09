// This file is automatically generated by ABP framework to use MVC Controllers from CSharp
using System;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Http.Client;
using Volo.Abp.Http.Modeling;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Http.Client.ClientProxying;
using BookStore.Books;

// ReSharper disable once CheckNamespace
namespace BookStore.Books.ClientProxies;

[Dependency(ReplaceServices = true)]
[ExposeServices(typeof(IBookV3AppService), typeof(BookV3ClientProxy))]
public partial class BookV3ClientProxy : ClientProxyBase<IBookV3AppService>, IBookV3AppService
{
    public virtual async Task<BookDto> GetAsync()
    {
        return await RequestAsync<BookDto>(nameof(GetAsync));
    }

    public virtual async Task<BookDto> GetAsync(string isbn)
    {
        return await RequestAsync<BookDto>(nameof(GetAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), isbn }
        });
    }

    public virtual async Task DeleteAsync(string title)
    {
        await RequestAsync(nameof(DeleteAsync), new ClientProxyRequestTypeValue
        {
            { typeof(string), title }
        });
    }
}
