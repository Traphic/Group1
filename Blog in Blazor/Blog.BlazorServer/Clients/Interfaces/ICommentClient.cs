using System.Threading.Tasks;
using Blog.BlazorServer.ViewModels;

namespace Blog.BlazorServer.Clients.Interfaces
{
    public interface ICommentClient
    {
        Task<List<CommentViewModel>> GetAllByPostIdAsync(int id);
        Task<HttpResponseMessage> AddAsync(CommentViewModel commentDTO);

        Task<HttpResponseMessage> DeleteAsync(int id);
    }
}
