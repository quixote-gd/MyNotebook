using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using MediatR;

namespace Application.Articles.Queries
{
    public class GetArticleQuery : IRequest<Article>
    {
    }
}
