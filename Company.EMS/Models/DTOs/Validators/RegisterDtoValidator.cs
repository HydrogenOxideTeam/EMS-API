﻿using FluentValidation;

namespace Company.EMS.Models.DTOs.Validators;

/// <summary>
/// 
/// </summary>
public abstract class RegisterDtoValidator : AbstractValidator<RegisterDto>
{
    /// <summary>
    /// 
    /// </summary>
    public RegisterDtoValidator()
    {
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.FirstName).NotEmpty().MinimumLength(2).MaximumLength(20);
        RuleFor(x => x.LastName).NotEmpty().MinimumLength(3).MinimumLength(30);
        RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
        RuleFor(x => x.Password).Equal(x => x.PasswordConfirmation);
    }
}