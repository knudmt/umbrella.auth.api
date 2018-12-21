using System;
using FluentValidation.Attributes;
using Umbrella.WepApi.Auth.ViewModels.Validators;

namespace Umbrella.WepApi.Auth.ViewModels
{
    [Validator(typeof(CredentialsViewModelValidator))]
    public class CredentialsViewModel
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
