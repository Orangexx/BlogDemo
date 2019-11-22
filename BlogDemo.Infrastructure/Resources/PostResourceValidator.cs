using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BlogDemo.Infrastructure.Resources
{
    public class PostResourceValidator : AbstractValidator<PostResource>
    {
        public PostResourceValidator()
        {
            RuleFor(x => x.Author)
                .NotNull()
                .NotEmpty()
                .WithName("作者")
                .WithMessage("{PropertyName}不能为空")
                .MaximumLength(50)
                .WithMessage("{PropertyName}的最大长度是{MaxLength}");
        }
    }
}