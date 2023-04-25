using MyFirstDemo.Api.Models.Domain;
using System.Net;

namespace MyFirstDemo.Api.Repositories
{
    public interface IImageRepository
    {
        Task<Image> Upload(Image image);
    }
}
