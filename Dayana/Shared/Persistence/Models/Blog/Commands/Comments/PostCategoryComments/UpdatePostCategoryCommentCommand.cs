﻿using FluentValidation;

namespace Dayana.Shared.Persistence.Models.Blog.Commands.Blog.Comments.PostCategoryComments;


public class UpdatePostCategoryCommentCommandValidator : AbstractValidator<UpdatePostCategoryCommentCommand>
{
    public UpdatePostCategoryCommentCommandValidator()
    {
        //RuleFor(x => x.PermissionIds)
        //    .NotEmpty()
        //    .WithState(_ => PermissionErrors.InvalidPermissionIdValidationError);

        //RuleFor(x => x.Title)
        //    .MaximumLength(Defaults.NameLength)
        //    .WithState(_ => CommonErrors.InvalidTitleValidationError);

        //RuleFor(x => x.Title)
        //    .NotEmpty()
        //    .WithState(_ => CommonErrors.InvalidTitleValidationError);
    }
}