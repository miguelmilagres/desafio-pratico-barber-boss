﻿using BarberBoss.Communication.Requests;
using BarberBoss.Communication.Responses;

namespace BarberBoss.Application.Services.Register
{
    public class RegisterServiceUseCase
    {
        public ResponseRegisteredServiceJson Execute(RequestRegisterServiceJson request)
        {
            Validate(request);

            return new ResponseRegisteredServiceJson();
        }

        private void Validate(RequestRegisterServiceJson request)
        {
            var validator = new RegisterServiceValidator();

            var result = validator.Validate(request);
        }
    }
}
