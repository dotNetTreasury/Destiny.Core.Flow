﻿using System;
using System.ComponentModel;
using Destiny.Core.Flow.Entity;

namespace Destiny.Core.Flow.IdentityServer.Entities
{
    /// <summary>
    /// 客户端退出重定向uri
    /// </summary>
    public class ClientPostLogoutRedirectUri : IEntity<Guid>
    {
        public Guid Id { get; set; }

        /// <summary>
        /// 客户端id
        /// </summary>
        [DisplayName("客户端id")]
        public string PostLogoutRedirectUri { get; set; }

        /// <summary>
        /// 客户端退出重定向uri
        /// </summary>
        [DisplayName("客户端退出重定向uri")]
        public int ClientId { get; set; }

        /// <summary>
        /// 所属客户端
        /// </summary>
        [DisplayName("所属客户端")]
        public Client Client { get; set; }
    }
}