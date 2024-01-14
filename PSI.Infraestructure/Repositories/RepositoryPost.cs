using PSI.Application.Interface;
using PSI.Domain.Models;

namespace PSI.Infraestructure.Repositories
{
    public class RepositoryPost : RepositoryImplementation<Post>, IRepositoryPost
    {
        public RepositoryPost(PSIContext _PSIContext) : base(_PSIContext)
        {
        }
    }
}
