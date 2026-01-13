using Lextm.SharpSnmpLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SNMPSample
{
    internal class RootConfig
    {
        [JsonPropertyName("devices")]
        public List<DeviceConfig> Devices { get; set; }
    }

    internal class DeviceConfig
    {
        /// <summary>
        /// 機器名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name{ get; set; }

        /// <summary>
        /// IPアドレス
        /// </summary>
        [JsonPropertyName("ip")]
        public string Ip { get; set; }

        /// <summary>
        /// コミュニティ文字列
        /// </summary>
        [JsonPropertyName("community")]
        public string Community { get; set; }

        /// <summary>
        /// バージョン
        /// </summary>
        [JsonPropertyName("version")]
        public VersionCode Version { get; set; }

        /// <summary>
        /// OID
        /// </summary>
        [JsonPropertyName("oids")]
        public string[] Oids { get; set; }

        /// <summary>
        /// ユーザー名
        /// </summary>

        [JsonPropertyName("userName")]
        public string UserName {  get; set; }

        /// <summary>
        /// コンテキスト名
        /// </summary>
        [JsonPropertyName("contextName")]
        public string ContextName { get; set; }

        /// <summary>
        /// 認証方式
        /// </summary>
        [JsonPropertyName("authProtocol")]
        public string AuthProtocol { get; set; }

        /// <summary>
        /// 認証パスワード
        /// </summary>
        [JsonPropertyName("authPassword")]
        public string AuthPassword { get; set; }

        /// <summary>
        /// 暗号化方式
        /// </summary>
        [JsonPropertyName("privProtocol")]
        public string PrivProtocol { get; set; }

        /// <summary>
        /// 暗号化パスワード
        /// </summary>
        [JsonPropertyName("privPassword")]
        public string PrivPassword { get; set; }

        /// <summary>
        /// セキュリティレベル
        /// </summary>
        [JsonPropertyName("securityLevel")]
        public Levels SecurityLevel { get; set; }
    }
}
