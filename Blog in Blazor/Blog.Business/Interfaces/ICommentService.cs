using Blog.Business.DTOs;

namespace Blog.Business.Interfaces
{
    public interface ICommentService
    {
        Task<List<CommentDTO>> GetAllAsync(int id);
        Task CreateAsync(CommentDTO commentDTO);

        Task DeleteAsync(int id);

        Task<CommentDTO> GetByIdAsync(int id);

    }
}
