using PlusClouds.Net.Request.Users;
using PlusClouds.Net.Response.Shared;
using PlusClouds.Net.Response.Users;
using RestSharp;

namespace PlusClouds.Net.Resources
{
    public class Users : BaseResource
    {
        private const string authenticate = "users/authenticate";
        private const string getSession = "users/get-session";
        private const string create = "users/create";
        private const string destroySession = "users/destroy-session";
        private const string activate = "users/activate";
        private const string update = "users/update";
        private const string changePassword = "users/change-password";
        private const string forgotPassword = "users/forgot-password";

        public Users(PlusClouds plusClouds) : base(plusClouds)
        {
        }

        public UserAuthenticateResponse Authenticate(UserAuthenticateRequest userAuthenticateRequest)
        {
            return PlusClouds.Execute<UserAuthenticateResponse>(authenticate, Method.POST, userAuthenticateRequest);
        }

        public UserSessionResponse GetSession(UserGetSessionRequest userGetSessionRequest)
        {
            return PlusClouds.Execute<UserSessionResponse>(getSession, Method.GET, userGetSessionRequest);
        }

        public bool DestroySession()
        {
            return PlusClouds.Execute(destroySession, Method.GET).ResponseStatus == ResponseStatus.Completed;
        }

        public UserCreateResponse Create(UserCreateRequest userCreateRequest)
        {
            return PlusClouds.Execute<UserCreateResponse>(create, Method.POST, userCreateRequest);
        }

        public UpdateResponse Activate(UserActivationRequest userActivationRequest)
        {
            return PlusClouds.Execute<UpdateResponse>(activate, Method.POST, userActivationRequest);
        }

        public UpdateResponse Update(UserUpdateRequest userUpdateRequest)
        {
            return PlusClouds.Execute<UpdateResponse>(update, Method.POST, userUpdateRequest);
        }

        public UpdateResponse ChangePassword(UserChangePasswordRequest userChangePasswordRequest)
        {
            return PlusClouds.Execute<UpdateResponse>(changePassword, Method.POST, userChangePasswordRequest);
        }

        public UpdateResponse ForgotPassword(UserForgotPasswordRequest userForgotPasswordRequest)
        {
            return PlusClouds.Execute<UpdateResponse>(forgotPassword, Method.POST, userForgotPasswordRequest);
        }

        public UpdateResponse ForgotPassword(UserForgotPasswordConfirmRequest userForgotPasswordConfirmRequest)
        {
            return PlusClouds.Execute<UpdateResponse>(forgotPassword, Method.POST, userForgotPasswordConfirmRequest);
        }
    }
}