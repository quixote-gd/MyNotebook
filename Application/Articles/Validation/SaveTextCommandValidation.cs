using Application.Articles.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Articles.Validation
{
    public class SaveTextCommandValidation : AbstractValidator<SaveArticleCommand>
    {
        public SaveTextCommandValidation() 
        {
        
        }
    }
}
