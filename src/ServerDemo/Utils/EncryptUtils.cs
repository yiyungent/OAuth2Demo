/*
 * https://segmentfault.com/q/1010000003707664
 * 
 * https://blog.csdn.net/weixin_39885282/article/details/80613650
 * 
 * https://segmentfault.com/q/1010000003744294?sort=created
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace ServerDemo.Utils
{
    /// <summary>
    /// 加密相关公共方法
    /// </summary>
    public class EncryptUtils
    {
        private const string CHARS_1 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
        private const string CHARS_2 = "./0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

        /// <summary>
        /// 获取长度为num的随机数（0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz）
        /// </summary>
        /// <param name="num">生成的字符串长度</param>
        public static string getRandomStr1(int num)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                stringBuilder.Append(CHARS_1[new Random().Next(CHARS_1.Length - 1)]);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// 获取长度为num的随机数（./0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz）
        /// </summary>
        /// <param name="num">生成的字符串长度</param>
        public static string getRandomStr2(int num)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 1; i <= num; i++)
            {
                stringBuilder.Append(CHARS_2[new Random().Next(CHARS_2.Length - 1)]);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Base64 encode
        /// </summary>
        public static string base64Encode(string data)
        {
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(data));
        }

        /// <summary>
        /// Base64 decode
        /// </summary>
        public static string base64Decode(string data)
        {
            return Encoding.UTF8.GetString(Convert.FromBase64String(data));
        }

        /// <summary>
        /// md5
        /// </summary>
        public static string md5Hex(string data)
        {
            // 创建MD5类的默认实例：MD5CryptoServiceProvider 
            MD5 md5 = MD5.Create();
            byte[] bs = Encoding.UTF8.GetBytes(data);
            byte[] hs = md5.ComputeHash(bs);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in hs)
            {
                // 以十六进制格式格式化 
                sb.Append(b.ToString("x2"));
            }
            return sb.ToString();
        }

        /// <summary>
        /// sha1
        /// </summary>
        public static string sha1Hex(string data)
        {
            byte[] StrRes = Encoding.UTF8.GetBytes(data);
            HashAlgorithm iSHA = new SHA1CryptoServiceProvider();
            StrRes = iSHA.ComputeHash(StrRes);
            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte iByte in StrRes)
            {
                stringBuilder.AppendFormat("{0:x2}", iByte);
            }

            return stringBuilder.ToString().ToUpper();
        }

        /// <summary>
        /// <para>基于哈希的消息验证代码（HMAC_MD5）</para>
        /// <para>在发送方和接收方共享密钥的前提下，HMAC可用于确定通过不安全信道发送的消息是否已被篡改。</para>
        /// <para>发送方计算原始数据的哈希值，并将原始数据和哈希值放在一个消息中同时传送。接收方重新计算所接收消息的哈希值，并检查计算所得的 HMAC 是否与传送的 HMAC 匹配。
        /// 因为更改消息和重新生成正确的哈希值需要密钥，所以对数据或哈希值的任何更改都会导致不匹配。因此，如果原始的哈希值与计算得出的哈希值相匹配，则消息通过身份验证。</para>
        /// </summary>
        /// <param name="key">秘钥</param>
        /// <param name="value">待加密的数据</param>
        public static string hmacMd5Hex(string key, string value)
        {
            HMAC hmac = HMAC.Create("hmacmd5");
            hmac.Key = Encoding.UTF8.GetBytes(key);
            var code = hmac.ComputeHash(Encoding.UTF8.GetBytes(value));
            return BitConverter.ToString(code).Replace("-", string.Empty);
        }

        /// <summary>
        /// HMAC_SHA_1
        /// </summary>
        public static string hmacSha1(string key, string value)
        {
            HMAC hmac = HMAC.Create("hmacsha1");
            hmac.Key = Encoding.UTF8.GetBytes(key);
            var code = hmac.ComputeHash(Encoding.UTF8.GetBytes(value));
            return BitConverter.ToString(code).Replace("-", string.Empty);
        }

        /// <summary>
        /// HMAC_SHA_256
        /// </summary>
        public static string hmacSha256(string key, string value)
        {
            HMAC hmac = HMAC.Create("hmacsha256");
            hmac.Key = Encoding.UTF8.GetBytes(key);
            var code = hmac.ComputeHash(Encoding.UTF8.GetBytes(value));
            return BitConverter.ToString(code).Replace("-", string.Empty);
        }

        /// <summary>
        /// HMAC_SHA_512
        /// </summary>
        public static string hmacSha512(string key, string value)
        {
            HMAC hmac = HMAC.Create("hmacsha512");
            hmac.Key = Encoding.UTF8.GetBytes(key);
            var code = hmac.ComputeHash(Encoding.UTF8.GetBytes(value));
            return BitConverter.ToString(code).Replace("-", string.Empty);
        }

        /// <summary>
        /// Md5Crypt加密
        /// </summary>
        /// <param name="value">原始数据</param>
        /// <param name="salt">盐，如果为空则会生成一个随机的8位字符串</param>
        public static string md5Crypt(string value, string salt)
        {
            if (salt == null) return value;
            return md5Hex(value + "{" + salt.ToString() + "}");
        }

        /// <summary>
        /// 用于检验使用Md5Crypt.md5Crypt之后的数据是否正确（一般用于登录校验用户密码）
        /// </summary>
        /// <param name="value">待校验的原始数据</param>
        /// <param name="encryptedStr">已有的加密之后的字符串</param>
        /// <returns>待校验的原始数据和加密字符串的原始数据是否相同</returns>
        public static bool checkMd5Crypt(string value, string encryptedStr)
        {
            string newEncryptedStr = md5Crypt(value, encryptedStr);

            return newEncryptedStr.Equals(encryptedStr);
        }


    }
}