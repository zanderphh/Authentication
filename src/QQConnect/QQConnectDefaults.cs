﻿namespace Myvas.AspNetCore.Authentication
{
    public static class QQConnectDefaults
    {
        /// <summary>
        /// QQ
        /// </summary>
        public const string AuthenticationScheme = "QQConnect";

        /// <summary>
        /// QQ
        /// </summary>
        public const string DisplayName = "QQConnect";

        /// <summary>
        /// QQ
        /// </summary>
        public const string ClaimsIssuer = "QQConnect";

        /// <summary>
        /// /signin-qq
        /// </summary>
        public const string CallbackPath = "/signin-qqconnect";

        public static readonly string AuthorizationEndpoint = "https://graph.qq.com/oauth2.0/authorize";

        public static readonly string TokenEndpoint = "https://graph.qq.com/oauth2.0/token";

        public static readonly string OpenIdEndpoint = "https://graph.qq.com/oauth2.0/me";

        public static readonly string UserInformationEndpoint = "https://graph.qq.com/user/get_user_info";

        public static readonly string UserVipInfoEndpoint = "https://graph.qq.com/user/get_vip_info";

        public static readonly string UserVipRichInfoEndpoint = "https://graph.qq.com/user/get_vip_rich_info";

        public static readonly string PhotoListAlbumEndpoint = "https://graph.qq.com/photo/list_album";

        public static readonly string PhotoUploadPictureEndpoint = "https://graph.qq.com/photo/upload_pic";

    }
}